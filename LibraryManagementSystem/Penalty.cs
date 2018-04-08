using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class Penalty
    {
        private string id;
        private string name;
        private string job;
        private string reason;
        private DateTime from;
        private string shortFrom;
        private DateTime to;
        private string shortTo;
        private int remain;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
        public DateTime From { get => from; set => from = value; }
        public DateTime To { get => to; set => to = value; }
        public int Remain { get => remain; set => remain = value; }
        public string Reason { get => reason; set => reason = value; }
        public string ShortFrom { get => from.ToShortDateString(); set => shortFrom = value; }
        public string ShortTo { get => to.ToShortDateString(); set => shortTo = value; }
    }
}
