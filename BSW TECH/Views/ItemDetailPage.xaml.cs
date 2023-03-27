using BSW_TECH.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BSW_TECH.Views
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