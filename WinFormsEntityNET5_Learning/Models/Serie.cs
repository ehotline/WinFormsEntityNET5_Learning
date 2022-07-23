using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEntityNET5_Learning.Models
{
    public class Serie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan? Time { get; set; }
        public int StudyId { get; set; }
        public Study Study { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public List<Sequence> Sequences { get; set; }
    }
}
