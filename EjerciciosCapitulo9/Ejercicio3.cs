using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCapitulo9
{
    class Ejercicio3
    {
        //Crear estructuras enlazadas para guardar la información de una mascota y su dueño.
        

        public struct Mascota
        {
            public string nombre;
            public string especie;
            public string raza;
            public string color;
        }

        public struct DueñoMascota
        {
            public string nombre;
            public string apellido;
            public Mascota mascota;                        
        }
    }
}
