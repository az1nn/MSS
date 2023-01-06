using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSS.Models.Domain
{
    public class Entry
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }
        
        public string Local { get; set; }

    }
}