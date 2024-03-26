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
