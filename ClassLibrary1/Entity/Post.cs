using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public class Post : Entity
    {
        public string NamePost { get; set; } = null!;
        public double Salary { get; set; }
        public string Powers { get; set; } = null!;

        public ICollection<Nurse> Nurses { get; set; } = new List<Nurse>();

        public void Add(string NamePost, double Salary, string Powers)
        {
            this.NamePost = NamePost;
            this.Salary = Salary;
            this.Powers = Powers;
        }

        //public void Update(Nurse Nurse)
        //{
        //    Nurses.Add(Nurse);
        //}

    }
}
