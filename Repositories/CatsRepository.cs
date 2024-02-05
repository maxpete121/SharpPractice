namespace SharpPractice.Repositories;

public class CatsRepository{

    private readonly List<Cats> FAKEDB = [
        new Cats("Paul","Brown", 5, "Short Hair"),
        new Cats("Jerry", "White", 2, "Long Hair"),
        new Cats("Whiskers", "Orange", 3, "Mix"),
        new Cats("Fluffy", "Black", 9, "Persian")
    ];

    internal List<Cats> GetCats(){
        return FAKEDB;
    }
}