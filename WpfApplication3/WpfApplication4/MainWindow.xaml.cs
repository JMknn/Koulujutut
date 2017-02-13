using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using JAMK.ICT;


namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //stuff gunna happen
        JAMK.ICT.HockeyLeague liiga = new JAMK.ICT.HockeyLeague();
        ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            mystuff();
        }
        private void mystuff()
        {
            List<string> muuvit = new List<string>();
            muuvit.Add("Japen seikkailut 1");
            muuvit.Add("Japen seikkailut 2");
            muuvit.Add("Japen seikkailut 3");
            muuvit.Add("Japen seikkailut 4");
            cmbMovies.ItemsSource = muuvit;
            //JAMK.ICT.HockeyLeague liiga = new JAMK.ICT.HockeyLeague();
            //
            //ObservableCollection<JAMK.ICT.HockeyTeam> joukkueet;
             joukkueet = liiga.GetTeams();
            cmbTeams.ItemsSource = joukkueet;


        }
        
        

        
private void btnBind_Click(object sender, RoutedEventArgs e)
        {
            //HockeyTeam tiimi = new JAMK.ICT.HockeyTeam("Keupa", "Keuruu");
            //right.DataContext = tiimi;
            right.DataContext = joukkueet[counter];

        }
    }

    }
