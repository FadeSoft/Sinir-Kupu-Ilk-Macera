using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelkılıtmo : MonoBehaviour {
    public Button[] levellerimmoo;
    public int level_idemmmo;
    private void Start()
    {
        //PlayerPrefs.DeleteAll();

        for (int i = 1; i <= levellerimmoo.Length - 1; i++)
        {
            levellerimmoo[i].interactable = false;
        }

    }

     
     void Update()
    {
       //PlayerPrefs.DeleteAll();


        level_idemmmo = PlayerPrefs.GetInt("levelidMO");
      
        if (level_idemmmo > 0)
        {
            levellerimmoo[level_idemmmo].interactable = true;
        }
        for (int i = 0; i <= level_idemmmo; i++) 
        {
            levellerimmoo[i].interactable = true;
        }

    }
   


}
