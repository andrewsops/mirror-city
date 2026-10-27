using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void Save(PlayerState state, string fileName = "savegame.json")
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);
        string json = JsonUtility.ToJson(state, true);
        File.WriteAllText(path, json);
        Debug.Log("Saved game to: " + path);
    }

    public PlayerState Load(string fileName = "savegame.json")
    {
        string path = Path.Combine(Application.persistentDataPath, fileName);

        if (!File.Exists(path))
        {
            return new PlayerState();
        }

        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<PlayerState>(json);
    }
}
