﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP.Model
{
    public class Carro: Vehiculo
    {
        public string modelo = "Aventador";

        // Polimorfismo
        public override void encender()
        {
            Console.WriteLine("Encender desde carro");
        }

        public override void apagar()
        {
            Console.WriteLine("Apagar desde carro");
        }
    }

    
}
