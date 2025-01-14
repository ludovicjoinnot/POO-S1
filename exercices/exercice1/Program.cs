using System;

namespace ExerciceChienChat
{
    // Définition de la classe Chien
    public class Chien
    {
        public void Aboyer()
        {
            Console.WriteLine("Woof!");
        }
    }

    // Définition de la classe Chat
    public class Chat
    {
        public void Miauler()
        {
            Console.WriteLine("Meow!");
        }
    }

    // Classe principale
    class Program
    {
        static void Main(string[] args)
        {
            // Création des objets Chien et Chat
            Chien chien = new Chien();
            Chat chat = new Chat();

            // Appel des méthodes
            chien.Aboyer();
            chat.Miauler();
        }
    }
}

