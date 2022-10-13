using System;
using System.Collections.Generic;

namespace P1_CustomList {
    class Program {
        static void Main(string[] args) {
            CustomList<string> test = new CustomList<string>();
            test.Add("ala");
            test.Add("ma");
            test.ShowList();
            test.ShowLength();

            Console.WriteLine("//////////////");
            test.AddRange(new string []{ "on", "ona", "ono"});
            test.ShowList();
            test.ShowLength();

            Console.WriteLine("//////////////");
            test.Insert("Pitor", 2);
            test.ShowList();
            test.ShowLength();

            // not working
            //CustomList<int> test2 = new CustomList<int>() { 1, 2, 3, 4, 5 };

            List<int> t = new List<int>(){1,2,3,4 };

            /*Console.WriteLine(t.Count);
            t.AddRange(new List<int>{1,2,3,4,5,0,0,0 });
            
            Console.WriteLine(t.Count);*/
        }
    }
}
