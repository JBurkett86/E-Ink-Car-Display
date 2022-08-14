using E_Ink_Car_Display.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace E_Ink_Car_Display.Views
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