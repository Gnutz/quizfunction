using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace newtest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuizScoreDisplayPage : ContentPage
	{
	    public QuizScoreDisplayPage(Quiz completedQuiz, double TotalScore)
	    {
	        InitializeComponent();

	    }



	}
}