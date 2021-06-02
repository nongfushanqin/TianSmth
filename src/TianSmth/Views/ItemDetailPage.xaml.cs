using System.ComponentModel;
using TianSmth.ViewModels;
using Xamarin.Forms;

namespace TianSmth.Views
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