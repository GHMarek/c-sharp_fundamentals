using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csfClassLibrary.Basics
{
    public class Assignment1
    {
        /*
         Zadanie: Iterowanie po danych wejściowych (treść)
        Zadanie:

        Utwórz aplikację konsolową, która będzie wczytywać wartości liczbowe od użytkownika, dopóki nie poda on wartości 0.

        Podczas czytania, aplikacja powinna:

        obliczyć sumę wszystkich elementów

        znaleźć największy element

        Po wczytaniu wartości 0, te dwie wartości powinny zostać wypisane w konsoli.
        */

        public static void assignmentFunc()
        {
            bool expr = false;
            string usrInput;
            int suma = 0;
            int maxNumber = 0;

            while (!expr)
            {
                Console.WriteLine("Podaj liczbę. 0 kończy zabawę.");
                
                usrInput = Console.ReadLine();
                int number;

                if (int.TryParse(usrInput, out number))
                {
                    number = int.Parse(usrInput);

                    if (number == 0)
                    {
                        expr = true;
                    }

                    maxNumber = maxNumber > number ? maxNumber : number;

                    suma += number;

                    Console.WriteLine($"Max value: {maxNumber}; sum of values: {suma}; your current number: {number}");

                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }

            }
        }
    }
}
