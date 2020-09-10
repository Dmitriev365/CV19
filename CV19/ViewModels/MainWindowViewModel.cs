using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title = "Data Analisys";

        public string Title
        {
            get => _Title;
            //set
            //{
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnPropertyChanged();

                //Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        }
    }
}
