public interface IGamesPrinter
{
    void Print(List<VideoGame> videoGames);
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

