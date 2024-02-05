namespace SharpPractice.Models;



public class Cats{
    public string Id {get; set;} = Guid.NewGuid().ToString();
    public string Name {get; set;}
    public string Color {get; set;}
    public int Age {get; set;}
    public string Breed {get; set;}
public Cats(string name, string color, int age, string breed){
    Name = name;
    Color = color;
    Age = age;
    Breed = breed;
}
}
