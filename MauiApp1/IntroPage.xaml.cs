using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace MauiApp1
{
    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();
        }

        private async void OnBtnContinueClicked(object sender, EventArgs e)
        {
            // Do some work ...
            ProgressLabel.Text = "Working ... 1/3";
            await Task.Delay(1000);
            ProgressLabel.Text = "Working ... 2/3";
            await Task.Delay(1000);
            ProgressLabel.Text = "Working ... 3/3";
            await Task.Delay(1000);

            Completed?.Invoke();
        }

        public event Action Completed;
    }
}