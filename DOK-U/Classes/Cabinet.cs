using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOK_U.Classes
{
    internal class Cabinet
    {
        public int Id { get; set; }
        public string CabinetNumber { get; set; }

        public Cabinet(int id, string cabinetNumber)
        {
            Id = id;
            CabinetNumber = cabinetNumber;
        }

        public Cabinet()
        {
        }
    }
}
