using ConnectApp.Models;
using ConnectApp.ViewModels;
using ConnectApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConnectApp.Views
{
    public partial class EventsPage : ContentPage
    {
        EventsViewModel _viewModel;

        public EventsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new EventsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}