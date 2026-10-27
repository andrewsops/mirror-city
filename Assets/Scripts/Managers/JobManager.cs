using System.Collections.Generic;
using UnityEngine;

public class JobManager : MonoBehaviour
{
    public List<JobDefinition> jobs = new List<JobDefinition>();

    private void Start()
    {
        jobs.Add(new JobDefinition
        {
            id = "job_deliver_01",
            name = "Night Courier",
            districtId = "District_01",
            reward = 120f,
            risk = 15f,
            type = "Delivery",
            description = "Deliver a package through the Market Ward before midnight."
        });

        jobs.Add(new JobDefinition
        {
            id = "job_favor_01",
            name = "Small Favor",
            districtId = "District_01",
            reward = 80f,
            risk = 8f,
            type = "Favor",
            description = "Help a contact and keep the route quiet."
        });
    }

    public JobDefinition GetAvailableJob(string districtId)
    {
        foreach (var job in jobs)
        {
            if (job.districtId == districtId && !job.completed)
                return job;
        }

        return null;
    }

    public void CompleteJob(string jobId)
    {
        foreach (var job in jobs)
        {
            if (job.id == jobId)
            {
                job.completed = true;
                Debug.Log("Job complete: " + job.name);
                return;
            }
        }
    }
}

[System.Serializable]
public class JobDefinition
{
    public string id;
    public string name;
    public string districtId;
    public string type;
    public string description;
    public float reward;
    public float risk;
    public bool completed;
}
