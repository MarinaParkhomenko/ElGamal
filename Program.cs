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
                Console.WriteLine("p (Prime Number): " + p);
                Console.WriteLine("g (Random Number): " + g);
                Console.WriteLine("a (Private Key): " + a);
                Console.WriteLine("A (Public Key): " + A);
            }
        }
    }
}