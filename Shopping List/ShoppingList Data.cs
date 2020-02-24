using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace Shopping_List
{
    public class ShoppingList_Data : INotifyPropertyChanged
    {
        List<String> items = new List<string>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<String> Items => items.ToArray();

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(string item)
        {
            items.Remove(item);
        }

       
    }
}
