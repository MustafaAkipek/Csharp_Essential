// Dynamic Dimensional

// a) Non-Generic Collections => There may be different data types in the same structure
// b) Generic Collections => Only one type of data type can be used in the structure

using System.Collections;

namespace ConsoleApp {

    class Collections {
        
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();

            list1.Add(10);
            list1.Add("10");
            list1.Add("ali");
            list1.Add(null);
            list1.Add(true);

            var list2 = new ArrayList() {
                5,
                "ahmet",
                false,
                4.5,
                null
            };

            int[] numbers = {10,20,30};

            list1.AddRange(numbers);

            var element = list1[0];
            var name = list2.ToString();
           
            list1.Insert(1, "sadık");
            list1.InsertRange(2, list2);

            list1.Remove(10);
            list1.RemoveAt(2);
            list1.RemoveRange(2, 3);

            Console.WriteLine(list1.Contains(100));
            Console.WriteLine(list1.IndexOf(10));

            // Generic List
            List<int> numberlist = new List<int>();

            numberlist.Add(10);
            numberlist.Add(20);

            List<string> namelist = new List<string>() {"ali","ahmet","ayşe"};

            // Dictionary

            Dictionary<int, string> plates = new Dictionary<int, string>();

            plates.Add(34, "Istanbul");
            plates.Add(41, "Kocaeli");
            plates.Add(53, "Rize");

            Console.WriteLine(plates[41]);

        }
    }
}