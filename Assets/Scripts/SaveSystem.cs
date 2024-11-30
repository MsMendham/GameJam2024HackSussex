using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    public static SaveSystem instance;

    public SaveData saveData = new SaveData();
    public string filePathEnd = "/save.json";
    public string filePath;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        filePath = Application.persistentDataPath + filePathEnd;
    }

    public void SaveToJSON()
    {
        Debug.Log("Saved");
        string saveDataAsString = JsonUtility.ToJson(saveData);

        File.WriteAllText(filePath, saveDataAsString);
    }

    public void LoadFromJSON()
    {
        Debug.Log("loaded");
        if (File.Exists(filePath))
        {
            string saveDataAsString = File.ReadAllText(filePath);
            saveData = JsonUtility.FromJson<SaveData>(saveDataAsString);
        }
        else
        {
            saveData = new SaveData();
        }
    }

    public void OnApplicationQuit()
    {
        SaveToJSON();
    }
}
[System.Serializable]
public class SaveData
{
    public int frontHealth;
    public int middleHealth;
    public int backHealth;

}