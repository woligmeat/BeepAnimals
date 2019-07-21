using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beep_Beep_Pet_1
{
    class Program
    {
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private static String[] name_pet = new string[] { "Dog", "Cat", "Cow", "Crocodile", "Hamster" };


        static void Main(string[] args)
        {

            Console.WriteLine("Choose number to hear animal.");

            for (int i = 0; i < name_pet.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + name_pet[i]);
            }

            Console.WriteLine("Enter the number: ");

            int number = 0;
            string numberInput = Console.ReadLine();

            while (!int.TryParse(numberInput, out number))
            {
                Console.Write("Enter the number: ");
                numberInput = Console.ReadLine();
            }

            ChooseNumber(number);
            Console.Write("Press enter to exit...");
            Console.ReadLine();
        }

        private static void ChooseNumber(int number)
        {

            switch (number)
            {
                case 1:
                    {

                        Console.WriteLine("Hau Hau!");
                        player.SoundLocation = "wav/dog.wav";
                        PlaySound(2);
                    }
                    break;
                case 2:
                    {

                        Console.WriteLine("Miau Miau!");
                        player.SoundLocation = "wav/cat.wav";
                        PlaySound(2);
                    }
                    break;
                case 3:
                    {

                        Console.WriteLine("Muuuu!");
                        player.SoundLocation = "wav/cow.wav";
                        PlaySound(2);
                    }
                    break;
                case 4:
                    {

                        Console.WriteLine("Wrrrr!");
                        player.SoundLocation = "wav/crocodile.wav";
                        PlaySound(1);
                    }
                    break;
                case 5:
                    {

                        Console.WriteLine("Grrr!");
                        player.SoundLocation = "wav/hamster.wav";
                        PlaySound(1);
                    }
                    break;


            }


        }

        private static void PlaySound(int c)
        {
            for (int x = 0; x < c; x++)
            {
                player.PlaySync();
                System.Threading.Thread.Sleep(100);
            }

        }
    }
}
