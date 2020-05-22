using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerCount : MonoBehaviour {
    public float contador;
    public Text txt;
    private void Start() {
        contador=0;
    }

    private void Update() {
        txt.text = contador+"";

    if(contador >= 40){
        SceneManager.LoadScene("Win");
    }
    }
}