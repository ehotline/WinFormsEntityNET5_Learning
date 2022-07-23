using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEntityNET5_Learning.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Protocol> Protocols { get; set; }
    }
}
