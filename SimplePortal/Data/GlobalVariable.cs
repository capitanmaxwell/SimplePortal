using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePortal.Data
{
    public class GlobalVariable
    {
        public List<Games> ItemGame { get; set; } = new List<Games>();
        public bool authorization { get; set; } = false;           
    }
}
