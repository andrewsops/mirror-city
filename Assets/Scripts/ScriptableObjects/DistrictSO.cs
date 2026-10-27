using UnityEngine;

[CreateAssetMenu(fileName = "DistrictData", menuName = "Mirror City/District")]
public class DistrictSO : ScriptableObject
{
    public string districtId;
    public string districtName;
    public float crimeLevel;
    public float policePressure;
    public float factionInfluence;
    public float marketValue;
    public float risk;
}
