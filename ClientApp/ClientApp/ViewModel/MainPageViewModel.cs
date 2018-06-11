using ClientApp.Helpers;
using ClientApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ClientApp.ViewModel
{
    public class MainPageViewModel:Notificable
    {
        private ClientRepository clientRepository;
        public ObservableCollection<Grouping <string, Client>> Friends { get; set; }
        public Command AddClientCommand
        {
            get;
            set;
        }
        public Command SearchCommand
        {
            get;
            set;
        }
        private string filter;
        private string Filter
        {
            get
            {
                return filter;
            }
            set
            {
                SetValue(ref filter, value);
            }
        }
    }
}
