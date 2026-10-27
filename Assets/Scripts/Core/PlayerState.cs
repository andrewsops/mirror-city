using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerState
{
    public float health = 100f;
    public float stamina = 100f;
    public float hunger = 100f;
    public float stress = 0f;
    public float fear = 0f;

    public float cash = 500f;
    public float debt = 0f;
    public float rentDue = 800f;
    public float reputation = 0f;
    public float heat = 0f;
    public string homeId = "Home_01";
    public string currentDistrictId = "District_01";

    public Dictionary<string, RelationshipState> relationships = new Dictionary<string, RelationshipState>();
    public List<string> knownRoutes = new List<string>();
    public List<string> factionTags = new List<string>();
    public List<string> discoveredIntel = new List<string>();
}
