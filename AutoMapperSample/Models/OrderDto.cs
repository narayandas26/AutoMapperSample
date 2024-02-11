using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperSample.Models
{
    internal class OrderDto
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public Color ItemColor { get; set; }
    }
}
