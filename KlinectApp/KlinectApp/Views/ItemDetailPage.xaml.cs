using KlinectApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace KlinectApp.Views
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