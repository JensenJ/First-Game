using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f; //makes this option available in unity and changes the forward speed of the player
    public float directionalForce = 500f; //makes this option available in unity and changes the directional speed of the player

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force of 2000 on z axis

        if (Input.GetKey("d")) // Check for input when pressing "d"
        {
            rb.AddForce(directionalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //makes the player move right
        }
        if (Input.GetKey("a")) // Check for input when pressing "a"
        {
            rb.AddForce(-directionalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //makes the player move left
        }

        if (rb.position.y < -1) //if the player is below the map then the game ends
        {
            FindObjectOfType<GameMan>().EndGame(); //finds the game manager and ends the game
        }


    }
}
