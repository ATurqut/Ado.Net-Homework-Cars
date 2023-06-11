using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_Homework_Cars
{
    public class Car
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int StateNumber { get; set; }

        public override string ToString() => $"{Id} - {Marka} - {Model} - {Year} - {StateNumber}";
    }

}
