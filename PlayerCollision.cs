using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionınfo) 
    {
        if (collisionınfo.collider.tag == "Obstacle")
        {
            
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().EndGame();
         
        }
        if (collisionınfo.collider.tag == "easteregg")
        {

            Application.LoadLevel(54);

        }
    }
}   
