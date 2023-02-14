using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_objetos
{
    class humano
    {
        public string name;
        public int edad;
        public double altura;
        public double peso;

        //Metodos

        /// <summary>
        /// Publico
        /// Presenta los datos de los atributos en el objeto
        /// </summary>
        public void presentarse()
        {
            Console.Write("Hola me llamo " + name + '\n'
                                + "Tengo " + edad + " anios" + '\n'
                                + "Mido " + altura + "cm" + '\n'
                                + "Peso " + peso);
        }


        /// <summary>
        /// Publico
        /// Funcion que escribe si la edad es un numeor primo
        /// </summary>
        /// 
        public void edadPrima()
        {
            if (edad % 2 == 0)
            {
                Console.WriteLine("Mi edad es un numero primo");
            }
            else
            {
                Console.WriteLine("Mi edad NO es un numero primo");
            }
        }

        /// <summary>
        /// Se muestra una multiplicacion de la edad y la altura del humano
        /// </summary>
        public void multiplicacion()
        {
            Console.WriteLine("Mi edad multiplicada por mi altura es " + edad * altura);

        }

        /// <summary>
        /// Se calcula y muestra el IMC de humano
        /// </summary>
        public void IMC()
        {
            Console.WriteLine("Mi IMC es " + peso / altura);

        }

        public void trabajo()
        {
            if (name.Length > 5 && edad > 18)
            {
                Console.WriteLine("Mi trabajo es ser futbolista ");

            }
            else if (name.Length <= 5 && edad > 18)
            {
                Console.WriteLine("Mi trabajo es bailar ");

            }
            else if (edad <= 18)
            {
                Console.WriteLine("Estoy terminando de estudiar / Buscando trabajo");

            }
            else
            {
                Console.WriteLine("Estoy desempleado");

            }
        }

    }

}
