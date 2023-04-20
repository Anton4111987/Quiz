using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Exam
{
    public class Account
    {
        public string Login {  get; set; }
        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public Account(string Login, string Password, DateTime Birthday )
        {
            this.Login = Login;
            this.Password = Password;
            this.Birthday = Birthday;
        }

        public override string ToString()
        {
            return $"Login - {Login}\tPassword - {Password}\tBirthday - {Birthday}";
        }








    }
}
