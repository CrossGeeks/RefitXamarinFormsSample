using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;

namespace RefitXFSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.MainPageViewModel();
        }

    }
}
