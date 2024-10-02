//helicóptero e avião
using System;

namespace INTERFACE
{
    public class Aereos : IMaquina, IVoador
    {
        void IMaquina.Abastecer(){Console.WriteLine("combustivel"); }
        void IMaquina.Alertar() { Console.WriteLine("Luz e sonoro"); }      
        void IVoador.Cair() { Console.WriteLine("Desligar motores"); }        
        void IVoador.Decolar() { Console.WriteLine("Ligar motores"); }       
        void IMaquina.Desligar() { Console.WriteLine("Botão desligar"); }       
        void IMaquina.Ligar() { Console.WriteLine("Botão ligar"); }        
        void IVoador.Planar() { Console.WriteLine("Caso avião: utilizando suas asas fixas / Caso helicópteros: utilizando autorotação "); }
        void IVoador.Pousar() { Console.WriteLine("Reduzindo velocidade até chegar ao solo"); }
                   
    }
}
