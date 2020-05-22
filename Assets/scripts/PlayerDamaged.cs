using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDamaged : MonoBehaviour {
    private void Start() {
        
    }
    private void Update() {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "dmg"){
            SceneManager.LoadScene("Game over 1");
        }
    }
}