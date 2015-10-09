using LHTest.Equations;
using LHTest.Test.EventManager;
using LHTest.Test.EventManager.EventArgClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Test
{
    public class TestManager
    {

        public TestStats TheTestStats;
        public EquationMaker EM;

        public TestManager()
        { 
            UserEvents.UserStartedTheTest += StartTheTest;
            UserEvents.UserAnsweredQuestion += HandleUserAnsweredAQuestion;
            UserEvents.UserFinishedTheTest += FinishTheTestForTheUser;
            UserEvents.UserGotQuestionRight += MarkThatUserGotQuestionRight;
            UserEvents.UserGotQuestionWrong += MarkThatUserGotQuestionWrong;
        } 

        public void StartTheTest(object sender, StartedTestEventArgs e)
        { 
            EM = new EquationMaker();
            TheTestStats = new TestStats(e.Name, e.Difficulty, EM.CreateEquation());  
        }   


        public void FinishTheTestForTheUser(object sender, EventArgs e)
        {
            float finalScore = TheTestStats.QuestionsRight / TheTestStats.TotalQuestions;
            TheTestStats.FinalScore = finalScore; 
        }
        

        public void HandleUserAnsweredAQuestion(object sender, EventArgs e)
        {
            TheTestStats.CurrentEquation = EM.CreateEquation();

            TheTestStats.TotalQuestions -= 1;
        }


        public void MarkThatUserGotQuestionWrong(object sender, EventArgs e)
        {
            TheTestStats.QuestionsWrong += 1;
        }

        public void MarkThatUserGotQuestionRight(object sender, EventArgs e)
        {
            TheTestStats.QuestionsRight += 1;
        }


    }
}
