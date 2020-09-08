﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CV19.ViewModel.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool Set<T>(ref T field, T vlue, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, vlue)) return false;
            field = vlue;
            OnPropertyChanged(PropertyName);
            return true;
        }
            

    }
}
