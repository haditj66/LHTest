using LHTest.Test.EventManager.EventArgClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Test.EventManager
{


    /// <summary>
    /// This is the Class Where The UI Module plugs into. This is the key to Encapsulating the module.
    /// THE UI MODULE ONLY INTERACTS WITH THE METHODS WITHIN THIS CLASS AND NOTHING ELSE. THE MODULE DOES NOT 
    /// TOUCH ANY OTHER CLASSES WITHIN THIS PROJECT!! ANYTHING THE UI MODULE WILL NEED WILL BE BY ENTRY POINT OF THIS CLASS ONLY.
    /// </summary>
    public static class UserEvents
    {  

        public static EventHandler<StartedTestEventArgs> UserStartedTheTest;

        public static void OnUserStartedTest(object theClallingClass, StartedTestEventArgs e)
        {
            if (UserStartedTheTest != null)
            {
                UserStartedTheTest(theClallingClass, e);
            }
        }

        public static EventHandler<FinalScoreEventArgs> UserFinishedTheTest;

        public static void OnUserFinishedTheTest(object theClallingClass, FinalScoreEventArgs e)
        {
            if (UserFinishedTheTest != null)
            {
                UserFinishedTheTest(theClallingClass, e);
            }
        }



        public static EventHandler<AnswerEventArgs> UserAnsweredQuestion;

        public static void OnUserAnsweredQuestion(object theClallingClass, AnswerEventArgs e)
        {
            if (UserAnsweredQuestion != null)
            {
                UserAnsweredQuestion(theClallingClass, e);
            }
        }

        public static EventHandler<AnswerEventArgs> UserGotQuestionWrong;

        public static void OnUserGotQuestionWrong(object theClallingClass, AnswerEventArgs e)
        {
            if (UserGotQuestionWrong != null)
            {
                UserGotQuestionWrong(theClallingClass, e);
            }
        }

        public static EventHandler<AnswerEventArgs> UserGotQuestionRight;

        public static void OnUserGotQuestionRight(object theClallingClass, AnswerEventArgs e)
        {
            if (UserGotQuestionRight != null)
            {
                UserGotQuestionRight(theClallingClass, e);
            }
        } 


    }
}
