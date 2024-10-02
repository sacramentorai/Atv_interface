namespace INTERFACE
{
    public class DPterodactyl : IVoador,ISerVivo
    {
        void IVoador.Cair(){ Console.WriteLine("Cansado"); }
        void ISerVivo.Comer(){Console.WriteLine("Pequenos animais"); }
        void IVoador.Decolar(){ Console.WriteLine("Abrinco as asas do penhasco");  }
        void ISerVivo.Dormir(){Console.WriteLine("Em arvores");}
        void ISerVivo.Morrer(){Console.WriteLine("Devorado");}
        void IVoador.Planar(){Console.WriteLine("Asas abertas no céu");}
        void IVoador.Pousar(){Console.WriteLine("Fechando as asas e tocando no solo em segurança");  }
        void ISerVivo.Respirar(){ Console.WriteLine("inspiração e expiração");    }
    }
}
