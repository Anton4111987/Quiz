using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Quiz_Exam
{
    public partial class EditQuestions : Form
    {
        public Question Question { get; set; }

        public EditQuestions()
        {
            InitializeComponent();
            Question = null;
        }
        public EditQuestions(Question question, bool isEdit)
        {
            Question = question;
            InitializeComponent();
            textBoxQuestion.Text = Question.Quest;
            textBoxAnswer1.Text = Question.AnswerOptions[0];
            textBoxAnswer2.Text = Question.AnswerOptions[1];
            textBoxAnswer3.Text = Question.AnswerOptions[2];
            textBoxAnswer4.Text = Question.AnswerOptions[3];
            textBoxCorrectAnswer.Text = Question.CorrectAnswer;
        }

        private void EditQuestions_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        {
            string NumberQuestion = Question.NumberQuestions;
            string CategoryQuestion= Question.CategoryQuestions;
            string Quest = textBoxQuestion.Text;            
            string[] AnswerOtions=new string[Question.AnswerOptions.Length];
            AnswerOtions[0] = textBoxAnswer1.Text;
            AnswerOtions[1] = textBoxAnswer2.Text;
            AnswerOtions[2] = textBoxAnswer3.Text;
            AnswerOtions[3] = textBoxAnswer4.Text;
            string CorrectAnswer = textBoxCorrectAnswer.Text;
            Question = new Question(NumberQuestion, CategoryQuestion, Quest, AnswerOtions, CorrectAnswer);            
            Close();
        }
    }
}
