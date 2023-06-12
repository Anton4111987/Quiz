using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Exam
{
    
    public class Account
    {
        public double ID { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public Account()
        {
            ID = 0;
            Login = "User";
            Password = "User";
            Birthday = DateTime.Now;
        }
        public Account(double ID, string Login, string Password, DateTime Birthday)
        {
            this.ID = ID;
            this.Login = Login;
            this.Password = Password;
            this.Birthday = Birthday;

        }

        public Account(string Login, string Password, DateTime Birthday)
        {
            ID = MainForm.uniqueId;
            MainForm.uniqueId++;
            this.Login = Login;
            this.Password = Password;
            this.Birthday = Birthday;

        }
       

        public override string ToString()
        {
            return $"ID - {ID}\tLogin - {Login}\tPassword - {Password}\tBirthday - {Birthday}";
        }








    }
}
