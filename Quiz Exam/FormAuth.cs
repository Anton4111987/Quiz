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
        public static double uniqueId = 1; // для уникального идентификатора в классе аккаунт

        public static List<Account> accounts=new List<Account> ();
       
        public static string pathAccounts = "Accounts.txt";

        public Account CurrAccount; // текущий аккаунт для сохранения в процессе игры данных

        public MainForm()
        {
            InitializeComponent();
            buttonAuth.Enabled= false; // деактивация кнопки авторизации пока не будут введены логин и пароль
            textBoxPassword.Enabled = false; // деактивация поля пароль пока логин пуст
           
        }

        private void buttonReg_Click(object sender, EventArgs e) // кнопка регистрации
        {
            FormReg formReg = new FormReg();
            formReg.ShowDialog();
            Account account = formReg.Account;
            if (account != null)
            {
                accounts.Add(formReg.Account);
                MessageBox.Show("Вы успешно зарегистрированы!");                
                string accountAsString = JsonSerializer.Serialize(formReg.Account); // данные пользователя упакованы
                if(System.IO.File.Exists(pathAccounts))
                    File.AppendAllText(pathAccounts, "\n"+accountAsString); // данные пользователя записались в файл 
                else
                    File.AppendAllText(pathAccounts, accountAsString);
            }
            else
                MessageBox.Show("Данные не добавлены!");
           
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length >1)
            {
                textBoxPassword.Enabled = true; // кнопка пароля активирована
            }
        }
        private void textBoxPassword_TextChanged(object sender, EventArgs e) // активация кнопки если введен логин и пароль
        {
            textBoxPassword.UseSystemPasswordChar = true;
            if (textBoxLogin.Text.Length >0 )
                buttonAuth.Enabled = true; // кнопка авторизации активирована
        }


        private void textBoxLogin_MouseClick(object sender, MouseEventArgs e) // для очискти текстбокса от Введите логин
        {
            if(textBoxLogin.Text =="Введите логин")
                textBoxLogin.Text = "";
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e) // для очискти текстбокса от Введите Пароль
        {
            if (textBoxPassword.Text == "Введите пароль")            
                textBoxPassword.Text = "";               
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(pathAccounts))
            {
                string[] acc = File.ReadAllLines(pathAccounts);
                foreach (string s in acc)
                    accounts.Add(JsonSerializer.Deserialize<Account>(s)); // загрузка данных из файла в листбокс                
                uniqueId = Convert.ToDouble(accounts.Max(A => A.ID)) + 1; // счет id чтобы при регистрации нового пользователя нумерация id продолжалась
            }           
            else
                MessageBox.Show("Отсутствует файл авторизации", "Программа запущена впервые");
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            bool Auth = false;
            if (System.IO.File.Exists(pathAccounts))
            {
                string[] stringAsAccount = File.ReadAllLines(MainForm.pathAccounts);
                foreach (string s in stringAsAccount)
                {
                    CurrAccount = JsonSerializer.Deserialize<Account>(s);
                    if (textBoxLogin.Text == CurrAccount.Login && textBoxPassword.Text == CurrAccount.Password)
                    {
                        Auth = true;
                        break;
                    }
                }
                if (Auth)
                {                   
                    PlayMenuForm playMenuForm = new PlayMenuForm(CurrAccount);                    
                    playMenuForm.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Не правильный логин или пароль", "Ошибка авторизации");

            }
            else
                MessageBox.Show("Отсутствует файл авторизации", "Ошибка");
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
