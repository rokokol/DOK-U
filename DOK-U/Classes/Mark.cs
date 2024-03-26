namespace DOK_U.Classes
{
    internal class Mark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LectureId { get; set; }
        public int TermNumber { get; set; }
        public string Value { get; set; }

        public Mark(int id, int studentId, int lectureId, int termNumber, string value)
        {
            Id = id;
            StudentId = studentId;
            LectureId = lectureId;
            TermNumber = termNumber;
            Value = value;
        }

        public Mark()
        {
        }
    }
}
