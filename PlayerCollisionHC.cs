using UnityEngine;

public class PlayerCollisionHC : MonoBehaviour{

    public PlayerMovement movement;
    public GameObject hcaltınverpanel;
    public GameObject SAGhareket;
    public GameObject SOLhareket;
    public GameObject ZIPhareket;
       



    void OnCollisionEnter(Collision collisionınfo) 
    {
        if (collisionınfo.collider.tag == "Obstacle")
        {
            
            movement.enabled = false;
            SAGhareket.SetActive(false);
            SOLhareket.SetActive(false);
            ZIPhareket.SetActive(false);
            hcaltınverpanel.SetActive(true);
         
        }
    }
}   
