using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject bualantext;
    public GameObject emintext;
    public GameObject dogrulamatext;

    public GameObject devam1btn;
    public GameObject devam2btn;
    public GameObject devam3btn;
    public GameObject çıkısbtn;

    public GameObject alanımg1;
    public GameObject alanımg2;
    public GameObject alanımg3;

    public GameObject bualanpnl;

    public GameObject gmaıllogo;

    private const string Gmail_URL = "mailto:softwarefade@gmail.com";

    void Start()
    {
        devam1btn.SetActive(true);
        text1.SetActive(true);
    }

    public void devam1()
    {
        text1.SetActive(false);
        text2.SetActive(true);
        text3.SetActive(true);
        text4.SetActive(true);
        devam1btn.SetActive(false);
        devam2btn.SetActive(true);
        bualantext.SetActive(true);
        alanımg1.SetActive(true);
        alanımg2.SetActive(true);
        alanımg3.SetActive(true);
        bualanpnl.SetActive(true);
        emintext.SetActive(true);

    }

    public void devam2()
    {
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        devam2btn.SetActive(false);
        bualantext.SetActive(false);
        alanımg1.SetActive(false);
        alanımg2.SetActive(false);
        alanımg3.SetActive(false);
        bualanpnl.SetActive(false);
        emintext.SetActive(false);
        devam3btn.SetActive(true);
        dogrulamatext.SetActive(true);

    }
    public void devam3()
    {
        gmaıllogo.SetActive(true);

    }

    public void gmaillogobtn()
    {
        Application.OpenURL(Gmail_URL);
        çıkısbtn.SetActive(true);
    }
    public void cıkısbtntıkla()
    {
        Application.LoadLevel(1);
    }
}
