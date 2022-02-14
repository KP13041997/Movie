namespace MovieCSharp;



public class program
{

    public static void Movielist(List<Movies> MovieList)
    {
        Movies MovieName = new Movies("Genre", 12, "Title");
        Movies MovieName2 = new Movies("Genre2", 18, "Title");
        Movies MovieName3 = new Movies("Genre3", 15, "Title");
        MovieList.Add(MovieName);
        MovieList.Add(MovieName2);
        MovieList.Add(MovieName3);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<Movies> MovieList = new List<Movies>();
        Movielist(MovieList);
        
        foreach(Movies movies in MovieList)
        {

        }
    }



}

public class Movies
{
    public Movies(string v1, int v2, string v3)
    {
        V1 = v1;
        V2 = v2;
        V3 = v3;
    }

    public string V1 { get; }
    public int V2 { get; }
    public string V3 { get; }
}


// See https://aka.ms/new-console-template for more information

