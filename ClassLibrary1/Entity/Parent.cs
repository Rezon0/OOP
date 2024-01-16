using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class Parent : Entity
    {
        public string Lastname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Patronymic { get; set; }
        public char Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public string Phone { get; set; } = null!;

        public void Add(string Lastname, string Name, string Patronymic, char Gender, DateOnly Birthday, string Phone)
        {
            this.Lastname = Lastname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Gender = Gender;
            this.Birthday = Birthday;
            this.Phone = Phone;
        }

        // public Student_Parent? Student_Parents { get; set; }

        public List<StudentAndParent> Students_Parents { get; } = new List<StudentAndParent>();
        public List<Student> Students { get; } = new List<Student>();
    }
}
