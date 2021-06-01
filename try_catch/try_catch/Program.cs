using System;

namespace try_catch
{
    class Program
    {
        public class myClass
        {
            public void RefMethod(ref int refArgument)
            {
                refArgument = refArgument + 44;
                Console.WriteLine(refArgument);
            }

        }

        public static string GetNextName(int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
      
        public static string GetNextName(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }


        static void Main(string[] args)
        {
            myClass mem = new myClass();

            int number = 1;
            mem.RefMethod(ref number);
            Console.WriteLine(number);

            try
            {
                int a = 5;
                int b = 7;

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
