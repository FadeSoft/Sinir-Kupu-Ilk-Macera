using UnityEngine;
using UnityEngine.SceneManagement;


public class EndTriggeRHC1 : MonoBehaviour
{
    public int level_idemhhc;
    public Gamemanager gameManager;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        level_idemhhc = PlayerPrefs.GetInt("level_idemhhc");

    }

    private void OnTriggerEnter(Collider other)
    {

        //PlayerPrefs.DeleteAll();
        Application.LoadLevel(55);
        level_idemhhc++;
        PlayerPrefs.SetInt("level_idemhhc", level_idemhhc);
        gameManager.CompleteLevel();
    }


}