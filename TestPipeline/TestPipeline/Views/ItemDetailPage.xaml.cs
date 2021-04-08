using System.ComponentModel;
using TestPipeline.ViewModels;
using Xamarin.Forms;

namespace TestPipeline.Views
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