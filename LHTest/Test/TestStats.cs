using LHTest.Equations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Test
{
    /// <summary>
    /// This class will hold the statistics Information of the test being taken.
    /// For example, difficulty level, name of student, number of questions...
    /// </summary>
    public class TestStats
    { 
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public int TotalQuestions { get; set; }
        public int QuestionsWrong { get; set; }
        public int QuestionsRight { get; set; }
        public float FinalScore { get; set; }

        public Equation CurrentEquation { get; set; }  

        public TestStats(string Name, string Difficulty, Equation currentEquation, int TotalQuestions = 10)
        {
            this.Name = Name;
            this.Difficulty = Difficulty;
            this.TotalQuestions = TotalQuestions;
            this.CurrentEquation = currentEquation;

        }


        public enum Difficulties
        {
            Easy,
            Medium,
            Hard
        }
    }
}
