using MauiApp1.Services;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui.Core;

namespace MauiApp1.Views;

public partial class Login : ContentPage
{
	IMessageService _messageService;

	public Login()
	{
		InitializeComponent();
		
		_messageService= new MessageService();

	}

	public async Task Button_Clicked_task(object sender, EventArgs e)
    {
		try 
		{
            ContentPage content = new ContentPage();

            var Enter_user = Convert.ToString(Entry_user.Text);
            var Enter_pass = Convert.ToString(Entry_pass.Text);

			if(Enter_user.ToString() != string.Empty && Enter_pass.ToString() != string.Empty) 
			{
				try 
				{
					var toast = Toast.Make("Bem-vindo!", ToastDuration.Long ,14);
					await Navigation.PushModalAsync(new MainMenu());

				}catch(Exception ex)
				{
                    _messageService.ShowAsync("Erro", "Erro ao acessar a pagina", "Ok");
                }

			
			}
		}
		catch (Exception ex)
		{
			_messageService.ShowAsync("Erro", "Erro ao acessar a pagina", "Ok");
		}
			

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

		Button_Clicked_task(sender, e);

    }
}