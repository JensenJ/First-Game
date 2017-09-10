using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
    public Text highScore;

    // Update is called once per frame
    void Update()
    {
        //int number = Random.Range(1, 101);
        int number = (int)player.position.z;
        score.text = number.ToString();
    }
}
