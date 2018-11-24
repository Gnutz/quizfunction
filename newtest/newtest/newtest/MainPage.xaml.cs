using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;
using App1.View;
using Xamarin.Forms;

namespace newtest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        int count = 0;
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            /*count++;
            ((Button)sender).Text = $"You clicked {count} times."; */
            switchToQuizSearchPage();
        }

        async void  switchToQuizSearchPage()
        {

            var quizSearchPage = new QuizSearchPage();
            await Navigation.PushModalAsync(new NavigationPage(quizSearchPage));
        }
    }
}
