using Microsoft.Extensions.ObjectPool;

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

    internal Cats GetCatById(string catId){
        Cats cat = FAKEDB.Find(cat => cat.Id == catId);
        return cat;
    }

    internal Cats CreateCat(Cats catData){
        FAKEDB.Add(catData);
        return catData;
    }

    internal void DeleteCat(string catId){
        int indexToRemove = FAKEDB.FindIndex(cat => cat.Id == catId);
        FAKEDB.RemoveAt(indexToRemove);
    }
}