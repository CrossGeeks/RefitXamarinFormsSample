using System.Threading.Tasks;
using Refit;
using Xamarin.Forms;

namespace RefitXFSample
{
    public partial class MainPage : TabbedPage
    {
        ViewModels.MainPageViewModel _viewModel = new ViewModels.MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.GetDataCommand.Execute(null);
            _viewModel.GetTimeLineDataCommand.Execute(null);

        }

    }
}
