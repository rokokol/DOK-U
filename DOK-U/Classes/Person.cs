using System;
using System.Text;

namespace DOK_U
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public bool IsAdmin { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public int GroupId { get; set; }
        public string ReserveCode { get; set; }



        
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}," +
                   $" {nameof(FirstName)}: {FirstName}," +
                   $" {nameof(LastName)}: {LastName}," +
                   $" {nameof(Surname)}: {Surname}," +
                   $" {nameof(Sex)}: {Sex}," +
                   $" {nameof(Login)}: {Login}";
        }

        public Person(int id,
            string firstName,
            string lastName,
            string surname,
            string sex,
            bool isAdmin,
            string login,
            string password,
            DateTime birthday,
            int groupId,
            string reserveCode)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Surname = surname;
            Sex = sex;
            IsAdmin = isAdmin;
            Login = login;
            Password = password;
            Birthday = birthday;
            GroupId = groupId;
            ReserveCode = reserveCode;
        }

        public Person()
        {
        }
    }
}