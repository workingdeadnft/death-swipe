using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDeadSwipe.ViewModels;
using Xamarin.Forms;

namespace WorkingDeadSwipe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainSwipeViewModel();
        }
    }
}
