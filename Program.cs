using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args) 
    {
      Menu();
    }
    static void Menu(){
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("--------------");
      Console.WriteLine("Selecione a opção desejada...");

      short res = short.Parse(Console.ReadLine());

      switch(res){
        case 1: Soma();
        break;
        case 2: Subtracao();
        break;
        case 3: Divisao();
        break;
        case 4: Multiplicacao();
        break;
        case 5: System.Environment.Exit(0);
        break;
        default: Menu();
        break;
      }

    }
    static void Soma(){
     Console.Clear();
     Console.WriteLine("Digite o primeiro valor: ");
     float v1 = float.Parse(Console.ReadLine());
     Console.WriteLine("Digite o segundo valor: ");
     float v2 = float.Parse(Console.ReadLine());
     float soma = v1 + v2;
     Console.WriteLine($"A soma do v1 + v2 é: {soma}");   
     Console.ReadKey();  
     Menu();
    }

    static void Subtracao(){
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      float subtracao = v1 - v2;
      Console.WriteLine($"A subtração do v1 - v2 é: {subtracao}");
      Console.ReadKey();
      Menu();

    }

    static void Divisao(){
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      float divisao = v1 / v2;
      Console.WriteLine($"A divisao do v1 / v2 é: {divisao}");
      Console.ReadKey();
      Menu();

    }

    static void Multiplicacao(){
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      float multiplicacao = v1 * v2;
      Console.WriteLine($"A multiplicação do v1 * v2 é: {multiplicacao}");
      Console.ReadKey();
      Menu();

    }

    }
  }
