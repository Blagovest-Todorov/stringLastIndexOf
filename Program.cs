using System;

namespace _03.lastIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "gosho aaac gosho pesho ivabn pesho gosho";
            int found = text.LastIndexOf("pesho");//we search in strin text the last indexValue of occurance of pesho
            Console.WriteLine(found); //searches in tetx string the last indexValue where str pesho met for last time
        }
    }
}
