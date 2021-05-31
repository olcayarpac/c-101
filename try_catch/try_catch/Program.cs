using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";

            try
            {
                int a = 5;
                int b = 7;

                double x = a;
                Console.WriteLine(x);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
