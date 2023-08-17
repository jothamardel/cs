Person person1 = new Person("Mbiplang");
Person person2 = new Person("James");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();


Math math = new Math();
int result = math.Sum(16, 34);
Console.WriteLine(result);

class Person
{
   

    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}!");

    }
    public string GetGreeting()
    {
        return $"Halo, {Name}!";
    }

}


public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}