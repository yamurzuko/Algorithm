using System;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string value;
            string[] arr = {"0","1","2","3","4","5","6","7","8","9"};
            EditInput ?control = new EditInput();
            
            do
            {
                Console.WriteLine("Lütfen bir cümle ve değer girin.");
                value = Console.ReadLine();
            } while (control.IntControl(value, arr) != true || control.CommaControl(value) != true);
            
            string[] splitValue = value.Split(",");
            string result = splitValue[0];
            int number = Convert.ToInt32(splitValue[1]);
            Console.WriteLine(result.Remove(number,1));
            

            
        }
    }
}