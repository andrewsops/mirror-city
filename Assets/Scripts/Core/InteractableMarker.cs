using UnityEngine;

public class InteractableMarker : MonoBehaviour, IInteractable
{
    public string displayName = "Marker";
    public string interactionText = "Press E to interact.";

    public void Interact()
    {
        Debug.Log("Interacted with: " + displayName);
    }
}
