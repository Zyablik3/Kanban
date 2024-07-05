using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entity
{
    public class Zakazchik
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? LastName { get; set; }
        public int INN { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }

    }
}
