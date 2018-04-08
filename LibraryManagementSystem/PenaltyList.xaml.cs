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

namespace LibraryManagementSystem
{
    /// <summary>
    /// Interaction logic for PenaltyList.xaml
    /// </summary>
    public partial class PenaltyList : UserControl
    {
        private  ObservableCollection<Penalty> penList;

        public PenaltyList()
        {
            InitializeComponent();

            penList = new ObservableCollection<Penalty>();
            penList.Add(new Penalty() { Id = "A001", Name = "Dinh Phi", Job = "Student",Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });
            penList.Add(new Penalty() { Id = "A002", Name = "Dinh Phi", Job = "Student", Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });
            penList.Add(new Penalty() { Id = "A003", Name = "Dinh Phi", Job = "Student", Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });
            penList.Add(new Penalty() { Id = "A004", Name = "Dinh Phi", Job = "Student", Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });
            penList.Add(new Penalty() { Id = "A005", Name = "Dinh Phi", Job = "Student", Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });
            penList.Add(new Penalty() { Id = "A006", Name = "Dinh Phi", Job = "Student", Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });
            penList.Add(new Penalty() { Id = "A007", Name = "Dinh Phi", Job = "Student", Reason = "Late return", From = new DateTime(2018, 4, 8), To = new DateTime(2018, 4, 10), Remain = 2 });

            lvPenalty.ItemsSource = penList;
        }

        internal ObservableCollection<Penalty> PenList { get => penList; set => penList = value; }
    }
}
