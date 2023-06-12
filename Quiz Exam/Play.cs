using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Exam
{
    public class Play
    {
        public int Score { get; set; } // количество правильных ответов

        public static readonly string pathQuestions= "Questions.json";

        public readonly string pathPlayersTable = "PlayersTable.txt";

        public List<Question> Questions { get; set; }
        public List<PlayerTable> PlayersTables { get; set; } // список игроков

        public Play()
        {           
           Questions = new List<Question>();
           PlayersTables= new List<PlayerTable>();           
           Deserialize(); // десериализация, распаковка файла с вопросами и запись в список вопросов         
        }
     
        public void Serialize() // функция сериализации
        {            
            File.WriteAllText(pathQuestions, JsonSerializer.Serialize(Questions));
        }

        public void Deserialize()
        {
            try
            {
                if (System.IO.File.Exists(pathQuestions))
                {
                    string str = File.ReadAllText(pathQuestions);
                    Questions = JsonSerializer.Deserialize<List<Question>>(str);
                }
                else
                    MessageBox.Show("Отсутствует файл с вопросами", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Десериализация не выполнена", "Ошибка");
            }
        }
        // -------------------------------------------------------------------------------------------
        public void SerializePT() // функция сериализации для списка игроков в таблице
        {
            File.WriteAllText(pathPlayersTable, JsonSerializer.Serialize(PlayersTables));
        }

        public void DeserializePT()
        {
            try
            {
                if (System.IO.File.Exists(pathPlayersTable))
                {

                    string str = File.ReadAllText(pathPlayersTable);
                    PlayersTables = JsonSerializer.Deserialize<List<PlayerTable>>(str);
                }
                else MessageBox.Show("Список игроков отсутствует", "Файл не найден");

            }
           catch
            {
                MessageBox.Show("Десериализация не выполнена", "Ошибка");
            }
               
        }
        // -------------------------------------------------------------------------------------------

        public void AddQuestions()
        {
            string pass = "Questions.txt";
            string[] AllString = File.ReadAllLines(pass);

            for (int i = 0; i < AllString.Length; i++)
            {
                string[] OneString = AllString[i].Split('=');
                string Number = OneString[0];
                string cat = OneString[1];
                string Quest = OneString[2];
                string[] AnswerOpt = OneString[3].Split(';');               
                string  CorrectAns = OneString[4];               
                Questions.Add(new Question(Number, cat, Quest, AnswerOpt, CorrectAns));

            }
        }
       
        public string FinishPlay()
        {
            return $"Викторина закончена, вы набрали очков - {Score} очков"; 
        }
    }
}
