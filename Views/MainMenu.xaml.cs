using MauiApp1.Services;

namespace MauiApp1.Views;

public partial class MainMenu : ContentPage
{
	MessageService _messageService;

	public MainMenu()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

            await Navigation.PushModalAsync(new ListClient());


        }
        catch(Exception ex)
		{
            _messageService.ShowAsync("Erro", "Erro ao acessar a pagina", "Ok");
        }
    }
}