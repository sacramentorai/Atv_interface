namespace INTERFACE
{
    public class SHomem : ISerVivo,IVoador
    {
        void IVoador.Cair(){Console.WriteLine("Com frequecia sonora");  }
        void ISerVivo.Comer(){Console.WriteLine("Com a boca"); }
        void IVoador.Decolar() {Console.WriteLine("Punhos serrados para frente");}
        void ISerVivo.Dormir() {Console.WriteLine("Deitando na cama"); }
        void ISerVivo.Morrer() {Console.WriteLine("kriptonita"); }
        void IVoador.Planar(){Console.WriteLine("punho serrados para baixo"); }
        void IVoador.Pousar(){Console.WriteLine("Com as duas pernas"); }
        void ISerVivo.Respirar() {Console.WriteLine("inspiração e expiração"); }
    }
}
