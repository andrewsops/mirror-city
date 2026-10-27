using System.Collections.Generic;
using UnityEngine;

public class FactionManager : MonoBehaviour
{
    public Dictionary<string, FactionState> factions = new Dictionary<string, FactionState>();

    private void Awake()
    {
        RegisterFaction(new FactionState
        {
            factionId = "F_01",
            factionName = "Night Shift",
            influence = 30f,
            fearScore = 45f,
            power = 25f,
            reputation = 50f,
            territory = new List<string> { "District_01" }
        });
    }

    public void RegisterFaction(FactionState faction)
    {
        if (!factions.ContainsKey(faction.factionId))
        {
            factions[faction.factionId] = faction;
        }
    }

    public FactionState GetFaction(string factionId)
    {
        if (factions.ContainsKey(factionId))
        {
            return factions[factionId];
        }

        return null;
    }

    public void AdjustInfluence(string factionId, float amount)
    {
        if (!factions.ContainsKey(factionId))
            return;

        factions[factionId].influence = Mathf.Clamp(factions[factionId].influence + amount, 0f, 100f);
    }

    public void SetRelationship(string factionIdA, string factionIdB, float value)
    {
        if (!factions.ContainsKey(factionIdA) || !factions.ContainsKey(factionIdB))
            return;

        // This stub is intentionally simple and can be expanded as the design grows.
        Debug.Log($"Faction relationship updated: {factionIdA} -> {factionIdB} = {value}");
    }
}

[System.Serializable]
public class FactionState
{
    public string factionId;
    public string factionName;
    public float influence;
    public float fearScore;
    public float power;
    public float reputation;
    public List<string> territory = new List<string>();
    public List<string> allies = new List<string>();
    public List<string> rivals = new List<string>();
    public bool atWar;
}
