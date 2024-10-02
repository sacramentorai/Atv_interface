namespace INTERFACE
{
    public class DiscoVoador : IMaquina, IVoador
    {
        void IMaquina.Abastecer(){Console.WriteLine("conbustivel extraterrestre");}
        void IMaquina.Alertar(){Console.WriteLine("Luz e sonoro");}
        void IVoador.Cair(){ Console.WriteLine("Pani no sitema");  }
        void IVoador.Decolar(){Console.WriteLine("Inpulso para fente e depois para cima ");}
        void IMaquina.Desligar(){Console.WriteLine("Botão desligar");}
        void IMaquina.Ligar(){Console.WriteLine("Botão ligar"); }
        void IVoador.Planar(){Console.WriteLine("Comando de flutuar"); }
        void IVoador.Pousar(){Console.WriteLine("Perdendo velocidade até chegar ao solo");}
    }
}
