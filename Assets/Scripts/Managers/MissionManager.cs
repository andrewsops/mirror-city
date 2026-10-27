using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public MissionState currentMission;

    public void StartMission(MissionState mission)
    {
        currentMission = mission;
        currentMission.status = MissionStatus.Active;
        Debug.Log("Mission started: " + mission.missionName);
    }

    public void CompleteMission()
    {
        if (currentMission == null)
            return;

        currentMission.status = MissionStatus.Completed;
        Debug.Log("Mission completed: " + currentMission.missionName);
    }
}

[System.Serializable]
public class MissionState
{
    public string missionId;
    public string missionName;
    public string districtId;
    public float reward;
    public float risk;
    public MissionStatus status = MissionStatus.Available;
}

public enum MissionStatus
{
    None,
    Available,
    Active,
    Failed,
    Completed,
    Abandoned
}
