public class GameDataParserApp
{
    private readonly IUserInterface _userInteractor;
    private readonly IGamesPrinter _gamesPrinter;
    private readonly IVideoGameDeserializer _videoGameDeserializer;
    private readonly IFileReader _fileReader;

    public GameDataParserApp(IUserInterface userInteractor, IGamesPrinter gamesPrinter,
        IVideoGameDeserializer videoGameDeserializer, IFileReader fileReader)
    {
        _userInteractor = userInteractor;
        _gamesPrinter = gamesPrinter;
        _videoGameDeserializer = videoGameDeserializer;
        _fileReader = fileReader;
    }


    public void Run()
    {
        string fileName = _userInteractor.ReadValidFilePathFromUser();

        var fileContents = _fileReader.Read(fileName);
        List<VideoGame> videoGames = _videoGameDeserializer.DeserializeFromString(fileName, fileContents);
        _gamesPrinter.Print(videoGames);
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

