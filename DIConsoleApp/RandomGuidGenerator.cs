using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsoleApp
{
    public class RandomGuidGenerator
    {
        public Guid Generate { get; set; }= Guid.NewGuid();
    }
}
