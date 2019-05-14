using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_catch_rate_calculator.Model
{
    public class Pokemon
    {
        public string pkmnName { get; set; }
        public int catchRate { get; set; }
        public int baseHealth { get; set; }
    }

    public class Ball
    {
        public string ballName { get; set; }
        public double catchBonus { get; set; }
    }
}
