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
        }

        async void OnGetMakeUpClicked(object sender, System.EventArgs e)
        {
            var apiResponse = RestService.For<IMakeUpApi>("http://makeup-api.herokuapp.com");
            var makeUps = await apiResponse.GetMakeUps("maybelline");

            MakeUpList.ItemsSource = makeUps;
        }
    }
}
