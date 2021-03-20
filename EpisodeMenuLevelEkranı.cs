using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpisodeMenuLevelEkranı : MonoBehaviour
{
    public GameObject BUZPANEL;
    public GameObject SPACEPANEL;
    public GameObject FORESTPANEL;
    public GameObject DESERTPANEL;

    
    public void ıcelandgec()
    {
        SPACEPANEL.SetActive(false);
        FORESTPANEL.SetActive(false);
        DESERTPANEL.SetActive(false);
        BUZPANEL.SetActive(true);

    }
    public void spacegec()
    {
        BUZPANEL.SetActive(false);
        FORESTPANEL.SetActive(false);
        DESERTPANEL.SetActive(false);
        SPACEPANEL.SetActive(true);
    }

    public void forestgeç()
    {
        BUZPANEL.SetActive(false);
        SPACEPANEL.SetActive(false);
        DESERTPANEL.SetActive(false);
        FORESTPANEL.SetActive(true);
    }
    public void desertgeç()
    {
        BUZPANEL.SetActive(false);
        SPACEPANEL.SetActive(false);
        FORESTPANEL.SetActive(false);
        DESERTPANEL.SetActive(true);
    }
}
