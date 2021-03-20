using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltınToplama : MonoBehaviour
{

    public int deger;
    public Text altinmiktar;
    public int my_para;
    public GameObject parayetersiz;
    public Button[] evetbtn;
    private int i;
    public PlayerMovement playersc;
    public GameObject altınverpanel;

    public GameObject SAGhareket;
    public GameObject SOLhareket;
    public GameObject ZIPhareket;

    private void Start()
    {
        deger = PlayerPrefs.GetInt("mypara");
        altinmiktar.text = "" + deger;
       

    }

    void Update()
    {
        altinmiktar.text = "" + deger;

       
    }
    public void altıneksılt()
    {
        deger = deger - 20;
        PlayerPrefs.SetInt("mypara", deger);
    }
    private void OnTriggerEnter(Collider Altin)
    {
        if (Altin.gameObject.tag == "Altin")
        {
            deger += 5;
            PlayerPrefs.SetInt("mypara", deger);
            Destroy(Altin.gameObject);
        }
    }
    //
    private void OnCollisionEnter(Collision Obstacle)
    {
        if (Obstacle.gameObject.tag == "Obstacle")
        {        
            Destroy(Obstacle.gameObject);
        }
    }
    
    public void ellialtınverdevamet()
    {
        
        if (deger >= 50)
        {
            parayetersiz.SetActive(false);
            deger = deger - 50;
            PlayerPrefs.SetInt("mypara", deger);
            altınverpanel.SetActive(false);
            playersc.enabled = true;

            SAGhareket.SetActive(true);
            SOLhareket.SetActive(true);
            ZIPhareket.SetActive(true);



}
        else if (deger <= 50)
        {
            parayetersiz.SetActive(true);
        }

    }
}
