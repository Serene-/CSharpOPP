namespace PersonInfo
{
    public class StartUP
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthday = Console.ReadLine();
            IPerson person = new Citizen(name, age, id, birthday);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            IBirthable birthable= new Citizen(name, age, id, birthday);
            Console.WriteLine(birthable.Birthdate);
            IIdentifiable identifiable= new Citizen(name, age, id, birthday);
            Console.WriteLine(identifiable.Id);
        }
    }
}