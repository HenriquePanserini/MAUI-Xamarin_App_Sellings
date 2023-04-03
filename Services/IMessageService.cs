using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public interface IMessageService
    {
        //Gera apenas caixa mensagem de alerta
        Task ShowAsync(string message);
        //Gera caixa de mesangem co titulo e um botao de confirmação
        Task ShowAsync(string title, string message, string text1);
        //Gera caixa de mensagem com titulo e dois botoes confirmação/cancelamento
        Task ShowAsync(string title, string message, string text1, string text2);
        //Gera caixa de mensgem com titulo e dois botoes confirmação/cancelamento com efeito verdadeiro e falso
        Task<bool> ShowAsyncBool(string title, string message, string text1, string text2);
    }
}
