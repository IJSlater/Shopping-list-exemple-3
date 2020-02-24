using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shopping_List
{
    /// <summary>
    /// Interaction logic for AdditemControl.xaml
    /// </summary>
    public partial class AdditemControl : UserControl
    {
        public AdditemControl()
        {
            InitializeComponent();
            AddItemButton.Click += OnAddItemButtonClick;

        }
        protected void OnAddItemButtonClick(object sender, RoutedEventArgs arg)
        {
            if (DataContext is ShoppingList_Data data)
            {

                data.Add(box.Text);
                box.Text= " ";
            }

        }
    }
}
