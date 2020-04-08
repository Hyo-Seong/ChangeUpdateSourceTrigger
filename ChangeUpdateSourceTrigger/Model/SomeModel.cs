using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangeUpdateSourceTrigger.Model
{
    public class SomeModel : INotifyPropertyChanged
    {
        private string someText { get; set; }
        public string SomeText
        {
            get { return someText; }
            set
            {
                if (value.Length > 10)
                {
                    OverTen = true;
                }
                else
                {
                    OverTen = false;
                }
                someText = value;
                NotifyPropertyChanged();
            }
        }

        private bool overTen;
        public bool OverTen
        {
            get { return overTen; }
            set
            {
                overTen = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            if (!String.IsNullOrEmpty(name))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
