using System;

namespace Aula_POO_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular iphoneXR = new Celular();
            iphoneXR.cor = "Branco";
            iphoneXR.modelo = "Iphone X";
            iphoneXR.tamanho = 5;
            iphoneXR.desligado = false;

            Console.WriteLine("Tela está ligada?");
            iphoneXR.ligado = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Usar Mensagem?");
            iphoneXR.mensagem = Boolean.Parse(Console.ReadLine());
            if(iphoneXR.mensagem){
                Console.WriteLine("Mensagem enviada");
            }
            
            Console.WriteLine("Fazer ligação?");
            iphoneXR.ligacao = Boolean.Parse(Console.ReadLine());
            if(iphoneXR.ligacao){
                Console.WriteLine("Ligação feita");
            }
        }
    }
}
