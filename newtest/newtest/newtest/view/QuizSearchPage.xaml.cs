using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using App1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    //This page need a viewmodel
	public partial class QuizSearchPage : ContentPage
	{
		public QuizSearchPage ()
		{
			InitializeComponent ();
           // Thread.Sleep(3000);
		    Quiz quiz = new Quiz();

		    var q1 = new Question();
		    var q2 = new Question();
		    q1.QuestionText = "Hvad står ASE for";
		    q2.QuestionText = "Hvor høj er mount everest";
		    Option op1_1 = new Option();
		    Option op1_2 = new Option();
		    Option op1_3 = new Option();
		    Option op1_4 = new Option();
		    Option op2_1 = new Option();
		    Option op2_2 = new Option();
		    Option op2_3 = new Option();
		    Option op2_4 = new Option();

		    op1_1.OptionText = "Aarhus School of Mathematics";
		    op1_1.IsRight = false;
		    op1_2.OptionText = "Aarhus School of Eletronics";
		    op1_2.IsRight = false;
		    op1_3.OptionText = "Aalborg School of Eletronics";
		    op1_3.IsRight = false;
		    op1_4.OptionText = "Aarhus School of Engineering";
		    op1_4.IsRight = true;
		    op2_1.OptionText = "8848 m";
		    op2_1.IsRight = true;
		    op2_2.OptionText = "8672 m";
		    op2_2.IsRight = false;
		    op2_3.OptionText = "9018 m";
		    op2_3.IsRight = false;
		    op2_4.OptionText = "8901 m";
		    op2_4.IsRight = false;

		    q1.Options = new Option[]{op1_1, op1_2, op1_3, op1_4};
		    q2.Options = new Option[] { op2_1, op2_2, op2_3, op2_4 };

            quiz.Questions = new Question[] {q1, q2};
		   
		    switchToQuizDisplayView(quiz); 
		}

	    //private async void onQuizSelected(object sender, EventArgs e) // probably need this prototype
	    private async  void switchToQuizDisplayView(Quiz selectedQuiz)
	    {
	        var quizDisplayPage = new QuizDisplayPage(selectedQuiz);

	        await Navigation.PushModalAsync(new NavigationPage(quizDisplayPage));
	    }
    }




}