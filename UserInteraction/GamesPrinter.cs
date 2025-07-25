public class GamesPrinter : IGamesPrinter
{
    private readonly IUserInterface _userInteractor;

    public GamesPrinter(IUserInterface userInterface)
    {
        _userInteractor = userInterface;
    }

    public void Print(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            _userInteractor.PrintMessage("");
            _userInteractor.PrintMessage("The loaded games are: ");
            foreach (var videoGame in videoGames)
            {
                _userInteractor.PrintMessage(videoGame.ToString());
            }

        }
        else
        {
            _userInteractor.PrintMessage("The list is empty.");
        }
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

