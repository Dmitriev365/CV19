﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : Base.ViewModel
    {
        private string _Title;

        public string Title
        {
            get => Title;
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