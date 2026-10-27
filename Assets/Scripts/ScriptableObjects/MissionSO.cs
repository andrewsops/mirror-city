using UnityEngine;

[CreateAssetMenu(fileName = "MissionData", menuName = "Mirror City/Mission")]
public class MissionSO : ScriptableObject
{
    public string missionId;
    public string missionName;
    public string districtId;
    public float reward;
    public float risk;
    public string brief;
}
