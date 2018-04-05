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
    /// Interaction logic for MemberList.xaml
    /// </summary>
    public partial class MemberList : UserControl
    {
        private ObservableCollection<Members> memberList;

        public MemberList()
        {
            InitializeComponent();

            memberList = new ObservableCollection<Members>();
            memberList.Add(new Members() { Id = "A001", Name = "Dinh Phi", Address = "Can Tho", Gender = true, Age = 22, Job = "Student", Email = "phi@student.vn", Ispenalty = true });
            memberList.Add(new Members() { Id = "A002", Name = "Dinh Long", Address = "An Giang", Gender = true, Age = 15, Job = "Student", Email = "long@gmail.vn", Ispenalty = false });
            memberList.Add(new Members() { Id = "A003", Name = "Yen Nhi", Address = "Kien Giang", Gender = false, Age = 18, Job = "Student", Email = "nhi@gmail.vn", Ispenalty = false });
            memberList.Add(new Members() { Id = "A004", Name = "Thanh Vi", Address = "Bac Lieu", Gender = false, Age = 24, Job = "Other", Email = "vi@gmail.vn", Ispenalty = false });
            memberList.Add(new Members() { Id = "A005", Name = "Dinh Hung", Address = "Ca Mau", Gender = true, Age = 10, Job = "Student", Email = "hung@student.vn", Ispenalty = true });
            memberList.Add(new Members() { Id = "A006", Name = "Dinh Chi", Address = "Ho Chi Minh", Gender = true, Age = 11, Job = "Student", Email = "chi@student.vn", Ispenalty = false });

            lvMember.ItemsSource = memberList;
        }

        public ObservableCollection<Members> GetMemberList()
        {
            return memberList;
        }

        public void SetMemberList(ObservableCollection<Members> value)
        {
            memberList = value;
        }
    }
}
