//class Program
//{
//    delegate int add(int a, int b);

//    //anonym methods
//    static void Main()
//    {
//        add add = (int a, int b) => a + b;
//        Console.WriteLine(add(1, 2));

//        add Minus = (int a, int b) => a - b;
//        Console.WriteLine(add(1, 2));

//        List<int> intlist = new List<int> { 1, 2, 23, 4, 5 };
//        List<int> intlist2 = intlist.Select(x => x * x).ToList();
//        intlist2.ForEach(x => Console.WriteLine(x));
//    }
//}



//link

class Program
{
    static void Main()
    {
        //List<string> ToysList = new List<string> { "Barbie", "Doll", "Car" };
        //var aList = from toys in ToysList
        //            where toys.Contains("a")
        //            select toys;
        //var CountToys = ToysList.Where(x => x.StartsWith("t") || x.EndsWith("1")).Count();
        //Console.WriteLine(CountToys);

        var Books = new List<books>();

        Books.Add(new books { Name = "pirvlei", Genre = "fentezi" });
        Books.Add(new books { Name = "meore", Genre = "fentezi" });
        Books.Add(new books { Name = "pirvlei", Genre = "mdzafri" });

        //var booklist = Books.Where(x => x.Name == "meore" && x.Genre == "fentezi").FirstOrDefault();

        //Console.WriteLine(booklist.Genre+" "+booklist.Name);

        var booklist = (from item in Books
                       where item.Name == "meore" && item.Genre == "fentezi"
                       select item).FirstOrDefault();
        Console.WriteLine(booklist.Genre + " " + booklist.Name);
    }
    class books{
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}