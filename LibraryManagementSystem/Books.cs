using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Books
    {
        private string id;
        private string name;
        private string writer;
        private string category;
        private int quantity;
        private DateTime publicDate;
        private string shortDate;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Writer { get => writer; set => writer = value; }
        public string Category { get => category; set => category = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime PublicDate { get => publicDate; set => publicDate = value; }
        public string ShortDate { get => publicDate.ToShortDateString(); set => shortDate = value; }
    }
}
