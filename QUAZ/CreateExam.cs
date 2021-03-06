﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace QUAZ
{
    public partial class CreateExam : UserControl
    {
        public List<MetroFramework.Controls.MetroRadioButton> RadioButtonAnswers { get; set; }
        public List<MetroFramework.Controls.MetroTextBox> RadioButtonAnswersText { get; set; }

        public int AnswerCount { get => RadioButtonAnswers.Count; }
        public string QuestionText { get => txtboxQuestion.Text; set => txtboxQuestion.Text = value; }
        public string IsCorrectVariant { get; set; }

        public List<QuestionBlock> Questions { get; set; }

        public List<Answer> _Answers { get; set; }

        CustomMessageBox customMessageBox;
        SimpleForm SimpleForm;
        MainForm MainForm;

        public CreateExam(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm._EditOrCreateExam.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (QuestionText != string.Empty && answerCount.Text != string.Empty && RadioButtonAnswers.Find(x => x.Checked == true) != null
                && RadioButtonAnswersText.Find(x => x.Text == null || x.Text == string.Empty) == null)
            {
                string selectedFileName = string.Empty;
                string testpath = string.Empty;

                #region Old Code

                //if (File.Exists(testpath))
                //{
                //    using (StreamReader streamReader = new StreamReader(testpath))
                //    {
                //        var obj = (List<QuestionBlock>)xmlSerializer.Deserialize(streamReader);
                //        MainForm.Questions = obj;
                //        MainForm.QuestionCount = MainForm.Questions.Count();
                //        MainForm.UserAnswers = new List<string>();
                //    }
                //}
                #endregion 

                #region Add Answers

                int id = 0;

                for (int i = 0; i < RadioButtonAnswers.Count; i++)
                {
                    if (RadioButtonAnswers[i].Checked)
                    {
                        id = i;
                        break;
                    }
                }

                _Answers = new List<Answer>();

                for (int i = 0; i < RadioButtonAnswers.Count; i++)
                {
                    if (i == id)
                    {
                        _Answers.Add(new Answer()
                        {
                            id = i,
                            Text = RadioButtonAnswersText[i].Text,
                            IsCorrect = "Yes"
                        });
                    }
                    else
                    {
                        _Answers.Add(new Answer()
                        {
                            id = i,
                            Text = RadioButtonAnswersText[i].Text,
                            IsCorrect = "No"
                        });

                    }
                }
                #endregion

                #region Add Questions
              
                Questions.Add(new QuestionBlock()
                {
                    id = Questions.Count - 1,
                    Text = QuestionText,
                    Answers = _Answers
                });

                QuestionText = string.Empty;
                answerCount.Text = string.Empty;

                #endregion

                MainForm.NumberOfQuestion = $"{Questions.Count} Questions";

                btnSave.Enabled = true;

                customMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                customMessageBox.MessageText = "Question added succesfully...";
                customMessageBox.MessageTitle = "Info";
                customMessageBox.ShowDialog();
            }
            else
            {
                customMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                customMessageBox.MessageText = "Please, fill the compulsory area ";
                customMessageBox.MessageTitle = "Info";
                customMessageBox.ShowDialog();
            }
        }

        private void answerCount_TextChanged(object sender, EventArgs e)
        {
            if (answerCount.Text != string.Empty && answerCount.Text.Count() < 9 && int.Parse(answerCount.Text) <= 6)
            {
                RadioButtonAnswers = new List<MetroFramework.Controls.MetroRadioButton>();
                RadioButtonAnswersText = new List<MetroFramework.Controls.MetroTextBox>();

                for (int i = 0, x = 30, y = 200; i < int.Parse(answerCount.Text); i++, y += 30)
                {
                    RadioButtonAnswersText.Add(new MetroFramework.Controls.MetroTextBox());
                    RadioButtonAnswersText[i].Location = new Point(x + 20, y);
                    RadioButtonAnswersText[i].Size = new Size(730, 20);
                    RadioButtonAnswersText[i].UseCustomBackColor = true;
                    RadioButtonAnswersText[i].BackColor = Color.FromArgb(61, 61, 61);
                    RadioButtonAnswersText[i].UseCustomForeColor = true;
                    RadioButtonAnswersText[i].ForeColor = Color.White;
                    this.Controls.Add(RadioButtonAnswersText[i]);

                    RadioButtonAnswers.Add(new MetroFramework.Controls.MetroRadioButton());
                    RadioButtonAnswers[i].Location = new Point(x, y);
                    RadioButtonAnswers[i].Size = new Size(20, 20);
                    RadioButtonAnswers[i].UseCustomBackColor = true;
                    RadioButtonAnswers[i].Style = MetroFramework.MetroColorStyle.Brown;
                    RadioButtonAnswers[i].BackColor = Color.FromArgb(0, 0, 0, 0);
                    this.Controls.Add(RadioButtonAnswers[i]);
                }
            }
            else if (RadioButtonAnswers != null && RadioButtonAnswersText != null)
            {
                for (int i = 0; i < RadioButtonAnswers.Count; i++)
                {
                    this.Controls.Remove(RadioButtonAnswers[i]);
                    this.Controls.Remove(RadioButtonAnswersText[i]);
                }
                RadioButtonAnswers.Clear();
                RadioButtonAnswersText.Clear();
            }
        }

        private void CreateExam_Load(object sender, EventArgs e)
        {
            Questions = new List<QuestionBlock>();

            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SimpleForm = new SimpleForm();

            if (SimpleForm.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter stream = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $@"\EYEquiz\{SimpleForm.FileName.Text}.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionBlock>));
                    serializer.Serialize(stream, Questions);
                }

                customMessageBox = new CustomMessageBox(CustomMessageBoxButtons.OK);
                customMessageBox.MessageText = "Exam saved succesfully...";
                customMessageBox.MessageTitle = "Info";
                customMessageBox.ShowDialog();
            }
        }

        private void answerCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
