using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ViewModel
{
    public class WrappedListItems<T> : INotifyPropertyChanged
    {
        public T Item { get; set; }
        bool isChecked = false;
        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("IsChecked"));
                }
            }
        }
        private bool unChecked = true;
        public bool UnChecked
        {
            get
            {
                return unChecked;
            }
            set
            {
                if (unChecked != value)
                {
                    unChecked = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("UnChecked"));
                }
            }
        }
        private Color activeColor = Color.FromHex("b3b3b3");
        public Color ActiveColor
        {
            get { return activeColor; }
            set
            {
                if (IsChecked)
                {
                    activeColor = Color.FromHex("#4d2e00");
                }
                else
                {
                    activeColor = Color.FromHex("#8c8c8c");
                }
                PropertyChanged(this, new PropertyChangedEventArgs("ActiveColor"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
