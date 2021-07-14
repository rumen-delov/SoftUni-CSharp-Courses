using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Allowed memory/time: 16MB/100ms

            // The integer N will be in the range [1...2000000000].
            uint pokePower = uint.Parse(Console.ReadLine());
            uint originalPokePower = pokePower;

            // The integer M will be in the range[1...1000000]
            uint targetsDistance = uint.Parse(Console.ReadLine()); 

            // The integer Y will be in the range [0...9]
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            ushort targetsCount = 0;

            while (pokePower >= targetsDistance)
            {
                pokePower -= targetsDistance;

                if ((pokePower == originalPokePower / 2) && (exhaustionFactor != 0))
                {
                    pokePower /= exhaustionFactor;                    
                }

                targetsCount++;
            }
            
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsCount);
        }
    } 
}
