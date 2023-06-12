using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Exam
{
    public class PlayerTable
    {
        public Account Account {get;set;}
        
        public string NameQuiz { get;set;}
        
        public int Score {get;set;}

       

        public PlayerTable(Account Account, string NameQuiz, int Score)
        {
           
            this.Account = Account;
            this.NameQuiz = NameQuiz;
            this.Score = Score;
            
        }
        public override string ToString()
        {
            return $"Логин: {Account.Login} - Название викторины: {NameQuiz} - Количество баллов: {Score}";
        }

    }
}
