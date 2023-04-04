using MauiApp1.Models.Mapping;
using MauiApp1.Services;
using Microsoft.Maui.Controls.Xaml.Internals;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

using MauiApp1.Repositories;

namespace MauiApp1.Views;

public partial class ListClient : ContentPage
{
    public ObservableCollection<Mapping> _mapping;

    ClientesRepository _ClientesRepository;
    RestService _restService;

    protected override async void OnAppearing()
    {
        _restService = new RestService();

        string content = Convert.ToString(_restService.GetAllClientes());

        List<Mapping> map = JsonConvert.DeserializeObject<List<Mapping>>(content);

        _mapping = new ObservableCollection<Mapping>(map);

        ClientsData.ItemsSource = _mapping;
        base.OnAppearing();
    }
}