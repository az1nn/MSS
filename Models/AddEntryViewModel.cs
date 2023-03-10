using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSS.Models.Domain;

namespace MSS.Models
{
    public class AddEntryViewModel
    {
        public Guid ProductId { get; set; }

        public Guid SelectedProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; }
        
        public string Local { get; set; }
    }
}