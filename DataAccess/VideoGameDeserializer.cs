using System.Text.Json;

public class VideoGameDeserializer : IVideoGameDeserializer
    {
        private readonly IUserInterface _userInteractor;
        

        public VideoGameDeserializer(IUserInterface userInteractor )
        {
            _userInteractor = userInteractor;
        }
        public List<VideoGame> DeserializeFromString(string fileName, string fileContents)
        {
            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"The {fileName} is not in valid or acceptable format. JSON body: ");
                _userInteractor.PrintError(fileContents);

                throw new JsonException($"{ex.Message} The file is {fileName}", ex);
            }


        }
    }

