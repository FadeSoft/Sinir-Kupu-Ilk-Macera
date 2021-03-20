using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorıalend : MonoBehaviour
{
    public GameObject tutorıalendpanel;
    public Gamemanager gameManager;
    public PlayerMovement playerScript;
    private void OnTriggerEnter(Collider other)
    {
        tutorıalendpanel.SetActive(true);
        playerScript.enabled = false;
        
        gameManager.CompleteLevel();
    }
}
