using System.Security.Cryptography.X509Certificates;

namespace Zadania_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Zadanie nr 1 ");

            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine($" Liczby: {a} i {b} są identyczne");
            }
            else
            {
                Console.WriteLine($" Liczby {a} i {b} nie są identyczne");
            }

            Console.WriteLine("\n Zadanie nr 2 ");
            int evenNumber = 15;
            if (evenNumber % 2 != 0)
            {
                Console.WriteLine($" {evenNumber} jest liczba nieparzystą");
            }
            else
            {
                Console.WriteLine($" {evenNumber} jest liczbą parzystą");
            }

            Console.WriteLine("\n Zadanie nr 3");
            int number = 14;
            if (number < 0)
            {
                Console.WriteLine($" {number} jest liczba ujemną");
            }
            else if (number > 0)
            {
                Console.WriteLine($" {number} jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine($" {number} jest równa zero");
            }

            Console.WriteLine("\n Zadanie nr 4 - Rok przestępny");
            int year = 2016;
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine($" Rok {year} jest rokiem przestępnym. ");
            }
            else
            {
                Console.WriteLine($" Rok {year} nie jest przestępny");
            }

            Console.WriteLine("\n Zadanie nr 5");
            
            int wiek = 21;
            
            if (wiek < 21)
            {
                Console.WriteLine(" Nie możesz ubiegać się o stanowisku W Rządzie.");
            }
            else if ((wiek >= 21) && ( wiek < 25 ))
            {
                Console.WriteLine(" Możesz zostać posłem.");
            }
            else if ((wiek >=25 ) && ( wiek < 30 ))
            {
                Console.WriteLine(" Możesz zostać posłem i premierem."); // nie wiem czy jest ustalony wiek na premiera :)
            }
            else if( (wiek >= 30) && ( wiek <35 ))
            {
                Console.WriteLine(" Możesz zostać posłem, premierem i senatorem.");
            }
            else if (wiek >= 35) // może wystarczyło by else?
            {
                Console.WriteLine(" Możesz zostać posłem, premierem, senatorem, a nawet prezydentem.");
            }

            Console.WriteLine("\n Zdanie nr 6");

            int wzrost = 140;
            if( wzrost < 140)
            {
                Console.WriteLine("Jesteś liliputem");
            }
            else if((wzrost >=140 ) && ( wzrost <=150 ))
            {
                Console.WriteLine(" Jesteś krasnoludem.");
            }
            else if(( wzrost > 150) &&  ( wzrost <= 170))
            {
                Console.WriteLine(" Mogłbyś urosnąć jeszcze");
            }
            else if(( wzrost > 170 ) &&  ( wzrost <= 190))
            {
                Console.WriteLine(" Twój wzrost jest ok");
            }
            else
            {
                Console.WriteLine(" Jestes wielkoludem");
            }

            Console.WriteLine("\n Zadanie nr 7");

            int x = 25; 
            int y = 63; 
            int z = 79; 
            
            if ((x > y ) && ( x > z))
            {
                Console.WriteLine($" {x} jest największą liczbą z podanych ");
            }
            else if((y > z) && ( y > x ))
            {
                Console.WriteLine($" {y} jest największą liczbą z podanych");
            }
            else if ((z > x) && ( z > y ))
            {
                Console.WriteLine($" {z} jest największą liczbą");
            }
            else
            {
                Console.WriteLine(" Brak liczby największej");
            }

            Console.WriteLine("\n Zadanie nr 8");

            int mat = 80;
            int fiz = 71;
            int chem = 0;

            Console.WriteLine(" Wyniki testowe brane po uwagę do rekrutacji");
            Console.Write($" Matematyka = {mat} pkt \n Fizyka = {fiz} pkt \n Chemia = {chem} pkt ");
            
            
            if ((mat > 70) || (fiz >55 ) ||  (chem > 45)) // pryjąłem, że wynik z jednego  przedmiotu daje przepustkę, jakby miały być 3 razem użyłbym &&
            {
                Console.WriteLine("\n Kandydat dopuszczony do rekutacji ");
            }
            else if( ( mat + fiz + chem) > 180) // łączny wynik z 3 przedmiotów 
            {
                Console.WriteLine("\n Kandydat dopuszczony do rekrutacji ");
            }
            else if (((mat + fiz) > 150) || ((mat + chem) > 150))
            {
                Console.WriteLine("\n Kandydat dopuszczony do rekrutacji ");
            }
            else
            {
                Console.WriteLine("\n Brak dopuszczenia do rekrutacji ");
            }

            Console.WriteLine("\n Zadanie nr 9  - Temperatura ");
            int temp = 41;
            if( temp < 0 )
            {
                Console.WriteLine(" cholernie piździ ");
            }
            else if((temp >= 0) && (temp < 10))
            {
                Console.WriteLine(" zimno ");
            }
            else if ( (temp >= 10) && (temp < 20))
            {
                Console.WriteLine(" chłodno ");
            }
            else if ( (temp >=20 ) && ( temp < 30) )
            {
                Console.WriteLine(" w sam raz ");
            }
             else if ((temp >= 30) && (temp < 40))
            {
                Console.WriteLine(" zaczyna byc słabo bo gorąco ");
            }
            else // chyba wiadomo, ze pozostała temperatura tylko <= 40, myslałem aby zrobic else if 
            {
                Console.WriteLine(" a weż wyprowadź się na Alaskę");
            }

            Console.WriteLine("\n Zadanie nr 10 - Trójkąt");
            int bokA = 40;
            int bokB = 55;
            int bokC = 65;
            if ( ( bokA + bokB > bokC ) || ( bokA + bokC > bokB ) || ( bokB + bokC > bokA ) )  
            {
                Console.WriteLine(" Można zbudowac trójkąt ");
            }
            else 
            {
                Console.WriteLine(" Nie można zbudowac trójkąta ");
            }

            Console.WriteLine("\n Zadanie nr 11 - Oceny");
            int ocena = 3;
            switch (ocena)
            {
                case 6:
                    Console.WriteLine(" Celujący");
                    break;
                case 5:
                    Console.WriteLine(" Bardzo dobry");
                    break;
                case 4:
                    Console.WriteLine(" Dobry");
                    break;
                case 3:
                    Console.WriteLine(" Dostateczny");
                    break;
                case 2:
                    Console.WriteLine(" Dopuszczający");
                    break;
                case 1:
                    Console.WriteLine(" Niedostateczny");
                    break;

                default:
                    Console.WriteLine(" Zły wybór");
                    break;
            }

            Console.WriteLine("\n Zadanie 12 - dni tygodnia");
            int dzien = 4;
            switch(dzien)
            {
                case 1:
                    Console.WriteLine(" Poniedzialek");
                    break;
                case 2:
                    Console.WriteLine(" Wtorek");
                    break;
                case 3:
                    Console.WriteLine(" Środa");
                    break;
                case 4:
                    Console.WriteLine(" Czwartek");
                    break;
                default:
                    Console.WriteLine("Błędny wybór");
                    break;
                    
            }
        }
    }
}