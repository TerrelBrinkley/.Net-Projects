namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            /* Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine(); */

            Console.WriteLine("Type your First Name: ");
            string myFirstName = Console.ReadLine();

            /* string myLastName;
            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine(); */

            Console.WriteLine("Type your Last Name: ");
            string myLastName = Console.ReadLine();

            /* sting myNickname;
            Console.Write("Type your nickname: ");
            nickname = Console.ReadLine(); */

            Console.WriteLine("Type your Nickname: ");
            string myNickname = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + " " + "aka" + " " + myNickname);
            Console.ReadLine();
        }
    }
}