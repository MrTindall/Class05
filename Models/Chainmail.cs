﻿using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    internal class Chainmail : IArmor

    {
        public string Name {get ; set;}
        public int Defense { get; set; }

        public Chainmail(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }
    }

}
