using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourPlanner_Client.Commands;
using TourPlanner_Client.Models;
using TourPlanner_Client.ViewModels;

namespace TourPlanner_Client.ViewModels
{
    public class AddTourViewModel : ViewModelBase
    {
        private ObservableCollection<Tour> tours;
        public ObservableCollection<Tour> Tours
        {
            get { return tours; }
            set
            {
                tours = value;
                OnPropertyChanged(nameof(Tours));
            }
        }

        private string newTourName;
        public string NewTourName
        {
            get { return newTourName; }
            set
            {
                newTourName = value;
                OnPropertyChanged(nameof(NewTourName));
            }
        }

        public ICommand AddTourCommand { get; }


       
            private _TransportType _selectedTransportType;
            public _TransportType SelectedTransportType
            {
                get { return _selectedTransportType; }
                set
                {
                    _selectedTransportType = value;
                    OnPropertyChanged(nameof(SelectedTransportType));
                }
            }

            public IEnumerable<_TransportType> TransportTypes => Enum.GetValues(typeof(_TransportType)).Cast<_TransportType>();

    }

}
