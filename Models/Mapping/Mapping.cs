using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;
using Newtonsoft.Json;

namespace MauiApp1.Models.Mapping
{
    public class Mapping : INotifyPropertyChanged
    {
        Clientes cliente = new Clientes();

        [JsonProperty("CLICOD")]
        public int ClinomId
        {
            get => cliente.ClinomId;
            set
            {
                cliente.ClinomId = value;

                OnPropertyChanged();
            }
        }

        [JsonProperty("CLINOM")]
        public string Clinom
        {
            get => cliente.Clinom;
            set
            {
                cliente.Clinom = value;

                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
