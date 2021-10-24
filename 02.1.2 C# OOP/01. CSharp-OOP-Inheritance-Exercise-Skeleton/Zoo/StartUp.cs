namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Animal animal = new Animal("Peter");
            System.Console.WriteLine(animal.Name);
            animal.Name = "George";
            System.Console.WriteLine(animal.Name);
        }
    }
}