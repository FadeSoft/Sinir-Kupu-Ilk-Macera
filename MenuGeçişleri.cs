using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGeçişleri : MonoBehaviour {


    public GameObject Panel1;
    public void ShowHidePanel(bool status)
    {
        Panel1.gameObject.SetActive(status);
    }

    public void PauseResumeGame()
    {
        bool durum = Time.timeScale == 0;
        ShowHidePanel(!durum);
        if (durum)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
   
}
		

