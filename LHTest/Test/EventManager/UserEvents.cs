using LHTest.Test.EventManager.EventArgClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHTest.Test.EventManager
{
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

        public static EventHandler<EventArgs> UserFinishedTheTest; 

        public static void OnUserFinishedTheTest(object theClallingClass, EventArgs e)
        {
            if (UserFinishedTheTest != null)
            {
                UserFinishedTheTest(theClallingClass, e);
            }
        }



        public static EventHandler<EventArgs> UserAnsweredQuestion;

        public static void OnUserAnsweredQuestion(object theClallingClass, EventArgs e)
        {
            if (UserAnsweredQuestion != null)
            {
                UserAnsweredQuestion(theClallingClass, e);
            }
        }

        public static EventHandler<EventArgs> UserGotQuestionWrong;

        public static void OnUserGotQuestionWrong(object theClallingClass, EventArgs e)
        {
            if (UserGotQuestionWrong != null)
            {
                UserGotQuestionWrong(theClallingClass, e);
            }
        }

        public static EventHandler<EventArgs> UserGotQuestionRight;

        public static void OnUserGotQuestionRight(object theClallingClass, EventArgs e)
        {
            if (UserGotQuestionRight != null)
            {
                UserGotQuestionRight(theClallingClass, e);
            }
        } 


    }
}
