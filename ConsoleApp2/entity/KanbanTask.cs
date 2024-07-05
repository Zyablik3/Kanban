using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entity
{
    public class KanbanTask
    {
        public int Id {  get; set; }
        public ICollection<KanbanProject>? KanbanProjects { get; set; }

        public string? Name { get; set; }
        public string? Interview { get; set; }
        public string? WriteTZ { get; set; }
        public string? ApproveTZ { get; set; }
        public string? DevelopSoft { get; set; }
        public string? AcceeptSoft { get; set; }
    }
}
