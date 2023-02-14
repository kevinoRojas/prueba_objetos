using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prueba_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            humano humano1 = new humano();

            humano1.name = "Pedrinho";
            humano1.edad = 45;
            humano1.altura = 1.78;
            humano1.peso = 78.6;


            humano1.presentarse();
            humano1.edadPrima();
            humano1.multiplicacion();
            humano1.IMC();
            humano1.trabajo();


            humano humano2 = new humano();

            humano2.name = "Francisco";
            humano2.edad = 18;
            humano2.altura = 1.72;
            humano2.peso = 80;


            humano2.presentarse();
            humano2.edadPrima();
            humano2.multiplicacion();
            humano2.IMC();
            humano2.trabajo();

            humano humano3 = new humano();

            humano3.name = "Carlo";
            humano3.edad = 22;
            humano3.altura = 1.99;
            humano3.peso = 90;


            humano3.presentarse();
            humano3.edadPrima();
            humano3.multiplicacion();
            humano3.IMC();
            humano3.trabajo();


            Animal cocodrilo = new Animal("Cocodrilo", 89, 4);
            cocodrilo.presentarse();

            Mascota Foca = new Mascota("M.R Foca", 24, 0, false, "Piscina");
            Foca.presentarse();
            Foca.informacion(5,"Vendedor de alfombras");
            Foca.informacion(0, 2);

            Salvaje GarraPata = new Salvaje("Garra Patin,", 37, 8, true, "Maleza");
            GarraPata.presentarse();
            GarraPata.informacion(7, "Subsidios del gobierno");
            GarraPata.informacion(0, 0);

            Console.ReadLine();



        }

        public class Mascota : Animal
        {
            public bool domestico = true;
            public string habitad = "hogar";

            public Mascota(string name, int edad, int cantidadPatas, bool domestico, string habitad) : base(name, edad, cantidadPatas)
            {
                this.domestico = domestico;
                this.habitad = habitad;
            }

            public void informacion(int comidas, string dedication)
            {
                Console.WriteLine("\n" + "Me alimento " + comidas + " al dia y me dedico a " + dedication );
            }

            public void informacion(int dedos, int aletas)
            {
                Console.WriteLine("\n" + "Tengo " + dedos + " dedos y " + aletas + " aletas");
            }

        }
        public class Salvaje : Animal
        {
            public bool nomada = true;
            public string habitad = "";

            public Salvaje(string name, int edad, int cantidadPatas, bool nomada, string habitad) : base(name, edad, cantidadPatas)
            {
                this.nomada = nomada;
                this.habitad = habitad;
            }

            public void informacion(int comidas, string dedication)
            {
                Console.WriteLine("\n" + "Me alimento " + comidas + " al dia y me dedico a " + dedication);
            }

            public void informacion(int dedos, int aletas)
            {
                Console.WriteLine("\n"+"Tengo " + dedos +  " dedos y " + aletas + " aletas");
            }

        }

    }
}

