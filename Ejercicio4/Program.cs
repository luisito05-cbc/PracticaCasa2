namespace Ej4
{
    internal class Ej4
    {
        static void Main(string[] args)
        {
            /*Solicitar dos números y un valor, indicar si el valor está comprendido entre los números*/
            
            //SE INGRESA EL PRIMER NUMERO
            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            
            //SE INGRESA EL SEGUNDO NUMERO
            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            
            //SE INGRESA EL VALOR NUMERO
            Console.WriteLine("Inresar un valor");
            int valor = int.Parse(Console.ReadLine());

            if (valor > num1 && valor < num2)
            {
                Console.WriteLine($"el numero {valor } esta dentro de los rangos comprendidos de {num1} y {num2}");
            }

            Console.ReadKey();

        }
        
        
    }

}

