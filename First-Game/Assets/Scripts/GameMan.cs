using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour //Game Manager class
{

    bool gameHasEnded = false; //boolean displaying whether the game has ended or not
    public float restartDelay = 1f; //How long in seconds it takes for the game to restart

    public void EndGame()
    {
        if (gameHasEnded == false)//checking whether the game has ended
        {
        gameHasEnded = true; //the game has ended
        Invoke("Restart", restartDelay);
        
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// Restarts the level
        
    }
}
