using System;
using System.Collections.Generic;
using System.Linq;

namespace P1_CustomList {
    class Program {
        static void Main(string[] args) {
            CustomList<string> test = new CustomList<string>();
            test.Add("ala");
            test.Add("ma");
            //test.ShowList();
            //test.ShowLength();

            Console.WriteLine("//////////////");
            test.AddRange(new string []{ "on", "ona", "ono"});
            //test.ShowList();
            //test.ShowLength();

            Console.WriteLine("//////////////");
            test.Insert("Pitor", 2);
            //test.ShowList();
            //test.ShowLength();
            
            Console.WriteLine("//////////////");
            Console.WriteLine(test[2]);
            test[3] = "Agnieszka";
            Console.WriteLine(test[3]);
            Console.WriteLine("//////////////");
            //test.ShowList();

            CustomList<string> test2 = test;

            Console.WriteLine(test.Equals(test2));

            CustomList<string> test3 = new CustomList<string>();
            test3.Add("ala");
            Console.WriteLine(test3[0]);
            CustomList<string> test4 = new CustomList<string>();
            test4.Add("ala");
            //test4.AddRange(new string[]{ "ala"});
            Console.WriteLine(test4[0]);
            //Console.WriteLine(test3.Equals(test4));
            Console.WriteLine(test3.Count+" / " +test4.Count);
            Console.WriteLine(test3 == test4);
            test3.Add("Kasia");
            Console.WriteLine(test3 == test4);
            Console.WriteLine(test3.Count+" / " +test4.Count);
            test4.Add("mleko");
            Console.WriteLine(test3 == test4);
            Console.WriteLine(test3.Count+" / " +test4.Count);
            test3[1] = "mleko";
            Console.WriteLine(test3 == test4);
            Console.WriteLine(test3.Count+" / " +test4.Count);

            CustomList<int> test5 = new CustomList<int>();
            test5.AddRange(new int[] { 3, 4, 5, 6, 7, 8 });
            Console.WriteLine($"Count: {test5.Count}");
            test5.Clear();
            Console.WriteLine($"Count: {test5.Count}");
            test5.AddRange(new int[] { 3, 4, 5, 6, 7, 8 });
            Console.WriteLine($"Count: {test5.Count}");
            test5.RemoveElement(6);
            Console.WriteLine($"Count: {test5.Count}");
            Console.WriteLine("////////////////// test");
            for (int i = 0; i < test5.Count; i++) {
                Console.WriteLine(test5[i]);
            }
            Console.WriteLine("////////////////// end test");
            test5.RemoveAt(1);
            Console.WriteLine($"Count: {test5.Count}");
            Console.WriteLine("////////////////// test");
            for (int i = 0; i < test5.Count; i++) {
                Console.WriteLine(test5[i]);
            }
            Console.WriteLine("////////////////// end test");

            Console.WriteLine("////////////////// test 2");
            test5.Reverse();
            for (int i = 0; i < test5.Count; i++) {
                Console.WriteLine(test5[i]);
            }
            Console.WriteLine("////////////////// end test 2");

            Console.WriteLine("////////////////// test 3");
            Console.WriteLine(test.Contains("ala"));
            Console.WriteLine("////////////////// end test 3");
            Console.WriteLine("////////////////// test 4");
            Console.WriteLine(test.IndexOf("Agnieszka"));
            Console.WriteLine("////////////////// end test 4");

            // not working
            //CustomList<int> test2 = new CustomList<int>() { 1, 2, 3, 4, 5 };

            List<int> t = new List<int>(){1,2,3,4,1 };
            var ttt = t[0];
            List<int> t2= new List<int>(){};
            List<int> t3= new List<int>(3);
            //Console.WriteLine(t3[0]);
            Console.WriteLine(t3.Count);
            Console.WriteLine(t.Count);
            t.Remove(1);
            Console.WriteLine(t.Count);
            Console.WriteLine();
            IEnumerable<int> testtestd = new int[]{ 2,3,4}.Where(q=>q == 2).ToArray();
            bool b = t == t2;
            bool bb = t == testtestd;
            //Console.WriteLine(t2[0]);
            /*Console.WriteLine(t.Count);
            t.AddRange(new List<int>{1,2,3,4,5,0,0,0 });
            
            Console.WriteLine(t.Count);*/
        }
    }
}
