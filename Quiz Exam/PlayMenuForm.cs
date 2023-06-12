using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_Exam
{
    public partial class PlayMenuForm : Form
    {      
        public Play Play { get; set;}
        
        private int currentQuestionIndex;   // индекс текущего вопроса
        
        private int numberQuestion;
        public string NameQuiz { get; set; } // для названия категории в которой играл игрок
        
        public List<Question> ListQuestionQuiz { get; set; } // список для смешанной викторины
        Account Account { get; set; }
       
        public PlayMenuForm(Account Account)
        {
            this.Account = Account;
            InitializeComponent();
             Play = new Play();
            labelLogin.Text = $"Вы вошли как: {Account.Login}"; // показ логина на форме
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {            
            comboBoxQuiz.Visible = true;
        }

        private void comboBoxQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random RND = new Random();
            comboBoxQuiz.Visible = false; // комбобокс выбора тем викторины скрыт 
           // comboBoxQuiz.SelectedIndex = 0; // для установки значения по умолчанию
            labelQuestion.Visible = true; // показать лэйбл вопроса
            buttonStartQuiz.Visible = false; // кнопка старта викторины становится невидимой
            buttonAnswer.Visible = true; // кнопка ответов становится видимой         
            labelCategory.Visible = true;
            labelCategory.Text = $"Выбрана категория {comboBoxQuiz.Text}";           
            NameQuiz = comboBoxQuiz.Text;
            ListQuestionQuiz = new List<Question>();
            if (comboBoxQuiz.Text == "Смешанная") // для смешанной викторины
            {
                ListQuestionQuiz.Clear();
                int randomValue; // переменная для рандомного значения                
                while (ListQuestionQuiz.Count!=20)
                {
                    randomValue = RND.Next(0, Play.Questions.Count);
                    if (!ListQuestionQuiz.Contains(Play.Questions[randomValue]))
                        ListQuestionQuiz.Add(Play.Questions[randomValue]);
                }
            }
            else
            {
                ListQuestionQuiz.Clear();
                for (int i = 0; i < Play.Questions.Count; i++)
                {
                    if (Play.Questions[i].CategoryQuestions == comboBoxQuiz.Text)
                    {                       
                        ListQuestionQuiz.Add(Play.Questions[i]);                                             
                    }
                }
            }
            ListQuestionQuiz = ListQuestionQuiz.OrderBy(L=>RND.Next()).ToList(); // перемешивание вопросов            
            numberQuestion = 1;
            groupBoxRadioBTN.Visible = true; 
            currentQuestionIndex = 0;
            ShowQuestion(currentQuestionIndex);           
        }

        private void ShowQuestion(int index)
        {
            //----------------------------------------------------------------------
            // для заполнения радиобаттонов не по порядку
            List<int> randomList = new List<int>();
            Random random = new Random();
            int randomValue;
            while (randomList.Count != ListQuestionQuiz[index].AnswerOptions.Length)
            {
                randomValue = random.Next(0, 4);
                if (!randomList.Contains(randomValue))
                    randomList.Add(randomValue);
            }
            //----------------------------------------------------------------------            
            try
            {
                radioButton1.Checked = false; // значение по умолчанию для радиобаттонов (не стоит галочка)
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                labelQuestion.Text = $"{numberQuestion}/20. {ListQuestionQuiz[index].Quest}";
                labelQuestion.Left = PlayMenuForm.ActiveForm.Width / 2 - labelQuestion.Width / 2; // отцентровка label по горизонтали
                // присвоение радиобаттонам значений из вариантов ответов
                radioButton1.Text = ListQuestionQuiz[index].AnswerOptions[randomList[0]];
                radioButton2.Text = ListQuestionQuiz[index].AnswerOptions[randomList[1]];
                radioButton3.Text = ListQuestionQuiz[index].AnswerOptions[randomList[2]];
                radioButton4.Text = ListQuestionQuiz[index].AnswerOptions[randomList[3]];
            }
            catch 
            {
                MessageBox.Show($"Ошибка");
            }
        }
      
        public bool VerifyUserAnswer()
        {           
                if (radioButton1.Checked)
                {                    
                    if(radioButton1.Text == ListQuestionQuiz[currentQuestionIndex].CorrectAnswer)
                        Play.Score++;
                    return true;
                }
                else if (radioButton2.Checked)
                {
                    if (radioButton2.Text == ListQuestionQuiz[currentQuestionIndex].CorrectAnswer)
                        Play.Score++;
                    return true;
                }
                else  if (radioButton3.Checked)
                {
                    if (radioButton3.Text == ListQuestionQuiz[currentQuestionIndex].CorrectAnswer)
                        Play.Score++;
                    return true;
                }
                else if (radioButton4.Checked)
                {
                    if (radioButton4.Text == ListQuestionQuiz[currentQuestionIndex].CorrectAnswer)
                        Play.Score++;
                    return true;
                }

                else
                {
                    MessageBox.Show("Не выбран не один ответ", "Выберите один ответ");
                    return false;
                }             
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if(VerifyUserAnswer())
            {
                currentQuestionIndex++; // увеличение индекса текущего вопроса
                numberQuestion++;
            }            
            ShowQuestion(currentQuestionIndex);
            if (numberQuestion > 19) // надо 19
            {
                groupBoxRadioBTN.Visible = false;
                buttonAnswer.Visible = false;                
                labelQuestion.Text = Play.FinishPlay();
                labelQuestion.Left = PlayMenuForm.ActiveForm.Width / 2 - labelQuestion.Width / 2; // отцентровка label по горизонтали
                Play.PlayersTables.Clear();
                Play.DeserializePT(); // распаковка списка игроков и добавление непосредственно в список
                Play.PlayersTables.Add(new PlayerTable(Account, NameQuiz, Play.Score)); // добавление в список сыгравших
                Play.SerializePT(); // перезапись полного списка
                buttonStartQuiz.Visible = true;
                buttonStartQuiz.Text = "Начать новую викторину";
            }                        
        }

        private void редактированиеВикториныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Account.Login=="Admin")
            {
                ShowQuestions showQuestions = new ShowQuestions(Play.Questions, true);
                showQuestions.ShowDialog();
            }
            else
            {
                MessageBox.Show("Отсутствуют права для редактирования викторины", "Отказ в доступе");
            }            
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Close();           
        }

        private void посмотретьТОП20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NameForm = "Топ-20 лучших игроков";  
            Play.DeserializePT();
            // отсортировать список игроков прошедших викторину по убыванию (ТОП-20)
            Play.PlayersTables =Play.PlayersTables.OrderByDescending((PlayerTable) => PlayerTable.Score).Take(20).ToList();            
            ShowPlayers showPlayers = new ShowPlayers(Play.PlayersTables.ToList(), NameForm);
            showPlayers.ShowDialog();           
        }

        private void просмотрПрошлыхВикторинПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NameForm = $"Последние викторины пользователя {Account.Login}";
            Play.DeserializePT();           
            // получить результаты прошлых викторин пользователя записать их в список
            Play.PlayersTables= Play.PlayersTables.Where((PlayerTable) => PlayerTable.Account.Login == Account.Login).ToList();
            ShowPlayers showPlayers = new ShowPlayers(Play.PlayersTables, NameForm);
            showPlayers.ShowDialog();
        }

        private void редактированиеДанныхПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditAccount EditAccount = new FormEditAccount(Account);
            EditAccount.ShowDialog();            
            Account account = EditAccount.Account;
            try
            {
                if (account != null && Account != EditAccount.Account)
                {
                    MainForm.accounts.Add(EditAccount.Account); // добавление отредактированных данных пользователя как нового с id прежним             
                    MessageBox.Show("Данные пользователя успешно изменены!");
                    for (int i = 0; i < MainForm.accounts.Count; i++)
                        if (MainForm.accounts[i].Login == Account.Login)
                            MainForm.accounts.RemoveAt(i); // удаление старой неотредактированной записи                          
                    File.Delete(MainForm.pathAccounts);
                    foreach (Account A in MainForm.accounts)
                    {
                        if (System.IO.File.Exists(MainForm.pathAccounts))
                            File.AppendAllText(MainForm.pathAccounts, "\n" + JsonSerializer.Serialize(A)); // данные пользователя записались в файл 
                        else
                            File.AppendAllText(MainForm.pathAccounts, JsonSerializer.Serialize(A)); // данные пользователя записались в файл 
                    }
                }
                else
                    MessageBox.Show("Данные не добавлены!");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }
                
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReference showReference = new ShowReference();
            showReference.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();           
        }
        private void PlayMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // обработка закрытия формы именно на крестик красный,
            // предварительно в свойствах нужно включить FormClosing
            DialogResult result = MessageBox.Show("Вы точно хотите выйти?",
                "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // пользователь не хочет выходить
                // то мы должны прервать событие закрытия
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

    }
}
