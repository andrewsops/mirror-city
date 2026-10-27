using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Interaction")]
    public float interactionRadius = 2.5f;
    public LayerMask interactionLayer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }

    private void TryInteract()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, interactionRadius, interactionLayer);

        if (hits.Length == 0)
        {
            Debug.Log("No interactable object nearby.");
            return;
        }

        Collider closest = hits[0];
        IInteractable interactable = closest.GetComponent<IInteractable>();

        if (interactable != null)
        {
            interactable.Interact();
        }
    }
}

public interface IInteractable
{
    void Interact();
}
