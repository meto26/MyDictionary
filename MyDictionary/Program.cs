using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Mete");
            myDictionary.Add(2, "Nazmi");
            myDictionary.Add(3, "Engin");
            myDictionary.Add(4, "Batur");
            myDictionary.Add(5, "Bilge");
            myDictionary.Add(6, "Berk");

            myDictionary.ToList();
        }
    }
}
