using UnityEngine;
using UnityEngine.SceneManagement;


public class EndTriggeRDESERT10 : MonoBehaviour
{
    public GameObject sonpanel;
    public Gamemanager gameManager;
    public PlayerMovement hareketsc;

    public GameObject solhrkt, saghrkt, altıntext, altınımg,scoretext, drklatbtn, zıpla;
  

    private void OnTriggerEnter(Collider other)
    {
        solhrkt.SetActive(false);
        saghrkt.SetActive(false);
        altıntext.SetActive(false);
        altınımg.SetActive(false);
        zıpla.SetActive(false);
        drklatbtn.SetActive(false);
        scoretext.SetActive(false);

        sonpanel.SetActive(true);
        hareketsc.enabled = false;
        gameManager.CompleteLevel();
    }

   
}