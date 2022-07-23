using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEntityNET5_Learning.Models
{
    public class Sequence
    {
        public int Id { get; set; }
        public int ProtocolId { get; set; }
        public Protocol Protocol { get; set; }
    }
}
