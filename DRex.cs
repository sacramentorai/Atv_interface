namespace INTERFACE
{
    public class DRex : ISerVivo
    {
        void ISerVivo.Comer(){Console.WriteLine("Come outros dinossauros menores");}
        void ISerVivo.Dormir(){Console.WriteLine("De barriga no chão");}
        void ISerVivo.Morrer(){Console.WriteLine("Doente ou velhice");}
        void ISerVivo.Respirar(){Console.WriteLine("inspiração e expiração");}
    }
}
