using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Nucleo = true;
            while (Nucleo)
            {
                Console.WriteLine("Bienvenido crea a tu personaje");
                Console.WriteLine("Ingresa un Nombre");
                string nombre = Console.ReadLine();
                int vida;
                while (true)
                {

                    Console.WriteLine("Cuanta vida tendra?(No puede superar 100)");
                    if (int.TryParse(Console.ReadLine(), out vida) && vida >= 0 && vida <= 100)
                        break;
                    Console.WriteLine("Valor incorrecto.Intenta denuevo");
                }
                int ataque;
                while (true)
                {
                    Console.WriteLine("Cuanto de ataque tiene? (No puede superar 100)");
                    if (int.TryParse(Console.ReadLine(), out ataque) && ataque >= 0 && ataque <= 100)
                        break;
                    Console.WriteLine("Valor incorrecto.Intenta denuevo");
                }
                Player player = new Player(nombre, vida, ataque);

                //List<Enemy> enemigos = new List<Enemy>();
                //Console.WriteLine("A cuantos enemigos quieres enfrentar?");
                //int numEnemigos = int.Parse(Console.ReadLine());
                //for (int i= 0; i< numEnemigos; i++)
                //{
                //    Console.WriteLine($"Enemigo numero:{i + 1}");
                //}

                Console.WriteLine("Empieza tu aventura");
                Enemy enemigo = new Enemy(60, 10);
                Console.WriteLine("Te topaste con un enemigo. Comienza el Combate");
                player.Atacar(enemigo);
                if (enemigo.Tasvivo())
                    enemigo.Atacar(player);
                else
                    Console.WriteLine("Has derrotado al enemigo");
                Console.WriteLine("Reanudar tu aventura?(Si/No)");
                string Continue = Console.ReadLine();
                Nucleo = Continue == "Si";




            }
        }
    }
}
