using UnityEngine;
using UnityEngine.SceneManagement;


public class EndTrigger : MonoBehaviour
{
    public int level_id;
    public Gamemanager gameManager;
    
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        level_id = PlayerPrefs.GetInt("levelid");
        
    }

    private void OnTriggerEnter(Collider other)
    {

         //PlayerPrefs.DeleteAll();
        Application.LoadLevel(2);
        level_id++;
        PlayerPrefs.SetInt("levelid", level_id);
        gameManager.CompleteLevel();
    }

   
}