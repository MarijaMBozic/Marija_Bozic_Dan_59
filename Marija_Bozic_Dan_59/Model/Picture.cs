using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Marija_Bozic_Dan_59.Model
{
    public class Picture: INotifyPropertyChanged
    {
        public int PictureId { get; set; }
        public string NamePath { get; set; }
        public bool isMatch;
        public bool IsMatch
        {
            get
            {
                return isMatch;
            }
            set
            {
                isMatch = value;
                OnPropertyChanged("IsMatch");
            }
        }
        public bool isShown;
        public bool IsShown
        {
            get
            {
                return isShown;
            }
            set
            {
                isShown = value;
                OnPropertyChanged("IsShown");
            }
        }
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
