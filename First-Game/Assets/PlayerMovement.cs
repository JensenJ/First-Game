using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float directionalForce = 500f;

	// Use this for initialization
	void Start () {
        Debug.Log("Started Player Initialization");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force of 2000 on z axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(directionalForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-directionalForce * Time.deltaTime, 0, 0);
        }



    }
}
