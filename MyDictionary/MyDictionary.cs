using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<nT, aT>
    {
        nT[] names;
        aT[] ages;

        public MyDictionary() //ctor
        {
            names = new nT[0];
            ages = new aT[0];
        }

        public void Add(nT name, aT age)
        {
            nT[] tempName = names;

            for (int i = 0; i < tempName.Length; i++)
            {
                names[i] = tempName[i];
            }
            names = new nT[names.Length + 1];
            names[names.Length - 1] = name;

            aT[] tempAge = ages;

            for (int j = 0; j < tempAge.Length; j++)
            {
                ages[j] = tempAge[j];
            }
            ages = new aT[ages.Length + 1];
            ages[ages.Length - 1] = age;

            Console.WriteLine(name + ": " + age);

        }

    }
}
