using UnityEngine;

public class ground : MonoBehaviour {
    public GameObject piso;
    public GameObject pasto;
    
    Vector3 PastoInicial;
    Vector3 PisoInicial;
    private void Start() {
        PisoInicial = piso.transform.position;
        PastoInicial = pasto.transform.position;
        
    }

    private void Update() {
        
        
    }

private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            piso.transform.position = PisoInicial;
            pasto.transform.position = PastoInicial;
            
        }
    }
}