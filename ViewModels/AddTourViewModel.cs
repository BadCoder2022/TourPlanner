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

        // Other properties for capturing the new tour details

        public ICommand AddTourCommand { get; }

        /*
        public AddTourViewModel(ObservableCollection<Tour> existingTours)
        {
            Tours = existingTours;

            // Other initialization code...

            AddTourCommand = new AddTourCommand(AddTour);
        }

        public AddTourViewModel()
        {
            AddTourCommand = new AddTourCommand();
        }

            private void AddTour()
        {
            // Logic to add a new tour to the collection
            Tours.Add(new Tour("NewTour", "NewDescription", "NeuerOrt", "NeuesZiel", 3));

            //// Clear the input fields or reset the properties
            //NewTourName = string.Empty;
            //NewTourDescription = string.Empty;
            //NewTourSource = string.Empty;
            //NewTourDestination = string.Empty;
            //NewTourType = 0;
        }
        */

        // Rest of the class implementation
    }

}
