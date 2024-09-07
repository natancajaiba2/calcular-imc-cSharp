using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imc
{
    internal class Pessoa
    {
        public string nome;
        public float peso;
        public float altura;
        public float resultado;

       public void informacao()
        {
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("digite seu peso atual (em kilos)");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("digite sua altura (em metros)");
            altura = float.Parse(Console.ReadLine());
            Console.ReadKey();

        }
       public void calcular()
        {
            resultado = peso / (altura * altura);
            if(resultado < 16)
            {
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", magreza grave");
                Console.ReadKey();
            }
            else if (resultado > 16 && resultado < 16.9){
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", magreza moderada");
                Console.ReadKey();
            }
            else if (resultado > 17 &&  resultado < 18.5)
            {
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", magreza leve");
                Console.ReadKey();
            }
            else if(resultado > 18.6 &&  resultado < 24.9)
            {
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", peso ideal");
                Console.ReadKey();
            }
            else if (resultado > 25 &&  resultado < 29.9)
            {
                Console.WriteLine("olá " + nome + "seu imc é: " + resultado + ", sobrepeso");
                Console.ReadKey();
            }
            else if (resultado > 30 &&  resultado < 34.9)
            {
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", obesidade grau 1");
                Console.ReadKey();
            }
            else if (resultado > 35 && resultado < 39.9)
            {
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", obesidade grau 2 ou severa");
                Console.ReadKey();
            }
            else 
            { 
                Console.WriteLine("olá " + nome + " seu imc é: " + resultado + ", obesidade 3 ou mórbida");
                Console.ReadKey();
            }
        }

    }
}
