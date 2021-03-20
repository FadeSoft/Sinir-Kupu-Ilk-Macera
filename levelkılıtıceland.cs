using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelkılıtıceland  : MonoBehaviour {
    public Button[] levellerim;
    public int level_idem;
    private void Start()
    {
       //PlayerPrefs.DeleteAll();

        for (int i = 1; i <= levellerim.Length - 1; i++)
        {
            levellerim[i].interactable = false;
        }

    }

     
     void Update()
    {

        //PlayerPrefs.DeleteAll();

        level_idem = PlayerPrefs.GetInt("levelid");
      
        if (level_idem > 0)
        {
            levellerim[level_idem].interactable = true;
        }
        for (int i = 0; i <= level_idem;i++) 
        {
            levellerim[i].interactable = true;
        }

    }
   


}
