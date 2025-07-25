using System.Runtime.CompilerServices;
using static GameDataParserApp;

var userInteractor = new ConsoleUserInteraction();
var gameDataPaerserObject = new GameDataParserApp(userInteractor, new GamesPrinter(userInteractor),
    new VideoGameDeserializer(userInteractor), new LoadFileReader());
var logger = new Logger("log.txt");

try
{
    gameDataPaerserObject.Run();
}
catch (Exception ex)
{
    Console.WriteLine("The app ran into an unexpected error and will be closed.");
    logger.Log(ex);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();


