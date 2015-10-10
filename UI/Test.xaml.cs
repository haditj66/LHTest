using LHTest.Test;
using LHTest.Test.EventManager;
using LHTest.Test.EventManager.EventArgClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        TestManager TM;

        public Test(TestManager tm)
        {
            InitializeComponent();

            this.TM = tm;

            TotalQuestionsLabel.Content = TM.TheTestStats.TotalQuestions;
            EquationLabel.Content = TM.TheTestStats.CurrentEquation.FullEquation;
            OLabel.Visibility = Visibility.Hidden;
            XLabel.Visibility = Visibility.Hidden;

            UserEvents.UserGotQuestionWrong += ShowBigRedX;
            UserEvents.UserGotQuestionRight += ShowBigGreenO;
            UserEvents.UserFinishedTheTest += ShowFinalResults;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            //first read the user's answer 
            float userAnswer = float.Parse(AnswerTextBox.Text);

            //then fire ov the event that te user answered a question 
            UserEvents.OnUserAnsweredQuestion(this, new AnswerEventArgs() { Answer = userAnswer });

            //reset the label and textbox and total questions 
            TotalQuestionsLabel.Content = TM.TheTestStats.TotalQuestions;
            EquationLabel.Content = TM.TheTestStats.CurrentEquation.FullEquation;
            AnswerTextBox.Clear();

        }

        private async void ShowBigRedX(object sender, EventArgs e)
        {
            //await Task.Run(() =>
            //    {
                    XLabel.Visibility = Visibility.Visible;
                    OLabel.Visibility = Visibility.Hidden;
                    //System.Threading.Thread.Sleep(2000);
                    //XLabel.Visibility = Visibility.Hidden;
                //});
        }

        private async void ShowBigGreenO(object sender, EventArgs e)
        {
            //await Task.Run(() =>
            //{
                XLabel.Visibility = Visibility.Hidden;
                OLabel.Visibility = Visibility.Visible;
                //System.Threading.Thread.Sleep(2000);
                //OLabel.Visibility = Visibility.Hidden;
            //});
        }  

        private void ShowFinalResults(object sender, FinalScoreEventArgs e)
        {
            FinalResults FR = new FinalResults(e);
            FR.Show();
        } 


    }
}
