using System;


namespace lab3
{
    public class Program
    {
        static void Main()
        {
            {
                int keySize = 16; // 16-bit key size

                ElGamal elGamal = new ElGamal(keySize);

                uint p = elGamal.GenerateRandomPrime(keySize);
                uint g = elGamal.GenerateRandomNumber(2, p - 2);
                uint a = elGamal.GenerateRandomNumber(1, p - 1);
                uint A = elGamal.ModuloPower(g, a, p);
                // Generate random prime number (p)
                //var p = GenerateRandomPrime(keySize);

                // Generate random number (g) between 2 and p-2
                //var g = GenerateRandomNumber(2, p - 2);

                // Generate private key (a) between 1 and p-1
                //var a = GenerateRandomNumber(1, p - 1);

                // Calculate public key (A)
                //var A = ModuloPower(g, a, p);

                Console.WriteLine("Generated Parameters:");
                Console.WriteLine("p (Prime Number): " + p);
                Console.WriteLine("g (Random Number): " + g);
                Console.WriteLine("a (Private Key): " + a);
                Console.WriteLine("A (Public Key): " + A);

                Console.ReadLine();
            }

            
        }
    }
}