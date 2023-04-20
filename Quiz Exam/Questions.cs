using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Exam
{
    abstract class Questions
    {
        public string CategoryQuestions { get; set; }

        public string Quest {get; set; }

        public string AnswerOptions { get; set; }
        public string CorrectAnswer {get; set; }

        public Questions(string CategoryQuestions, string Quest, string AnswerOptions, string CorrectAnswer )
        {
            this.CategoryQuestions = CategoryQuestions;
            this.Quest = Quest;
            this.AnswerOptions = AnswerOptions;
            this.CorrectAnswer = CorrectAnswer;

        }

        public override string ToString()
        {
            return $"Категория вопросов - {CategoryQuestions}\tВопрос - {Quest}\tВарианты ответов - {AnswerOptions}\tПравильный ответ - {CorrectAnswer}";
        }




    }
}
