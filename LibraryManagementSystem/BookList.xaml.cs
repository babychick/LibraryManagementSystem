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
    /// Interaction logic for BookList.xaml
    /// </summary>
    public partial class BookList : UserControl
    {
        private ObservableCollection<Books> bookList;

        public BookList()
        {
            InitializeComponent();

            bookList = new ObservableCollection<Books>();

            bookList.Add(new Books() { Id = "B001", Name = "WPF & MVVM", Writer = "Phi Nguyễn", Category = "Programing Language", Quantity = 10, PublicDate = new DateTime(2013, 05, 23) });
            bookList.Add(new Books() { Id = "B002", Name = "C# Foundation", Writer = "Phi Nguyễn", Category = "Programing Language", Quantity = 20, PublicDate = new DateTime(2000, 12, 01) });
            bookList.Add(new Books() { Id = "B003", Name = "UML", Writer = "Phi Nguyễn", Category = "Design % Architecture", Quantity = 5, PublicDate = new DateTime(2013, 05, 23) });
            bookList.Add(new Books() { Id = "B004", Name = "Embedded System", Writer = "Phi Nguyễn", Category = "IoT", Quantity = 2, PublicDate = new DateTime(2017, 01, 23) });
            bookList.Add(new Books() { Id = "B005", Name = "C for Beginner", Writer = "Nguyen Dinh Phi", Category = "Programing Language", Quantity = 10, PublicDate = new DateTime(2013, 05, 23) });

            lvBook.ItemsSource = bookList;
        }

        internal ObservableCollection<Books> GetBookList()
        {
            return bookList;
        }

        internal void SetBookList(ObservableCollection<Books> value)
        {
            bookList = value;
        }
    }
}
