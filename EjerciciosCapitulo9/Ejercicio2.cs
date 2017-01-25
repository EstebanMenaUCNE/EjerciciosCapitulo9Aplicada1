using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCapitulo9
{
    class Ejercicio2
    {
        public struct CuentaBancaria
        {
            public static int numeroIdActual = 1;
            public int cuentaBancariaId;
            public string nombre;
            public float balance;

            public CuentaBancaria(string nombre, float balance)
            {
                cuentaBancariaId = numeroIdActual++;
                this.nombre = nombre;
                this.balance = balance;
            }
        }
    }
}
