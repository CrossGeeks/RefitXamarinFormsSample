using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using RefitXFSample.Models;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RefitXFSample.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {
        public ObservableCollection<MakeUp> MakeUps {get;set;}
        public ICommand GetDataCommand {get; set;}

        public MainPageViewModel() 
        {
            GetDataCommand= new Command(async()=>await RunSafe(GetData()));
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
    }
}
