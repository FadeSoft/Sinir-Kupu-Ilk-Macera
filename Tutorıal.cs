using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorıal : MonoBehaviour
{
    public GameObject devam1;
    public GameObject devam2;
    public GameObject devam3;
    public GameObject tpanel;
    public GameObject tpanelhareket;
    public GameObject solhareket;
    public GameObject saghareket;
    public GameObject zıphareket;
    public GameObject altıntext;
    public GameObject altınsımge;
    public GameObject skor;
    public GameObject altınskorpanel;
    

    public PlayerMovement playerScript;

    private void Start()
    {
        

        solhareket.SetActive(false);
        saghareket.SetActive(false);
        zıphareket.SetActive(false);
        tpanelhareket.SetActive(false);
        devam2.SetActive(false);
        tpanel.SetActive(false);
        altınsımge.SetActive(false);
        altıntext.SetActive(false);
        skor.SetActive(false);
        altınskorpanel.SetActive(false);
        devam1.SetActive(false);
    }


    public void press1()
    {
        playerScript.enabled = false;
        Destroy(devam1);
        tpanel.SetActive(true);
        devam2.SetActive(true);
    }
    public void press2()
    {
        Destroy(tpanel);
        Destroy(devam2);
        solhareket.SetActive(true);
        playerScript.enabled = true;
       
    }

    public void presssol()
    {
        saghareket.SetActive(true);
    }
    public void presssag()
    {
       zıphareket.SetActive(true);
    }
    public void presszıp()
    {
        zıphareket.SetActive(true);
        tpanelhareket.SetActive(true);
        playerScript.enabled = false;
        saghareket.SetActive(false);
        solhareket.SetActive(false);
        zıphareket.SetActive(false);

    }

    public void pressdevam3()
    {
        Destroy(tpanelhareket);
        saghareket.SetActive(false);
        solhareket.SetActive(false);
        zıphareket.SetActive(false);

        altıntext.SetActive(true);
        skor.SetActive(true);
        altınsımge.SetActive(true);
        altınskorpanel.SetActive(true);

    }
    public void pressdevam33()
    {
        Destroy(altınskorpanel);
        playerScript.enabled = true;
        saghareket.SetActive(true);
        solhareket.SetActive(true);
        zıphareket.SetActive(true);
    }
    public void tutoendbuton()
    {
        Application.LoadLevel(2);
    }
}
