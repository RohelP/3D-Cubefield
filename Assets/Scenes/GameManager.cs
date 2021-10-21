using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Start is called before the first frame update
    public float RestartDelay = 1f;
    public GameObject UILEVEL;
    public void CompleteLevel ()
    {
        UILEVEL.SetActive(true);
        Debug.Log("Level Complete");
    }
    public void EndGame()
    {
            Debug.Log("Game Over");
            Invoke("Restart", RestartDelay);
        
    }
        void Restart()
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}