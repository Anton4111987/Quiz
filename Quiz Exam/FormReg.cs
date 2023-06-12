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
    public partial class FormReg : Form
    {
        public bool VerificationLogin() // проверка не существует ли уже данного логина
        {
            bool LoginUse = false;
            if(System.IO.File.Exists(MainForm.pathAccounts))
            {
                string[] stringAsAccount = File.ReadAllLines(MainForm.pathAccounts);
                foreach (string s in stringAsAccount)
                {
                    Account Ac = JsonSerializer.Deserialize<Account>(s);
                    if (textBoxLog.Text == Ac.Login)
                    {
                        LoginUse = true;
                        break;
                    }
                }
                return LoginUse;
            }
            else
            { return false; }
        }
        public Account Account { get; set; }
        public FormReg()
        {
            InitializeComponent();
            textBoxPass.Enabled = false;
            textBoxBirthday.Enabled = false;
            buttonReg.Enabled = false;
            Account = null;           
        }
       
        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLog.Text.Length > 2)
                textBoxPass.Enabled = true;
 
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
           
            if (textBoxPass.Text.Length > 3)
                textBoxBirthday.Enabled = true;            
            if (VerificationLogin())
            {
                MessageBox.Show("Этот логин уже используется", "Ошибка ввода логина");
                textBoxLog.Text = "";
                textBoxLog.Focus();
                textBoxPass.Text = "Введите пароль";
            }
           
        }

        private void textBoxLog_MouseClick(object sender, MouseEventArgs e)
        {           
            if (textBoxLog.Text == "Введите логин")
                textBoxLog.Text = "";
        }

        private void textBoxPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPass.Text == "Введите пароль")
                textBoxPass.Text = "";
        }

        private void textBoxBithdday_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxBirthday.Text == "Введите Дату Рождения")
                textBoxBirthday.Text = "";

        }
        private void textBoxBirthday_TextChanged(object sender, EventArgs e)
        {
            //if(textBoxBirthday.Text.Length > 4)
            buttonReg.Enabled = true;


            //textBoxBirthday.Text = monthCalendar1.SelectionStart.ToString();
            /* else
                 MessageBox.Show("Введен слишком простой пароль, пароль должен быть более 4 символов", "Некорректный ввод пароля");*/

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string Log = textBoxLog.Text;
            string Pass = textBoxPass.Text;
            string birth = textBoxBirthday.Text;
           /* double id = MainForm.uniqueId;
            MainForm.uniqueId++;*/
            if (textBoxBirthday.Text.Length > 0)
            {
                try
                {
                    DateTime birthday = Convert.ToDateTime(birth);
                    Account = new Account(Log, Pass, birthday);
                }
                catch
                {
                    MessageBox.Show("Неверный формат даты, пример ввода (01.01.2001)", "Ошибка корректности ввода даты рождения");
                }
            }

            Close();
        }

       

       
    }
}
