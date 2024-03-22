using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOK_U.Classes
{
    internal class Schedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int Day { get; set; }
        public int Lecture1Id { get; set; }
        public int Lecture2Id { get; set; }
        public int Lecture3Id { get; set; }
        public int Lecture4Id { get; set; }
        public int Lecture5Id { get; set; }
        public int Lecture6Id { get; set; }

        public Schedule(int id, int groupId,
            int day, int lecture1Id, int lecture2Id,
            int lecture3Id, int lecture4Id, int lecture5Id, int lecture6Id)
        {
            Id = id;
            GroupId = groupId;
            Day = day;
            Lecture1Id = lecture1Id;
            Lecture2Id = lecture2Id;
            Lecture3Id = lecture3Id;
            Lecture4Id = lecture4Id;
            Lecture5Id = lecture5Id;
            Lecture6Id = lecture6Id;
        }

        public Schedule()
        {
        }
    }
}
