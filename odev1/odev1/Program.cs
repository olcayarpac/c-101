using System;

namespace odev1
{
    class Program
    {

           
        static void question1()
        {
            
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i+1).ToString()+ ".sayıyı giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Çift olanlar: ");
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.Write(numbers[i].ToString() + " ");
            }


        }

        static void question2()
        {
            Console.WriteLine("Pozitif bir sayı giriniz(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pozitif bir sayı giriniz(m): ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1).ToString() + ".sayıyı giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write( m.ToString() + " ile tam bölünenler: ");
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] % m == 0)
                    Console.Write(numbers[i].ToString() + " ");
            }

        }

        static void question3()
        {
            Console.WriteLine("Pozitif bir sayı giriniz(n): ");
            int n = Convert.ToInt32(Console.ReadLine());
          
            string[] words= new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1).ToString() + ".kelimeyi giriniz: ");
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words);
            for (int i = 0; i < n; i++)
            {
                Console.Write(words[i].ToString() + " ");
            }

        }

        static void question4()
        {
            Console.WriteLine("Bir cümle yazınız: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Cümledeki kelime sayısı: "+ sentence.Split(" ").Length);

            int charNumber = 0;
            foreach (string word in sentence.Split(" "))
                charNumber+= word.Length;
            Console.WriteLine("Cümledeki karakter sayısı: " + charNumber.ToString());
        }



        static void Main(string[] args)
        {
            Console.WriteLine("First question");
            Console.WriteLine("----------------------------------");
            question1();
            Console.WriteLine("\nSecond question");
            Console.WriteLine("----------------------------------");
            question2();
            Console.WriteLine("\nThird question");
            Console.WriteLine("----------------------------------");
            question3();
            Console.WriteLine("\nThird question");
            Console.WriteLine("----------------------------------");
            question4();

        }
    }
}
