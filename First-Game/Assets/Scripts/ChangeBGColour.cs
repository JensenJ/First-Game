using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBGColour : MonoBehaviour {

    
    public Transform player;
    public int color = 0;
    public Color color0;
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public Color color6;
    private float colorStart = 0f;
    public float colorCooldown = 20f;

    Camera cam;

    
	// Use this for initialization
	void Start () {
        
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > colorStart + colorCooldown)
        {
            color = Random.Range(0, 7);
            ChooseColor();
            colorStart = Time.time;
            Debug.Log("ChooseColor");
        }

    }
    void ChooseColor()
    {
        RenderSettings.fog = true;
        if (color == 0)
        {
            cam.backgroundColor = color0;
            RenderSettings.fogColor = color0;
            Debug.Log("0");
        }
        else if (color == 1)
        {
            cam.backgroundColor = color1;
            RenderSettings.fogColor = color1;
            Debug.Log("1");
        }
        else if (color == 2)
        {
            cam.backgroundColor = color2;
            RenderSettings.fogColor = color2;
            Debug.Log("2");
        }
        else if (color == 3)
        {
            cam.backgroundColor = color3;
            RenderSettings.fogColor = color3;
            Debug.Log("3");
        }
        else if (color == 4)
        {
            cam.backgroundColor = color4;
            RenderSettings.fogColor = color4;
            Debug.Log("4");
        }
        else if (color == 5)
        {
            cam.backgroundColor = color5;
            RenderSettings.fogColor = color5;
            Debug.Log("5");
        }
        else if (color == 6)
        {
            cam.backgroundColor = color6;
            RenderSettings.fogColor = color6;
            Debug.Log("6");
        }
        else
        {
            cam.backgroundColor = color0;
            RenderSettings.fogColor = color0;
            Debug.Log("0");
        }
    }
}
