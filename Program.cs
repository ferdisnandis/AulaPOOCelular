﻿using System;

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

            Console.WriteLine("Tela está ligada?");
            iphoneXR.ligado = Boolean.Parse(Console.ReadLine());

            iphoneXR.desligado = false;
            Console.WriteLine("Fazer ligação: "+iphoneXR.ligacao());
            Console.WriteLine("Mandar mensagem: "+iphoneXR.mensagem());
        }
    }
}