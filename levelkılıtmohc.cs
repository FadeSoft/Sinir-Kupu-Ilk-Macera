using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelkılıtmohc : MonoBehaviour {
    public Button[] levellerimhcc;
    public int level_idemhhc;
    private void Start()
    {
       //PlayerPrefs.DeleteAll();

        for (int i = 1; i <= levellerimhcc.Length - 1; i++)
        {
            levellerimhcc[i].interactable = false;
        }

    }

     
     void Update()
    {
       //PlayerPrefs.DeleteAll();


        level_idemhhc = PlayerPrefs.GetInt("level_idemhhc");
      
        if (level_idemhhc > 0)
        {
            levellerimhcc[level_idemhhc].interactable = true;
        }
        for (int i = 0; i <= level_idemhhc; i++) 
        {
            levellerimhcc[i].interactable = true;
        }

    }
   


}
