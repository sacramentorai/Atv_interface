namespace INTERFACE
{
    public class Fantasma : IPairador
    {
        void IVoador.Cair() {   Console.WriteLine("Sugado por maquina");  }

        void IVoador.Decolar() { Console.WriteLine("Falano boooh!"); }
       
        void IPairador.Pairar() { Console.WriteLine("No ar"); }
        
        void IVoador.Planar() { Console.WriteLine("zig e zag no ar"); }
       
        void IVoador.Pousar() { Console.WriteLine("ficando transparente até sumir"); }
        
    }
}
