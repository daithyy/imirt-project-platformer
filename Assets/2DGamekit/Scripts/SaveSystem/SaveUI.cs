using Gamekit2D;
using IMIRT.SaveSystem;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace IMIRT
{
    public class SaveUI : MonoBehaviour
    {
        [SerializeField] private OptionUI optionsUI;
        private ISaveSystem m_SaveSystem;

        private void Awake()
        {
            m_SaveSystem = GetComponent<ISaveSystem>();
        }

        public void SaveGame()
        {
            PersistentDataManager.SaveAllData();

            SaveData saveData = BuildSaveData();

            m_SaveSystem.Save(saveData);

            optionsUI.ExitPause();
        }

        public void LoadGame()
        {
            SaveData saveData = m_SaveSystem.Load<SaveData>();

            // Use 2D Game kit engine code

            ApplyGameData(saveData);

            optionsUI.ExitPause();

            //
        }

        private void ApplyGameData(SaveData saveData)
        {
            TransitionPoint transitionPoint = new TransitionPoint();

            transitionPoint.newSceneName = saveData.sceneName;

            SceneController.TransitionToScene(transitionPoint);

            PersistentDataManager.Instance.SetSaveData(saveData.dataDictionary);
        }

        private SaveData BuildSaveData()
        {
            string sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

            Dictionary<string, Data> gameData = PersistentDataManager.Instance.GetSaveData();

            SaveData saveData = new SaveData(sceneName, gameData);

            return saveData;
        }
    }
}
