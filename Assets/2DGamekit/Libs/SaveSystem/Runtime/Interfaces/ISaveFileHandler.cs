namespace IMIRT.SaveSystem
{
    public interface ISaveFileHandler
    {
        void SaveData(string dataString, string key);

        string LoadData(string key);

        void DeleteData(string key);

        bool Exists(string key);
    }
}
