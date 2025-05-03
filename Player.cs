using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Player
    {
        public string Nombre;
        public int Vida;
        public int Ataque;

        public Player(string nombre, int vida, int ataque)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
        }
        public void RecibeDamage(int damage)
        {
            Vida -= damage;
            if (Vida < 0) Vida = 0;
            Console.WriteLine($"Haz recibido {damage} de damage te quedan {Vida} puntos de vida");
        }
        public int DamageCalc()
        {
            return Ataque;
        }
        public void Atacar(Enemy enemy)
        {
            int damage = DamageCalc();
            enemy.RecibeDmg(damage);
            Console.WriteLine($"Le haz causado {damage} puntos de damage al enemigo");
        }
    }
}
