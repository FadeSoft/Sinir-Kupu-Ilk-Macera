using UnityEngine;
using UnityEngine.SceneManagement;


public class EndTriggeRhc2 : MonoBehaviour
{
    public Gamemanager gameManager;

    
    private void OnTriggerEnter(Collider other)
    {

     
        Application.LoadLevel(55);
      
        gameManager.CompleteLevel();
    }


}