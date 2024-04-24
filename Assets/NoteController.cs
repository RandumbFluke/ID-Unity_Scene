using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class NoteController : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] public KeyCode closeKey;

    [Header("UI Text")]
    [SerializeField] private GameObject noteCanvas;

    [Space(10)]
    [SerializeField] private AnimationAndMovementController player;

    [Space(10)]
    [SerializeField] private UnityEvent openEvent;
    private bool isOpen = false;


    public void ShowNote()
    {
        noteCanvas.SetActive(true);
        openEvent.Invoke();
        DisablePlayer (true);
        isOpen = true;
    }

    public void DisableNote()
    {
        noteCanvas.SetActive(false);
        DisablePlayer(false);
        isOpen = false;
    }

    void DisablePlayer(bool disable)
    {
        player.enabled = !disable;
    }

    private void Update()
    {
        if (!isOpen)
        {
            if (Input.GetKeyDown(closeKey)) 
            {
                DisableNote();
            }
        }
    }
}
