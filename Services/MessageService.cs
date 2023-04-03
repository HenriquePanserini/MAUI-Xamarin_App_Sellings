using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp1.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await MauiApp1.App.Current.MainPage.DisplayAlert("Error: ", message, "Ok");
        }

        public async Task ShowAsync(string title, string message, string text1)
        {
            await MauiApp1.App.Current.MainPage.DisplayAlert(title, message, text1);
        }

        public async Task ShowAsync(string title, string message, string text1, string text2)
        {
            await MauiApp1.App.Current.MainPage.DisplayAlert(title, message, text1, text2);
        }

        public async Task<bool> ShowAsyncBool(string title, string message, string text1, string text2)
        {
            return await MauiApp1.App.Current.MainPage.DisplayAlert(title, message, text1, text2);
        }
    }
}
