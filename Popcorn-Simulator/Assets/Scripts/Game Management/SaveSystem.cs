using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem { 
    /*SaveData kommer behöva ta en container-klass med data i framtiden,
    var enklast att göra det med en enkel int i SavePlayerData:s konstruktor
    i debugging-syfte..
    */
    public static void SaveData (SaveDataContainer dataContainer)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        SavePlayerData data = new SavePlayerData(dataContainer);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SavePlayerData LoadPlayer() 
    {
        string path = Application.persistentDataPath + "/player.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SavePlayerData data = (SavePlayerData)formatter.Deserialize(stream);
            stream.Close();

            return data; 
        }
        else
        {
            Debug.LogError("Save file not found");
            return null;
        }


    }
}
