//passaros e beija-flor
namespace INTERFACE
{
    internal class Passaro : IVoador, ISerVivo
    {
        void IVoador.Cair()
        {
            Console.WriteLine("Fechar as asas ");
        }

        void ISerVivo.Comer()
        {
            Console.WriteLine("Abrir o bico e engolir");
        }

        void IVoador.Decolar()
        {
            Console.WriteLine("Abrir as asas e bater");
        }

        void ISerVivo.Dormir()
        {
            Console.WriteLine("Deita no ninho");
        }

        void ISerVivo.Morrer()
        {
            Console.WriteLine("Bateu no vidro");
        }

        void IVoador.Planar()
        {
            Console.WriteLine("Quando estar nas alturas ");
        }

        void IVoador.Pousar()
        {
            Console.WriteLine("Plana no céu até chegar em um local seguro");
        }

        void ISerVivo.Respirar()
        {
            Console.WriteLine(" inspiração e expiração");
        }
    }
}
