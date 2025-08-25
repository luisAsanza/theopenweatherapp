using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceContract.Dtos
{
    public class TemperatureDto
    {
        public double Minimal { get; set; }
        public double Maximal { get; set; }
        public double Afternoon { get; set; }
        public double Night { get; set; }
        public double Evening { get; set; }
        public double Morning { get; set; }
    }
}
