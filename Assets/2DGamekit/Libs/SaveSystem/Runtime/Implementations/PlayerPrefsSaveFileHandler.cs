using UnityEngine;

namespace IMIRT.SaveSystem.Assets._2DGamekit.Libs.SaveSystem.Runtime.Implementations
{
    public class PlayerPrefsSaveFileHandler : ISaveFileHandler
    {
        public void SaveData(string dataString, string key)
        {
            PlayerPrefs.SetString(key, dataString);
        }

        public string LoadData(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public void DeleteData(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }

        public bool Exists(string key)
        {
            return PlayerPrefs.HasKey(key);
        }
    }
}
