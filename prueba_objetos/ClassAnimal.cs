using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_objetos
{
    public class Animal
    {
        public string name;
        public int edad;
        public int CantidadPatas;

        public Animal(string name, int edad, int cantidadPatas)
        {
            this.name = name;
            this.edad = edad;
            CantidadPatas = cantidadPatas;

        }

        public void presentarse()
        {
            Console.Write( "\n" + "\n" + "Hola soy un " + name);
        }
    }
}
