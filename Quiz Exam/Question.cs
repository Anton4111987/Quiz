using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Exam
{
    public class Question
    {
        public string NumberQuestions { get; set; }
        public string CategoryQuestions { get; set; }

        public string Quest {get; set; }

        public string [] AnswerOptions { get; set; }
       // public string [] CorrectAnswer {get; set; }

        public string CorrectAnswer { get; set; }
        public Question(string NumberQuestions,string CategoryQuestions, string Quest, string [] AnswerOptions, string CorrectAnswer )
        {
            this.NumberQuestions = NumberQuestions;
            this.CategoryQuestions = CategoryQuestions;
            this.Quest = Quest;
            this.AnswerOptions = AnswerOptions;
            this.CorrectAnswer = CorrectAnswer;

        }

        public override string ToString()
        {
            StringBuilder AnsOpt = new StringBuilder();
            StringBuilder CorrAns = new StringBuilder();
            for (int i = 0; i < AnswerOptions.Length; i++)
            {
                if (i != AnswerOptions.Length - 1)
                    AnsOpt.Append(AnswerOptions[i] + ",");
                else AnsOpt.Append(AnswerOptions[i]);

            }
           /* for (int i = 0; i < CorrectAnswer.Length; i++)
            {
                if (i != CorrectAnswer.Length - 1)
                    CorrAns.Append(CorrectAnswer[i] + ",");
                else CorrAns.Append(CorrectAnswer[i]);

            }*/

            //return $"Категория вопросов - {CategoryQuestions}\tВопрос - {Quest}\tВарианты ответов - {AnswerOptions[1]}\tПравильный ответ - {CorrectAnswer}";
            return $"Номер вопроса - {NumberQuestions}\tКатегория вопросов - {CategoryQuestions}\tВопрос - {Quest}\tВарианты ответов - {AnsOpt}\tПравильный(ые) ответ(ы) - {CorrectAnswer}";
        }




    }
}
