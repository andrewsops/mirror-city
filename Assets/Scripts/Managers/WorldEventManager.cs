using System.Collections.Generic;
using UnityEngine;

public class WorldEventManager : MonoBehaviour
{
    private List<WorldEvent> activeEvents = new List<WorldEvent>();

    public void TriggerEvent(WorldEvent worldEvent)
    {
        activeEvents.Add(worldEvent);
        Debug.Log("Triggered world event: " + worldEvent.name);
    }

    public void ResolveEvent(WorldEvent worldEvent)
    {
        activeEvents.Remove(worldEvent);
    }

    public List<WorldEvent> GetActiveEvents()
    {
        return activeEvents;
    }
}

[System.Serializable]
public class WorldEvent
{
    public string id;
    public string name;
    public string districtId;
    public int intensity;
    public string description;
}
