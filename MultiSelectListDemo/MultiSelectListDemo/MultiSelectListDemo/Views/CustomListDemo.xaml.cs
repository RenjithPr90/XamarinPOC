using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiSelectListDemo.Model;
using MultiSelectListDemo.ViewModel;
using ViewModel;
using Xamarin.Forms;

namespace MultiSelectListDemo.Views
{
    public partial class CustomListDemo : ContentPage
    {
        public CustomListDemo()
        {
            InitializeComponent();
            ListViewName.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                var o = (WrappedListItems<ItemModel>)e.SelectedItem;
                o.IsChecked = !o.IsChecked;
                o.UnChecked = !o.UnChecked;
                o.ActiveColor = Color.FromHex("#4d2e00");
                ((ListView)sender).SelectedItem = null;
                var selectedItem = (ItemModel)o.Item;
            };
        }

    }
}
