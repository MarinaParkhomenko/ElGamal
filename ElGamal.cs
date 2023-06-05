using System;
using System.Security.Cryptography;

namespace lab3
{
    public class ElGamal
    {
        private int KeySize;

        public ElGamal(int keySize)
        {
            KeySize = keySize;
        }


        public uint GenerateRandomPrime(int bits)
        {
            var rng = new RNGCryptoServiceProvider();
            var bytes = new byte[bits / 4];
            int prime;
            do
            {
                rng.GetBytes(bytes);
                
                prime = BitConverter.ToInt32(bytes, 0);
            } while (!IsPrime(prime));

            return (uint)prime;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public uint GenerateRandomNumber(uint min, uint max)
        {
            var rng = new RNGCryptoServiceProvider();
            var bytes = new byte[4];
            rng.GetBytes(bytes);
            int randomNumber = BitConverter.ToInt32(bytes, 0);

            return (uint)((randomNumber % (max - min + 1)) + min);
        }

        public uint ModuloPower(uint number, uint power, uint modulus)
        {
            if (power == 0)
                return 1;

            uint result = 1;

            while (power > 0)
            {
                if (power % 2 == 1)
                    result = (result * number) % modulus;

                number = (number * number) % modulus;
                power >>= 1;
            }

            return (uint)result;
        }
    }
}
