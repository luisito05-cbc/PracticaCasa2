namespace Ejercicio3
{
    internal class Ej3

    {
        static void Main(string[] args)
        {
            /*Ejercicio 3.
                Solicitar dos números (controlar que el primer número sea menor al segundo) y muestre todos
                los números entre los valores ingresados que sean pares. Para salir se debe ingresar 0.*/
        
            Console.WriteLine("Inregar primer numero");
            int numer1= int.Parse(Console.ReadLine());
        
            Console.WriteLine("Ingresar segundo numero");

            int numer2 = int.Parse(Console.ReadLine());
        
        

            if (numer1 > numer2)
            {
                Console.WriteLine("El primer numero debe ser menor al segundo");

                for (int i = numer1; i <= numer2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();


        //No me imprime el rango de numero de i
        }
    }

}

