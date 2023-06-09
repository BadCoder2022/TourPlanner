using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TourPlanner_Client.Models;
using TourPlanner_Client.ViewModels;

namespace TourPlanner_Client.Views
{
    /// <summary>
    /// Interaction logic for AddTourView.xaml
    /// </summary>
    public partial class AddTourView : UserControl
    {
        public AddTourView()
        {
            InitializeComponent();
            DataContext = new AddTourViewModel();
            // TTypes.DataSource = Enum.GetNames(typeof(_TransportType)).ToString();
        }

        
    }
}
