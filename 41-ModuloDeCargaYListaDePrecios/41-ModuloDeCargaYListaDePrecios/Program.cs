using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _41_ModuloDeCargaYListaDePrecios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Modulode Carga y Listado de articulo");

           

            Console.WriteLine("Cargue el tipo de dispositivo que desea consultar de la siguiente lista:");
            Console.WriteLine("Mother"+Environment.NewLine+"Micro"+Environment.NewLine + "Memoria"+Environment.NewLine + "Placa"+Environment.NewLine+ "Fuente");

            string tipo = Convert.ToString(Console.ReadLine());

            /*La creacion de diversos objetos NO ESTA MAL, pero se podria haber EVITADO con un bucle FOR en el cual
             * se le pida al usuario que cargue el mismo los datos del listado y luego se muestren por pantalla mediante el FOREACH*/

            Carga Mother1 = new Carga();
            Mother1.tipo = "mother";
            Mother1.Marca = "Asus";
            Mother1.Modelo = "PRIME H110M-P 1151 HDMI M.2";
            Mother1.NumeroDeSerie = 11076;
            Mother1.NumeroDeSerie = 12000;

            Carga Mother2 = new Carga();
            Mother2.tipo = "mother";
            Mother2.Marca = "Asrock";
            Mother2.Modelo = "Z390 Phantom Gaming 9";
            Mother2.NumeroDeSerie = 81639;
            Mother2.Precio = 13000;

            Carga Micro1 = new Carga();
            Micro1.tipo = "microprocesador";
            Micro1.Marca = "Intel";
            Micro1.Modelo = "i7-9700K";
            Micro1.NumeroDeSerie = 321098;
            Micro1.Precio = 15000;

            Carga Micro2 = new Carga();
            Micro2.tipo = "microprocesador";
            Micro2.Marca = "AMD";
            Micro2.Modelo = "AMD Ryzen 7";
            Micro2.NumeroDeSerie = 81248;
            Micro2.Precio = 16000;

            Carga Memoria1 = new Carga();
            Memoria1.tipo = "memorias";
            Memoria1.Marca = "Kingston";
            Memoria1.Modelo = "HyperX";
            Memoria1.NumeroDeSerie = 823461;
            Memoria1.Precio = 5000;

            Carga Memoria2 = new Carga();
            Memoria2.tipo = "memoria";
            Memoria2.Marca = " HyperX Fury";
            Memoria2.Modelo = "AccesPrime";
            Memoria2.NumeroDeSerie = 8137;
            Memoria2.Precio = 4500;

            Carga Placa1 = new Carga();
            Placa1.tipo = "placa";
            Placa1.Marca = "Nvidia";
            Placa1.Modelo = "BlackDragonX";
            Placa1.NumeroDeSerie = 81496;
            Placa1.Precio = 9700;

            Carga Placa2 = new Carga();
            Placa2.tipo = "placa";
            Placa2.Marca = "Saphire";
            Placa2.Modelo = "CelestialWarrior";
            Placa2.NumeroDeSerie = 64564;
            Placa2.Precio = 10000;

            Carga Fuente1 = new Carga();
            Fuente1.tipo = "fuente";
            Fuente1.Marca = "Sentei";
            Fuente1.Modelo = "ThunderBird";
            Fuente1.NumeroDeSerie = 53453;
            Fuente1.Precio = 1500;

            Carga Fuente2 = new Carga();
            Fuente2.tipo = "fuente";
            Fuente2.Marca = "NewFrontera";
            Fuente2.Modelo = "ThunderForce";
            Fuente2.NumeroDeSerie = 234623;
            Fuente2.Precio = 1800;


            List<Carga> Catalogo = new List<Carga>(); /*Aqui cargamos todos los objetos con sus correspondientes propiedades*/
            Catalogo.Add(Mother1);
            Catalogo.Add(Mother2);
            Catalogo.Add(Micro1);
            Catalogo.Add(Micro2);
            Catalogo.Add(Memoria1);
            Catalogo.Add(Memoria2);
            Catalogo.Add(Fuente1);
            Catalogo.Add(Fuente2);
            Catalogo.Add(Placa1);
            Catalogo.Add(Placa2);

            
                foreach (Carga Producto in Catalogo) /* El bucle se encargara  del recorrido invocando cada elemento de la lista creada anteriormente*/
                {
                    if ( Producto.tipo== tipo) /*Aqui estamos aclarandole al blucle FOREACH que debe mostrar invocando el objeto PRODUCTO de tipo CARGA
                                                 y diciendole que se enfoque en la propiedad TIPO para realizar la comparacion con lo solicitado por el usuario*/
                {
                    Console.WriteLine("Marca: " + Producto.Marca);
                    Console.WriteLine("Modelo: " + Producto.Modelo);
                    Console.WriteLine("Numero de Serie: " + Producto.NumeroDeSerie);
                    Console.WriteLine("Precio: " + Producto.Precio);
                }

                }

            
             
            

            
            Console.ReadKey();
        }
    }
}
