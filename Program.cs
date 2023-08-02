namespace Day5_3;

//class User {
//    public int id;
//    public string name;
//    public string city;
//    public string dob;
//}

class Employee {
    public string name;
    public string gender;
}

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine();

        //User[] users = {
        //        new User { id = 1,name="john",city="london",dateofbirth="2001-05-21" },
        //        new User { id = 2,name="windy",city="singapore",dateofbirth="2002-06-23" },
        //        new User { id = 3,name="barbara",city="hongkong",dateofbirth="2003-08-7" },
        //        new User { id = 4,name="nick",city="hongkong",dateofbirth="2001-04-9" },
        //        new User { id = 5,name="paul",city="singapore",dateofbirth="2004-03-23" },
        //        new User { id = 6,name="andika",city="singapore",dateofbirth="2001-123-23" },
        //        new User { id = 7,name="herman",city="london",dateofbirth="2001-07-21" },
        //        new User { id = 8,name="sadiq",city="london",dateofbirth="2003-4-21" },
        //        new User { id = 9,name="casselyn",city="hongkong",dateofbirth="2004-05-21" },
        //        new User { id = 10,name="miki",city="singapore",dateofbirth="2005-08-21" }
        //    };



        //User[] users = {
        //    new User{ id=1, name="John", city="london", dob="2001-05-21" },
        //    new User{ id=2, name="Luffy", city="singapore", dob="2000-10-23" },
        //    new User{ id=3, name="Sanji", city="hongkong", dob="1998-05-2" },
        //    new User{ id=4, name="Zoro", city="delhi", dob="2001-12-3" },
        //    new User{ id=5, name="Ace", city="dubai", dob="2001-05-5" },
        //    new User{ id=6, name="Nami", city="jaipur", dob="1995-05-21" },
        //    new User{ id=7, name="Jack", city="california", dob="2001-11-21" },
        //    new User{ id=8, name="Robin", city="singapore", dob="1965-06-21" },
        //    new User{ id=9, name="Chopper", city="hongkong", dob="1978-05-21" },
        //    new User{ id=10, name="Gojo", city="london", dob="2011-04-21" }
        //};

        //var result = from usr in users where usr.city == "hongkong" select usr;


        //foreach (var usr in result) {
        //    Console.WriteLine(usr.name+" "+usr.city);
        //}
        //===============================================
        //string wish = "One #Day I'll Make The #Onions #Cry";

        //string[] words = wish.Split(" ");

        //var result = words.Where(w => w.StartsWith("#"));

        //foreach (var word in result) {
        //    Console.WriteLine(word);
        //}

        //===============================================

        //var numbers = new List<int> { 6, 2, -3, 4, -5, 9, 7, 8 };

        //int length = numbers.Count();
        //Console.WriteLine($"Total Elements: {length}");

        //int length2 = numbers.Count(n => n % 2 == 0);
        //Console.WriteLine($"Total Even Elements: {length2}");

        //int total = numbers.Sum();
        //Console.WriteLine($"Sum: {total}");

        //int evenSum = numbers.Sum(n => n % 2 == 0 ? n : 0);
        //Console.WriteLine($"Sum of even numbers: {evenSum}");

        //double mean = numbers.Average();
        //Console.WriteLine($"Average of numbers: {mean}");

        //Console.WriteLine($"Largest Number: {numbers.Max()}");

        //Console.WriteLine($"Smallest Number: {numbers.Min()}");

        //var res = from num in numbers orderby num ascending select num;
        //foreach (int num in res) {
        //    Console.Write(num + " ");
        //}

        //===============================================

        //Grouping

        Employee[] employees = {
            new Employee{ name = "Windy", gender="Female"},
            new Employee{ name = "James", gender="Male"},
            new Employee{ name = "Casselyn", gender="Female"},
            new Employee{ name = "Armanta", gender="Female"},
            new Employee{ name = "Johnseto", gender="Male" }
        };

        var empGroups = from emp in employees group emp by emp.gender;

        foreach (var grp in empGroups) {
            Console.WriteLine("Group -> " + grp.Key);

            foreach (var e in grp) {
                Console.WriteLine(e.name + " "+e.gender);
            }

            Console.WriteLine("==============================");
        }




    }
}

