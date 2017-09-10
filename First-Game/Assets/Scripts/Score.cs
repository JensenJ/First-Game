using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
    public Text highScore;

	// Update is called once per frame
	void Update () {
        //int number = Random.Range(1, 7);
        int number = player.position.z("0");
        score.text = number.ToString();
        

        PlayerPrefs.SetInt("HighScore", number);
	}
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore").ToString;
    }
}
