using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOK_U.Classes
{
    internal class Group
    {
        public int Id { get; set; }
        public string GroupNumber { get; set; }

        public Group(int id, string groupNumber)
        {
            Id = id;
            GroupNumber = groupNumber;
        }

        public Group()
        {
        }
    }
}
