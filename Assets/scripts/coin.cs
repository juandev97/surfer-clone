using UnityEngine;

public class coin : MonoBehaviour {
    public float speed;
    playerCount cont;
    private void Start() {
        
        cont = GameObject.FindGameObjectWithTag("Player").GetComponent<playerCount>();
    }

    private void Update() {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            cont.contador+=1;
            Destroy(this.gameObject);
        }
    }
}