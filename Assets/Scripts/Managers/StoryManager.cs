using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public List<StoryBeat> storyBeats = new List<StoryBeat>();

    private void Start()
    {
        storyBeats.Add(new StoryBeat
        {
            id = "intro_01",
            title = "The first job",
            description = "You need money and a local contact offers a quick delivery. The route runs through the Market Ward."
        });

        storyBeats.Add(new StoryBeat
        {
            id = "intro_02",
            title = "The hidden city",
            description = "You discover the route is controlled by a faction with its own rules and a deeper network beneath the streets."
        });
    }

    public StoryBeat GetCurrentBeat()
    {
        if (storyBeats.Count == 0)
            return null;

        return storyBeats[0];
    }
}

[System.Serializable]
public class StoryBeat
{
    public string id;
    public string title;
    public string description;
}
