using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    [Header("Prototype Setup")]
    public bool autoCreate = true;

    private void Start()
    {
        if (!autoCreate)
            return;

        if (FindObjectOfType<GameManager>() == null)
        {
            GameObject gm = new GameObject("GameManager");
            gm.AddComponent<GameManager>();
        }

        if (FindObjectOfType<CitySimulationManager>() == null)
        {
            GameObject citySim = new GameObject("CitySimulationManager");
            citySim.AddComponent<CitySimulationManager>();
        }

        if (FindObjectOfType<JobManager>() == null)
        {
            GameObject jobManager = new GameObject("JobManager");
            jobManager.AddComponent<JobManager>();
        }

        if (FindObjectOfType<StoryManager>() == null)
        {
            GameObject storyManager = new GameObject("StoryManager");
            storyManager.AddComponent<StoryManager>();
        }
    }
}
