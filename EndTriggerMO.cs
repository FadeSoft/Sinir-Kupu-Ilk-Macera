using UnityEngine;
using UnityEngine.SceneManagement;


public class EndTriggerMO : MonoBehaviour
{
    public int level_idMO;
    public Gamemanager gameManager;
    
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        level_idMO = PlayerPrefs.GetInt("levelidMO");
        
    }

    private void OnTriggerEnter(Collider other)
    {

        //PlayerPrefs.DeleteAll();

        Application.LoadLevel(53);
        level_idMO++;
        PlayerPrefs.SetInt("levelidMO", level_idMO);
        gameManager.CompleteLevel();
    }

   
}