public class VideoGame
{
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }

    public override string ToString()
    {
        return $"{Title}, {ReleaseYear}, {Rating}";
    }
}


//Alternate try catch block for Run() method code instead of If statements, in case we want to specify exceptions
//try
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine("The file name cannot be null.");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("The file name cannot be empty.");
//}
//catch (FileNotFoundException ex)
//{
//    Console.WriteLine("The file name cannot be found.");
//}

