//Gato e cachorro
using System.IO;

namespace INTERFACE
{
    public class QuatroPatas : ISerVivo
    {
        void ISerVivo.Comer()
        {
            Console.WriteLine("Come ração");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("na manta");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Velhice");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine(" inspiração e expiração");
        }
    }
}
