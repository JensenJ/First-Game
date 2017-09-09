using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player; //allows the player object to communicate with the camera
    public Vector3 offset; //makes this option available in unity and is how far the camera is behind the player

    // Update is called once per frame
    void Update () {
        transform.position = player.position + offset; //makes the camera follow the player, no matter where it is the editor
	}
}
