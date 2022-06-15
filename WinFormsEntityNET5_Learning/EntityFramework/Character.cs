using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEntityNET5_Learning.EntityFramework
{
    public class Character
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string Name { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
    }
}
