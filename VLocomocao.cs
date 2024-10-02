//trem e carro
namespace INTERFACE
{
    internal class VLocomocao : IMaquina
    {
        void IMaquina.Abastecer()
        {
            Console.WriteLine("COMBUSTIVEL");
        }

        void IMaquina.Alertar()
        {
            Console.WriteLine("Sonoro e luz");
        }

        void IMaquina.Desligar()
        {
            Console.WriteLine("Chave desliga");
        }

        void IMaquina.Ligar()
        {
            Console.WriteLine("Chave liga");
        }
    }
}
