namespace GitThisThingDone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            Console.WriteLine("What is your name?");
            Name= Console.ReadLine(); // this is cool
            Console.WriteLine("Hello, World!, " + Name.ToUpper());
        }
    }
}
