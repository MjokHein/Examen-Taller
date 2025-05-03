using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Enemy
    {
        public int Vida;
        public int Ataque;
        public Enemy(int vida, int ataque)
        {
            Vida = vida;
            Ataque = ataque;
        }
        public int DamageCalc()
        {
            return Ataque;
        }
        public void RecibeDmg(int damage)
        {
            Vida -= damage;
            if (Vida <0) Vida = 0;
            Console.WriteLine($"El enemigo a recibido {damage} puntos de damage. Le quedan {Vida} puntos de vida");
        }
        public bool Tasvivo()
        {
            return Vida> 0;
        }
        public void Atacar(Player player)
        {
            int ataque = DamageCalc();
            player.RecibeDamage(ataque);
            Console.WriteLine($"El enemigo te a causado {ataque} puntos de damage");

        }
    }
}
