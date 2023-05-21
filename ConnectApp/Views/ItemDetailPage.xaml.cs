using ConnectApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ConnectApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}