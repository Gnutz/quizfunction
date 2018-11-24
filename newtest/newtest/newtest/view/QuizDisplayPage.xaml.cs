﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;
using App1.ViewModel;
using newtest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuizDisplayPage : ContentPage
    {

        QuizViewModel _viewModel;

        public QuizDisplayPage(Quiz quiz)
        {
            InitializeComponent();


            _viewModel = new QuizViewModel(quiz);
            switchToScoreDisplayPage(quiz, 2000);
            _viewModel.SaveComplete += Handle_SaveComplete;

            BindingContext = _viewModel;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            _viewModel.SaveComplete -= Handle_SaveComplete;
        }

        async void Handle_SaveComplete(object sender, EventArgs eventArgs)
        {
            await DismissPage();
        }

        protected async void Handle_CancelClicked(object sender, EventArgs e)
        {
            await DismissPage();
        }

        async Task DismissPage()
        {
            await Navigation.PopAsync();
        }

        private async void switchToScoreDisplayPage(Quiz completedQuiz, double totalScore)
        {
            var quizDisplayPage = new QuizScoreDisplayPage(completedQuiz, totalScore);
            await Navigation.PushModalAsync(new NavigationPage(quizDisplayPage));
        }
    }

    /*
     [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuizPageDemo : ContentPage
	{
	    bool _isNew;
	    QuizViewModel _viewModel;

	    public QuizPageDemo(Quiz quiz, bool isNew)
	    {
	        InitializeComponent();

	        _isNew = isNew;

	        _viewModel = new QuizViewModel(quiz, isNew);
	       //_viewModel.SaveComplete += Handle_SaveComplete;

	        BindingContext = _viewModel;
	    }

	    protected override void OnDisappearing()
	    {
	        base.OnDisappearing();

	        //_viewModel.SaveComplete -= Handle_SaveComplete;
	    }

	    async void Handle_SaveComplete(object sender, EventArgs eventArgs)
	    {
	        await DismissPage();
	    }

	    protected async void Handle_CancelClicked(object sender, EventArgs e)
	    {
	        await DismissPage();
	    }

	    async Task DismissPage()
	    {
	        if (_isNew)
	            await Navigation.PopModalAsync();
	        else
	            await Navigation.PopAsync();
	    }
    }
}
     */
}