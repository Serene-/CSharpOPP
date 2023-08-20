namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            string[] urls = Console.ReadLine().Split().ToArray();
            ICall phone;
            foreach(string number in numbers)
            {
                if (number.Length == 7)
                {
                    phone = new StationaryPhone();
                    Console.WriteLine(phone.Calling(number));

                }
                else if (number.Length == 10)
                {
                    phone = new Smartphone();
                    Console.WriteLine(phone.Calling(number));
                }
                else Console.WriteLine("Invalid number!");
            }
            foreach(string url in urls)
            {
                Smartphone smartPhone = new Smartphone();
                Console.WriteLine(smartPhone.Browsing(url));
            }
        }
    }
}