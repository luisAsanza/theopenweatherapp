using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContract.Dtos
{
    public class TemperatureDto
    {
        public int Minimal { get; set; }
        public int Maximal { get; set; }
        public int Afternoon { get; set; }
        public int Night { get; set; }
        public int Evening { get; set; }
        public int Morning { get; set; }
    }
}
