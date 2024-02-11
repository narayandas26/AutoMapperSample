using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample.Models
{
    internal class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public OrderDto Order { get; set; }
    }
}
