namespace IMIRT.SaveSystem
{
    internal interface ISaveFileHandler
    {
        void SaveData(string dataString);

        string LoadData();
    }
}
