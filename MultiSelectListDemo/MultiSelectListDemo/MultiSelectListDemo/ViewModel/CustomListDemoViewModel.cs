using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MultiSelectListDemo.Model;
using ViewModel;
using Xamarin.Forms;

namespace MultiSelectListDemo.ViewModel
{
    public class CustomListDemoViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<ItemModel> itemsCusines;
        public List<WrappedListItems<ItemModel>> WrappedItems = new List<WrappedListItems<ItemModel>>();

        public CustomListDemoViewModel()
        {
            var cusines = new string[]
            {
                "Indian", "American", "Asian", "Barbecue", "Brazilian", "Chicken Wings", "European",
                "Thai","Spanish","Sandwich","Burger"
            };
            itemsCusines = (from item in cusines
                            select new ItemModel { Name = item }).ToList();
            WrappedItems = itemsCusines.Select(item => new WrappedListItems<ItemModel>() { Item = item, IsChecked = false ,UnChecked = true,ActiveColor = Color.FromHex("#8c8c8c") }).ToList();

        }
        public List<WrappedListItems<ItemModel>> WrappedCusines
        {
            get { return WrappedItems; }

        }
        public List<ItemModel> GetSelectedItems()
        {
            return WrappedItems.Where(item => item.IsChecked).Select(i => i.Item).ToList();
        }
    }
}
