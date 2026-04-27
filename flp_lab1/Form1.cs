using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace flp_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Проверка заполнения полей
            if (string.IsNullOrWhiteSpace(txtOutgoingNumber.Text) ||
                string.IsNullOrWhiteSpace(txtIncomingNumber.Text) ||
                string.IsNullOrWhiteSpace(txtIncomingDate.Text) ||
                string.IsNullOrWhiteSpace(txtRecipientOrganization.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtShortName.Text) ||
                string.IsNullOrWhiteSpace(txtSubject.Text) ||
                string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtBody.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string templatePath = Path.Combine(Application.StartupPath, "Template.docx");

            if (!File.Exists(templatePath))
            {
                templatePath = @"C:\Template.docx";
            }

            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Файл шаблона не найден!\n" +
                    "Поместите Template.docx в папку с программой или в C:\\Template.docx",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveFileDialog1.Filter = "Word Document|*.docx";
            saveFileDialog1.FileName = $"Письмо_{DateTime.Now:yyyyMMdd_HHmmss}.docx";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog1.FileName;

                try
                {
                    File.Copy(templatePath, outputPath, true);

                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(outputPath, true))
                    {
                        ReplacePlaceholdersImproved(wordDoc);
                        wordDoc.MainDocumentPart.Document.Save();
                    }

                    MessageBox.Show($"Документ успешно создан!\n{outputPath}", "Готово",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Открыть созданный документ?", "Просмотр",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(outputPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при генерации документа:\n{ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void ReplacePlaceholdersImproved(WordprocessingDocument wordDoc)
        {
            var replacements = GetReplacementsDictionary();

            
            ReplaceTextInBody(wordDoc.MainDocumentPart.Document.Body, replacements);

           
            foreach (var headerPart in wordDoc.MainDocumentPart.HeaderParts)
            {
                if (headerPart.Header != null)
                    ReplaceTextInBody(headerPart.Header, replacements);
            }

            foreach (var footerPart in wordDoc.MainDocumentPart.FooterParts)
            {
                if (footerPart.Footer != null)
                    ReplaceTextInBody(footerPart.Footer, replacements);
            }
        }

        
        private void ReplaceTextInBody(OpenXmlElement element, Dictionary<string, string> replacements)
        {
            
            var paragraphs = element.Descendants<Paragraph>().ToList();

            foreach (var paragraph in paragraphs)
            {
                
                var textElements = paragraph.Descendants<Text>().ToList();

                if (textElements.Count == 0) continue;

                
                string fullText = string.Concat(textElements.Select(t => t.Text));

                
                bool hasPlaceholder = false;
                foreach (var placeholder in replacements.Keys)
                {
                    if (fullText.Contains(placeholder))
                    {
                        hasPlaceholder = true;
                        break;
                    }
                }

                if (!hasPlaceholder) continue;

                
                string newText = fullText;
                foreach (var placeholder in replacements)
                {
                    newText = newText.Replace(placeholder.Key, placeholder.Value);
                }

                
                paragraph.RemoveAllChildren<Run>();

                var newRun = new Run();
                var newTextElement = new Text(newText);

                
                if (textElements.First().Parent is Run firstRun)
                {
                    
                    var runProperties = firstRun.RunProperties?.Clone();
                    if (runProperties != null)
                        newRun.RunProperties = (RunProperties)runProperties;
                }

                newRun.Append(newTextElement);
                paragraph.Append(newRun);
            }
        }

        private Dictionary<string, string> GetReplacementsDictionary()
        {
            return new Dictionary<string, string>
            {
                { "{CURRENT_DATE}", DateTime.Now.ToString("dd.MM.yyyy") },
                { "{OUTGOING_NUMBER}", txtOutgoingNumber.Text },
                { "{INCOMING_NUMBER}", txtIncomingNumber.Text },
                { "{INCOMING_DATE}", txtIncomingDate.Text },
                { "{RECIPIENT_ORGANIZATION}", txtRecipientOrganization.Text },
                { "{RECIPIENT_POSITION}", txtPosition.Text },
                { "{RECIPIENT_NAME}", txtFullName.Text },
                { "{RECIPIENT_NAME_SHORT}", txtShortName.Text },
                { "{LETTER_SUBJECT}", txtSubject.Text },
                { "{RECIPIENT_BODY}", txtBody.Text },
                { "{STUDENT_NAME}", txtStudentName.Text }
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutgoingNumber.Clear();
            txtIncomingNumber.Clear();
            txtIncomingDate.Clear();
            txtRecipientOrganization.Clear();
            txtPosition.Clear();
            txtFullName.Clear();
            txtShortName.Clear();
            txtSubject.Clear();
            txtStudentName.Clear();
            txtBody.Clear();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            txtOutgoingNumber.Text = "15/05";
            txtIncomingNumber.Text = "28/04";
            txtIncomingDate.Text = "20.04.2026";
            txtRecipientOrganization.Text = "ООО \"Станкин\"";
            txtPosition.Text = "Старосте";
            txtFullName.Text = "Петрову Петру Викторовичу";
            txtShortName.Text = "Пётр Викторович";
            txtSubject.Text = "О сдаче лабораторных работ";
            txtStudentName.Text = "Иванов Роман Валерьевич";
            txtBody.Text = "Прошу разрешить мне сдать лабораторные работы. Все задания выполнены в полном объеме и готовы к защите.";
        }
    }
}