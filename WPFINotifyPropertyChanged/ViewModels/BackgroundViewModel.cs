﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFINotifyPropertyChanged.ViewModels
{
    public class BackgroundViewModel : ObservableObject
    {
        private Brush _color;

        public Brush Color
        {
            get
            {
                if (_color == null)
                {
                    return Brushes.White;
                }
                else
                {
                    return _color;
                }
            }
            set
            {
                _color = value;
                OnPropertyChanged("Color");
            }
        }
    }
}
