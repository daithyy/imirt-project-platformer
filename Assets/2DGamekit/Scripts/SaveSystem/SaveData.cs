using Gamekit2D;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IMIRT
{
    [Serializable]
    public class SaveData
    {
        public string sceneName;
        public Dictionary<string, Data> dataDictionary;

        public SaveData(string sceneName, Dictionary<string, Data> data)
        {
            this.sceneName = sceneName;
            this.dataDictionary = data;
        }
    }
}
