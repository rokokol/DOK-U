using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOK_U.Classes
{
    internal class Lecture
    {
        public int Id { get; set; }
        public int CabinetId { get; set; }
        public string Value { get; set; }

        public Lecture(int id, int cabinetId, string value)
        {
            Id = id;
            CabinetId = cabinetId;
            Value = value;
        }

        public Lecture()
        {
        }
    }
}
