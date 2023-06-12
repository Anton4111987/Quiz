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
    public partial class FormEditAccount : Form
    {
        public Account Account { get; set; }
        public FormEditAccount(Account Account)
        {
            InitializeComponent();
            this.Account = Account;
            textBoxEditLog.Text = Account.Login;
            textBoxEditPass.Text = Account.Password;
            textBoxEditBirthday.Text = Account.Birthday.ToString();
        }
        public bool VerificationLogin() // проверка не существует ли уже данного логина
        {
            bool LoginUse = false;
            string[] stringAsAccount = File.ReadAllLines(MainForm.pathAccounts);
            foreach (string s in stringAsAccount)
            {
                Account Ac = JsonSerializer.Deserialize<Account>(s);
                if (textBoxEditLog.Text == Ac.Login)
                {
                    LoginUse = true;
                    break;
                }
            }
            return LoginUse;
        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            if (VerificationLogin())
            {
                MessageBox.Show("Этот логин уже используется", "Ошибка ввода логина");
                textBoxEditLog.Text = "";
                textBoxEditLog.Focus();
            }
            else
            {
                string Log = textBoxEditLog.Text;
                string Pass = textBoxEditPass.Text;
                string birth = textBoxEditBirthday.Text;
                double id = Account.ID;
                if (textBoxEditBirthday.Text.Length > 0)
                {
                    try
                    {
                        DateTime birthday = Convert.ToDateTime(birth);
                        Account = new Account(id,Log, Pass, birthday);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                }
                Close();
            }
        }

    }
}



