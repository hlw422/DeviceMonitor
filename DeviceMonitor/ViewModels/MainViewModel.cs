using DeviceMonitor.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMonitor.ViewModels
{
    public class MainViewModel:INotifyPropertyChanged
    {
        public Command MenuShowCommand { get; set; }

        public object ? CurrentPage { get; set; }

        public MainViewModel() 
        {
            MenuShowCommand = new Command(DoMenuShow);
        }

        //通知属性的变化
        public event PropertyChangedEventHandler? PropertyChanged;

        private void DoMenuShow(Object? obj)
        {
            CurrentPage = obj;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
        }
    }
}
