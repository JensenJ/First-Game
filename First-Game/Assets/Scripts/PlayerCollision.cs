using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement;
    

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")//if anything with the tag "Obstacle" is it, the game ends
        {
        
            movement.enabled = false; //Disables movement
            FindObjectOfType<GameMan>().EndGame();//Locates the game manager and calls the endgame function
            
        }
    }
}