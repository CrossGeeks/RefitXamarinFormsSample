using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.UserDialogs;
using RefitXFSample.Services;

namespace RefitXFSample.ViewModels
{
    public class BaseViewModel: INotifyPropertyChanged
    {
        public IUserDialogs PageDialog = UserDialogs.Instance;
        public IApiManager ApiManager;
        IApiService<IMakeUpApi> makeUpApi = new ApiService<IMakeUpApi>(Config.ApiUrl);
        IApiService<IRedditApi> redditApi = new ApiService<IRedditApi>(Config.RedditApiUrl);
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsBusy { get; set; }
        public BaseViewModel()
        {
            ApiManager = new ApiManager(makeUpApi, redditApi);

        }

        public async Task RunSafe(Task task, bool ShowLoading = true, string loadinMessage = null)
        {
            try
            {
                if (IsBusy) return;

                IsBusy = true;

                if (ShowLoading) UserDialogs.Instance.ShowLoading(loadinMessage ?? "Loading");

                await task;
            }
            catch (Exception e)
            {
                IsBusy = false;
                UserDialogs.Instance.HideLoading();
                Debug.WriteLine(e.ToString());
                await App.Current.MainPage.DisplayAlert("Eror", "Check your internet connection", "Ok");

            }
            finally
            {
                IsBusy = false;
                if (ShowLoading) UserDialogs.Instance.HideLoading();
            }
        }

    }
}
