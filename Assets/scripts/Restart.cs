using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    
    public void restartScene(){
        SceneManager.LoadScene("game");
    }
}