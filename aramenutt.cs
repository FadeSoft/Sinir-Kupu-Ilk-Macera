using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class aramenutt : MonoBehaviour
{

    public Camera mainCamera;
    public GameObject ANIMCAMERA;
    public GameObject DEVAM1;

    public PlayerMovement playerScript;

    void OnTriggerEnter(Collider other)
    {
        playerScript.enabled = true;
        
        StartCoroutine(startCutscene());
    }

    IEnumerator startCutscene()
    {
        mainCamera.enabled = false;
        playerScript.enabled = false;
        ANIMCAMERA.SetActive(true);
        yield return new WaitForSeconds(8f);
        mainCamera.enabled = true;
        DEVAM1.SetActive(true);
        playerScript.enabled = false;
        ANIMCAMERA.SetActive(false);
        Destroy(gameObject);
    }

}