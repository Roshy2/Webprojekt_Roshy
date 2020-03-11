using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplications_Übung1.Models
{
    public enum Gender
    {
        male, female, notspecified
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Password2 { get; set; }

        public User() : this("", "", Gender.notspecified, null, "", "", "") { }
        public User(string firstname, string lastname, Gender gender,
            DateTime? birthdate, string username, string password, string password2)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.Username = username;
            this.Password = password;
            this.Password2 = password2;
        }

    }
}