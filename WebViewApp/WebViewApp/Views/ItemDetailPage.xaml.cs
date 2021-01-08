using System.ComponentModel;
using Xamarin.Forms;
using WebViewApp.ViewModels;

namespace WebViewApp.Views
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