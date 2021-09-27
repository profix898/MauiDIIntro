using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        private readonly TimeService _timeService;

        int _count = 0;

        public MainPage(TimeService timeService)
        {
            _timeService = timeService;

            InitializeComponent();

            OnCounterClicked(this, null);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = $"Current count: {_count}";
            TimeLabel.Text = $"Hello World! app created at {_timeService.GetCreatedTime()}.";
        }

        private void OnRecomposeClicked(object sender, EventArgs e)
        {
            (Application.Current as App)?.InitApp();
        }
    }
}
