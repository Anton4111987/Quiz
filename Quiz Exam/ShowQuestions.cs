using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Exam
{
    public partial class ShowQuestions : Form
    {
        public List<Question> Questions { get; set; }
        public ShowQuestions()
        {
            InitializeComponent();
        }
        public ShowQuestions(List<Question> Questions, bool isShow)
        {
            this.Questions = Questions;
            InitializeComponent();
            foreach (Question Q in Questions) // добавление коллекции в листбокс и показ
            {
                listBox.Items.Add(Q);
            }
        }
       
        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {                
                Question editQuestion = listBox.SelectedItem as Question;
                EditQuestions editQuestions = new EditQuestions(editQuestion, true);
                editQuestions.ShowDialog();
                listBox.Items[listBox.SelectedIndex] = editQuestions.Question;
                Questions.Clear();
                foreach(Question Q in listBox.Items)
                    Questions.Add(Q);                
                File.WriteAllText(Play.pathQuestions, JsonSerializer.Serialize(Questions),Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("Выберете пункт списка для обновления");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
