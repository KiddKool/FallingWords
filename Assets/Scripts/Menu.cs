using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


/*public class Menu : MonoBehaviour
{
    public void SaveGame()
    {
        var save = CreateSavedGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
    }

    public void SaveAsJSON()
    {
        var save = CreateSavedGameObject();
        string json = JsonUtility.ToJson(save);
    }

    private Save CreateSavedGameObject()
    {
        throw new NotImplementedException();
    }
}
*/