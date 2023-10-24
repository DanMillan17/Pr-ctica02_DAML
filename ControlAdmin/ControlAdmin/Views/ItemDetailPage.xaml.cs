using ControlAdmin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ControlAdmin.Views
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