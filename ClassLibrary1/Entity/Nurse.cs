using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class Nurse : User
    {
        public Post? Postes { get; set; }

        public void Add(string Lastname, string Name, string Patronymic,
                        char Gender, DateOnly Birthday, string Phone, string Email,
                        string Login, string Password, Post Postes, string Privilege)
        {
            this.Lastname = Lastname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.Phone = Phone;
            this.Email = Email;
            this.Login = Login;
            this.Password = Password;
            this.Postes = Postes;
            this.Privilege = Privilege;
        }
    }
}
