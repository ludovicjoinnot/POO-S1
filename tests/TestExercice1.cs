
using System;
using System.IO;
using Xunit;
using ExerciceChienChat;  // Assurez-vous que l'espace de noms est correct

namespace Tests
{
    public class TestExercice1
    {
        [Fact]
        public void TestChienAboyer()
        {
            // Capturer la sortie console
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Créer un objet Chien et appeler la méthode Aboyer
            Chien chien = new Chien();
            chien.Aboyer();

            // Vérifier que la sortie est "Woof!"
            var output = stringWriter.ToString().Trim();
            Assert.Equal("Woof!", output);
        }

        [Fact]
        public void TestChatMiauler()
        {
            // Capturer la sortie console
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Créer un objet Chat et appeler la méthode Miauler
            Chat chat = new Chat();
            chat.Miauler();

            // Vérifier que la sortie est "Meow!"
            var output = stringWriter.ToString().Trim();
            Assert.Equal("Meow!", output);
        }
    }
}
