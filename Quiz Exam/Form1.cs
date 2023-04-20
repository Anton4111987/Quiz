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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_Exam
{
    
    public partial class MainForm : Form
    {
        List<Account> accounts=new List<Account> ();
       
        public static string pathAccounts = "Accounts.txt";
        //private object accounts;

        public MainForm()
        {
            InitializeComponent();
            buttonAuth.Enabled= false; // деактивация кнопки авторизации пока не будут введены логин и пароль
            textBoxPassword.Enabled = false; // деактивация поля пароль пока логин пуст

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            formReg.ShowDialog();
            Account account = formReg.Account;
            if (account != null)
            {
                accounts.Add(formReg.Account);
                MessageBox.Show("Вы успешно зарегистрированы!");
                
                string accountAsString = JsonSerializer.Serialize(formReg.Account);
                File.AppendAllText(pathAccounts, "\n"+accountAsString);

            }
            else
                MessageBox.Show("Данные не добавлены!");
           

        }

        private void labelAuthorization_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length >1)
            {
                textBoxPassword.Enabled = true;
            }

        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e) // активация кнопки если введен логин и пароль
        {
           
            if (textBoxLogin.Text.Length >0 )
                buttonAuth.Enabled = true;
        }


        private void textBoxLogin_MouseClick(object sender, MouseEventArgs e) // для очискти текстбокса от Введите логин
        {
            if(textBoxLogin.Text =="Введите логин")
                textBoxLogin.Text = " ";
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e) // для очискти текстбокса от Введите Пароль
        {
            if (textBoxPassword.Text == "Введите пароль")            
                textBoxPassword.Text = " ";
               
               
        }
       /* private void textBoxLogin_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Введите пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(pathAccounts))
            {
                string[] acc= File.ReadAllLines(pathAccounts);
                foreach (string s in acc)
                    accounts.Add(JsonSerializer.Deserialize<Account>(s));
                
                 // распаковка файла с пользователями
            }
           
               /* File.ReadAllLines(path);
            
            List<Account> accountList = new List<Account>();
            foreach (string s in accounts)
            {
                accountList.Add(s);
            }*/

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
           
        }
        private void buttonAuth_Click(object sender, EventArgs e)
        {
            bool Auth = false;
            string[] stringAsAccount = File.ReadAllLines(MainForm.pathAccounts);
            foreach (string s in stringAsAccount)
            {
                Account Ac = JsonSerializer.Deserialize<Account>(s);
                if (textBoxLogin.Text == Ac.Login && textBoxPassword.Text==Ac.Password)
                {
                    Auth = true;
                    break;
                }
            }


            if (Auth)
            {
                PlayMenuForm playMenuForm = new PlayMenuForm();
                playMenuForm.ShowDialog();
            }
            else
                MessageBox.Show("Не правильный логин или пароль", "Ошибка авторизации");
           

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* // обработка закрытия формы именно на крестик красный,
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
                e.Cancel = false;*/
        }

       
    }
}
