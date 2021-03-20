using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class AraSahne : MonoBehaviour
{

    public Camera mainCamera;
    public GameObject ANIMCAMERA;
  

    public PlayerMovement playerScript;

    void OnTriggerEnter(Collider other)
    {
        
        StartCoroutine(startCutscene());
    }

    IEnumerator startCutscene()
    {
        mainCamera.enabled = false;
        playerScript.enabled = false;
        ANIMCAMERA.SetActive(true);
        yield return new WaitForSeconds(8f);
        mainCamera.enabled = true;
      
        playerScript.enabled = true;
        ANIMCAMERA.SetActive(false);
        Destroy(gameObject);
    }

}