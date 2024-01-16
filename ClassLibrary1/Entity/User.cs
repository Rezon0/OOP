using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entity
{
    public abstract class User : Entity
    {
        public string Lastname { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Patronymic { get; set; }
        public char Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Privilege { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
