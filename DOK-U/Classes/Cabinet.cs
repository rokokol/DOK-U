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
