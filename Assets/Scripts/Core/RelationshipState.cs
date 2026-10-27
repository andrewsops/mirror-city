using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RelationshipState
{
    public string npcId;
    public float trust;
    public float fear;
    public float loyalty;
    public float respect;
    public float leverage;
    public bool isFamily;
    public bool isRomantic;
    public bool isContact;
    public bool isEnemy;

    public RelationshipState(string id)
    {
        npcId = id;
        trust = 0f;
        fear = 0f;
        loyalty = 0f;
        respect = 0f;
        leverage = 0f;
    }
}
