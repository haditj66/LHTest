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

    /// <summary>
    /// This class will analyze the answer that has been set and decide whether it is correct or wrong.
    /// </summary>
    public class AnswerAnalyzer
    {
        public TestStats TheTestStats; 

        public AnswerAnalyzer(TestStats teststats)
        {
            this.TheTestStats = teststats; 

            UserEvents.UserAnsweredQuestion += AnalyzeAnswer;
        }

        private void AnalyzeAnswer(object sender, AnswerEventArgs e)
        { 

            if(TheTestStats.CurrentEquation.Answer == e.Answer)
            {
                UserEvents.OnUserGotQuestionRight(this, e);
            } 
            else if (TheTestStats.CurrentEquation.Answer != e.Answer)
            {
                UserEvents.OnUserGotQuestionWrong(this, e);
            }

        }

    }
}
