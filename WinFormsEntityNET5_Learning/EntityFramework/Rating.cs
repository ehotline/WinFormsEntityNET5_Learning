using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEntityNET5_Learning.EntityFramework
{
    public class Rating
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string Source { get; set; }
        public int Stars { get; set; }
    }
}
