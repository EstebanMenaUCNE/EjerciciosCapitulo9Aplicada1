using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosCapitulo9
{
    public class Ejercicio1
    {
        //Crear una estructura para guardar los productos de una tienda

        public struct Producto
        {
            public static int numeroIdActual = 1;
            public int productoId;
            public string descripcion;
            public float precio;
            public int cantidadExistencia;
            
            public Producto(string descripcion, float precio, int cantidadExistencia)
            {
                productoId = numeroIdActual++;
                this.descripcion = descripcion;
                this.precio = precio;
                this.cantidadExistencia = cantidadExistencia;
            }
        }
    }
}
