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
        public AnswerAnalyzer AA;

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
            TheTestStats = new TestStats(e.Name, e.Difficulty, EM.CreateEquation(), 5);
            AA = new AnswerAnalyzer(TheTestStats);
        }   


        public void FinishTheTestForTheUser(object sender, EventArgs e)
        {
            float finalScore = (TheTestStats.QuestionsRight / (TheTestStats.QuestionsRight + TheTestStats.QuestionsWrong)) * 100;
            TheTestStats.FinalScore = finalScore; 
        }
        

        public void HandleUserAnsweredAQuestion(object sender, EventArgs e)
        {  
            TheTestStats.TotalQuestions -= 1;  


        }


        public void MarkThatUserGotQuestionWrong(object sender, EventArgs e)
        {
            TheTestStats.QuestionsWrong += 1;

            //now you can create a new equation
            TheTestStats.CurrentEquation = EM.CreateEquation();

            CheckIfUserIsDoneWithTest();
        }


        public void MarkThatUserGotQuestionRight(object sender, EventArgs e)
        {
            TheTestStats.QuestionsRight += 1;

            //now you can create a new equation
            TheTestStats.CurrentEquation = EM.CreateEquation();

            CheckIfUserIsDoneWithTest();
        }


        private void CheckIfUserIsDoneWithTest()
        {
            if (TheTestStats.TotalQuestions <= 0)
            {
                //calculate final score
                float finalScore = (TheTestStats.QuestionsRight*100 / (TheTestStats.QuestionsRight + TheTestStats.QuestionsWrong));

                UserEvents.OnUserFinishedTheTest(this, new FinalScoreEventArgs() { FinalScore = finalScore });
            }
        }

    }
}
