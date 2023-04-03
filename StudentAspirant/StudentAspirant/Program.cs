namespace StudentAspirant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<IStudent> stack = new Stack<IStudent>();
            IStudent student1 = new Aspirant("FirstName1","LastName1",111,5);
            IStudent student2 = new Student("FirstName2", "LastName2", 222, 5);
            IStudent student3 = new Student("FirstName3", "LastName3", 333, 2);
            IStudent student4 = new Aspirant("FirstName4", "LastName4", 444, 3);
            stack.Push(student1);
            stack.Push(student2);
            stack.Push(student3);
            stack.Push(student4);
            foreach (var k in stack)
            {
                Console.Write(k.AvgMark+",$");
                k.GetScholarShip();
                Console.WriteLine(k.ScholarShip);
            }
        }
    }
}