using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGColour : MonoBehaviour {

    
    public Transform player;
    public Color color0 = Color.grey;
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0f;

    Camera cam;

    
	// Use this for initialization
	void Start () {
        
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
	}
	
	// Update is called once per frame
	void Update () {
        float t = Mathf.PingPong(Time.time, duration) / duration;
        if (player.transform.position.z >= 1000 && player.transform.position.z <= 1900)
        {
            cam.backgroundColor = Color.Lerp(color1, color0, duration);
            RenderSettings.fog = true;
            RenderSettings.fogColor = Color.Lerp(color1, color0, duration);

        }else if(player.transform.position.z >= 1900 && player.transform.position.z <= 2000)
        {
            cam.backgroundColor = color0;
            RenderSettings.fog = true;
            RenderSettings.fogColor = color0;
        }else if(player.transform.position.z >= 2000 && player.transform.position.z <= 2900)
        {
            cam.backgroundColor = Color.Lerp(color0, color2, duration);
            RenderSettings.fog = true;
            RenderSettings.fogColor = Color.Lerp(color0, color2, duration);
        }

    }
}
