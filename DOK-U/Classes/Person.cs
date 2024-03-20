using System;
using System.Text;

namespace DOK_U
{
    public class Person
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public bool IsAdmin { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Group { get; set; }



        public static byte[] StringToByteArray(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }
        
        public static string ByteArrayToString(byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }
        
        public override string ToString()
        {
            return $"{nameof(UserID)}: {UserID}," +
                   $" {nameof(FirstName)}: {FirstName}," +
                   $" {nameof(LastName)}: {LastName}," +
                   $" {nameof(Surname)}: {Surname}," +
                   $" {nameof(Sex)}: {Sex}," +
                   $" {nameof(IsAdmin)}: {IsAdmin}," +
                   $" {nameof(Login)}: {Login}," +
                   $" {nameof(Password)}: {Password}," +
                   $" {nameof(Birthday)}: {Birthday}" +
                   $" {nameof(Group)}: {Group},";
        }

        public Person(int userId, string firstName, string lastName, string surname, string sex, bool isAdmin, string login,
            byte[] password, DateTime birthday, string group)
        {
            UserID = userId;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Sex = sex ?? throw new ArgumentNullException(nameof(sex));
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Birthday = birthday;
            IsAdmin = isAdmin;
            Group = group;
        }
    }
}