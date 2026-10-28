namespace Session_1_s_Task
{
    #region 1
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"ID: {this.Id} Name: {this.Name} Email: {this.Email}";
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2
            Console.WriteLine("Task 2");
            int x = 10;
            int y = 5;
            y = x;
            x = 20;

            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");// y will not change because you're coping the value not the refrence
            #endregion

            #region 3
            Console.WriteLine("Task 3");
            Person p1 = new Person(1, "Omar", "omar.gmail.com");
            Person p2 = new Person(2, "Islam", "islam.gmail.com");

            Console.WriteLine("Before assignment:");
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");

            p1 = p2;
            p1.Name = "Amir";

            Console.WriteLine("After p1 = p2 and changing p1.Name:");
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}"); // they will display the same name because the are pointing to the same memory address so any change happen to any one of them the other one will see it too
            #endregion

            #region 4
            Console.WriteLine("Task 4");
            p1 = new Person(3, "Ahmed", "ahmed@gmail.com");

            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}"); // p2 won't change when p1 change becuse when we used the new keyword we gave p1 a new object with a new address so it won't see the old object
            #endregion

            #region 5
            Person p3 = p2;
            p3.Email = "ahmed_updated@example.com"; // p2 will be affected because it still points for the same refrence
            Console.WriteLine($"p2: {p2}");
            Console.WriteLine($"p3: {p3}");

            p3 = new Person(4, "Kareem", "kareem@example.com"); // p3 will be totally independent from p2
            Console.WriteLine($"p2: {p2}"); // p2 won't be affected anymore
            Console.WriteLine($"p3: {p3}");
            #endregion
        }
    }
}
