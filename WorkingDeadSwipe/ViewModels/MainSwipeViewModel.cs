using System;
using System.Collections.Generic;
using WorkingDeadSwipe.Models;
using Xamarin.Forms;

namespace WorkingDeadSwipe.ViewModels
{
    public class MainSwipeViewModel : ObservableProperty
    {
        private List<TWD> _workingDeadItens;
        public List<TWD> WorkingDeadItems
        {
            get => _workingDeadItens;
            set
            {
                _workingDeadItens = value;
                OnPropertyChanged(nameof(WorkingDeadItems));
            }
        }

        public MainSwipeViewModel()
        {
            WorkingDeadItems = new List<TWD>
            {
                new TWD { Image = ImageSource.FromFile("preview1.png") },
                new TWD { Image = ImageSource.FromFile("preview2.png") },
                new TWD { Image = ImageSource.FromFile("preview3.png") },
                new TWD { Image = ImageSource.FromFile("preview4.png") },
                new TWD { Image = ImageSource.FromFile("preview5.png") },
            };
        }
    }
}
