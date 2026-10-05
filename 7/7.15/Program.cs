Person person = new Person { name = "Ai" , age = 21 , occupation = "student" };
Console.WriteLine(person.age);

class Person {
    public string? name; // to allow the value to be null
    public int age; 
    public string? occupation;
}