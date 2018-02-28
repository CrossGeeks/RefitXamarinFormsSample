using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using RefitXFSample.Models;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace RefitXFSample.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {
        public ObservableCollection<MakeUp> MakeUps {get;set;}
        public ObservableCollection<News> News { get; set; }
        public ICommand GetDataCommand {get; set;}
        public ICommand GetTimeLineDataCommand { get; set; }

        public MainPageViewModel() 
        {
            GetDataCommand= new Command(async()=>await RunSafe(GetData()));
            GetTimeLineDataCommand= new Command(async () => await RunSafe(GetTimeLine()));
        }

        async Task GetData(){

            var makeUpsResponse = await ApiManager.GetMakeUps("maybelline");

            if(makeUpsResponse.IsSuccessStatusCode){
                var response = await makeUpsResponse.Content.ReadAsStringAsync();
                var json = await Task.Run(() => JsonConvert.DeserializeObject<List<MakeUp>>(response));
                MakeUps = new ObservableCollection<MakeUp>(json);
            }else{
                await PageDialog.AlertAsync("Unable to get data", "Error", "Ok");
            }
        }

        async Task GetTimeLine()
        {
            var timelineResponse = await ApiManager.GetNews();

            if (timelineResponse.IsSuccessStatusCode)
            {
                var response = await timelineResponse.Content.ReadAsStringAsync();
                var json = await Task.Run(() => JsonConvert.DeserializeObject<RootNews>(response));
                News = new ObservableCollection<News>(json.Data.News);
            }
            else
            {
                await PageDialog.AlertAsync("Unable to get data", "Error", "Ok");
            }
        }
    }
}
