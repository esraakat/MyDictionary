using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int > myDictionary= new MyDictionary<string, int>();
            myDictionary.Add("Esra", 20);
            myDictionary.Add("Elif", 11);
            myDictionary.Add("Hasan", 28);
            
        }
    }
}
