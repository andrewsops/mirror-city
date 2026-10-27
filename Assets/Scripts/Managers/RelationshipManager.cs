using System.Collections.Generic;
using UnityEngine;

public class RelationshipManager : MonoBehaviour
{
    private Dictionary<string, RelationshipState> relationships = new Dictionary<string, RelationshipState>();

    public void AddOrUpdateRelationship(string npcId, RelationshipState relationship)
    {
        relationships[npcId] = relationship;
    }

    public RelationshipState GetRelationship(string npcId)
    {
        if (relationships.ContainsKey(npcId))
            return relationships[npcId];

        return new RelationshipState(npcId);
    }

    public void AdjustTrust(string npcId, float delta)
    {
        RelationshipState state = GetRelationship(npcId);
        state.trust = Mathf.Clamp(state.trust + delta, -100f, 100f);
        relationships[npcId] = state;
    }

    public void AdjustFear(string npcId, float delta)
    {
        RelationshipState state = GetRelationship(npcId);
        state.fear = Mathf.Clamp(state.fear + delta, -100f, 100f);
        relationships[npcId] = state;
    }

    public Dictionary<string, RelationshipState> GetAllRelationships()
    {
        return relationships;
    }
}
