public interface IVideoGameDeserializer
    {
        List<VideoGame> DeserializeFromString(string fileName, string fileContents);
    }

