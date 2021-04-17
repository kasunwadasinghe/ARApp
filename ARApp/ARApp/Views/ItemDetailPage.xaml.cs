using ARApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ARApp.Views
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