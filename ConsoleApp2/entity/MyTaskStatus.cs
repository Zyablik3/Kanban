using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entity
{
    public class MyTaskStatus
    {
        public int Id { get; set; }
        public string? Queue { get; set; }
        public string? Analysis { get; set; }
        public string? Development { get; set; }
        public string? Accept {  get; set; }
        public string? Drop {  get; set; }


    }
}
