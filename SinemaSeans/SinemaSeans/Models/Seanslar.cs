using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans.Models
{
    internal class Seanslar
    {
        public int id {  get; set; }
        public Filmler film {  get; set; }
        public int koltuk { get; set; }
    }
}
