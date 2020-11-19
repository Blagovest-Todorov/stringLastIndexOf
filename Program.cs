using System;

namespace _03.lastIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "gosho aaac gosho pesho ivabn pesho gosho";
            int found = text.LastIndexOf("pesho");
            Console.WriteLine(found);
        }
    }
}
