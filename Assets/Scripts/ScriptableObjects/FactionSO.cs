using UnityEngine;

[CreateAssetMenu(fileName = "FactionData", menuName = "Mirror City/Faction")]
public class FactionSO : ScriptableObject
{
    public string factionId;
    public string factionName;
    public float influence;
    public float fearScore;
    public float power;
    public string[] territory;
    public string[] allies;
    public string[] rivals;
}
