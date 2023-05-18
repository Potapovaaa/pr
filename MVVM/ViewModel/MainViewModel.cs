using MVVM.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModel
{
    internal class MainViewModel:BindingHelper
    {
        private void buttonvxod_Click(object sender, RoutedEventArgs e)
        {
            klava window = new klava();
            window.Show();
            
        }
    }
}
