﻿using System;
using System.Threading;

namespace Cronometro
{

    class Program 
    {

        static void Main(string[]args)
        {

            //Start(6);
            Menu();
        }
static void Menu()
{
    Console.Clear();
    Console.WriteLine($"S = Segundo => 10 s = 10 segundos");
    Console.WriteLine($"M = Minuto => 1m = 1 minuto");
    Console.WriteLine($"0 = Sair");
    Console.Write($"Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length -1 ,1 ));
    int time = int.Parse(data.Substring(0, data.Length -1 ));
    int multiplier = 1;

        if(type == 'm')
        {
            multiplier = 60 ;
        }
        if(time == 0){
            System.Environment.Exit(0);

        }
        PreStart(time * multiplier);
                }

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine($"Preparar....");
    Thread.Sleep(1000);
    Console.WriteLine($"Apontar....");
    Thread.Sleep(1000);
    Console.WriteLine($"Fogo....");
    Thread.Sleep(2500);

    Start(time);

}
        static void Start(int time)
        {

            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine($"Cronometro Finalizado");
            Thread.Sleep(2500);
        }
    }
}