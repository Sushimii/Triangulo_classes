using System;
//Puxando todas bibliotecas basicas
using System.Globalization;


namespace Course
{

    //Criando classe triangulo
    public class Triangulo
    {
        
        public double A { get; set; }
        public double B { get; set; }
        
        public double C { get; set; }

        //criando metodo calcular area
        public double CalcularArea()
        {
            // a formula que irá calcular a area do triangulo
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            //Parando o processo e adicionando o valor a variavel area
            return area;
        }

    }

    //criando classe programa
    public class Program
    {
        public static void Main (string[] args)
        {
            //Chamando metodo LerTriangulo para triangulo X
            Triangulo x = LerTriangulo("X");
            //Chamando metodo LerTriangulo para triangulo Y
            Triangulo y = LerTriangulo("Y");
            
            //Chamando metodo para CalcularArea para calcular a area do triangulo X
            double areaX= x.CalcularArea();
            //Chamando metodo para CalcularArea para calcular a area do triangulo Y
            double areaY= y.CalcularArea();

            //Mensagem mostrando para o usuario o valor da area do triangulo X
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Mensagem mostrando para o usuario o valor da area do triangulo y
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            //Condição se a variavel "areaX" possuir valor maior que variavel "areaY"
            if (areaX > areaY)
            {
                //Mensagem caso condição acima seja cumprida
                Console.WriteLine("Maior área: X");
            }
            //Condição se a outra condição se não for cumprida  
            else
            {
                //Mensagem caso a condição acima for cumprida
                Console.WriteLine("Mairo área : Y");
            }
        }
        
        //Crinado um metodo LerTriangulo que vai retornar um objeto triangulo
        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            //Criando um novo objeto Triangulo
            Triangulo triangulo = new Triangulo();
             
            
           //Mensagem para o usuario digitar as medidas do triangulo tanto X como Y
            Console.WriteLine("Entre com as medidas do triângulo "+ nomeTriangulo + ":");
            //Primeiro valor sendo atribuido ao objeto triangulo.A
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Segundo valor sendo atribuido ao objeto triangulo.B
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Terceiro valor sendo atribuido ao objeto triangulo.C
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Parar a execução do programa e retornar o valor ao objeto triangulo
            return triangulo;
        }
            
            
            
     }


    


}
