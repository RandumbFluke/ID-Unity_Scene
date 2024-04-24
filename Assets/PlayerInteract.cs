using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    // Shows interaction
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out NoteController noteController))
                {
                    noteController.ShowNote();
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out NoteController noteController))
                {
                    noteController.DisableNote();
                }
            }
        }
    }

    //Shows interact button
    public NoteController GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out NoteController noteController))
            {
                return noteController;
            }
        }
        return null;
    }
}
