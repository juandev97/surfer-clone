using UnityEngine;

public class TrenSpawner : MonoBehaviour {
   
    public GameObject tren;
    public float x,y,z;
    public GameObject Coins1;
    public GameObject Coins2;
    public Transform[] spawners;
    private void Start() {
          InvokeRepeating("SaleTren",.3f,.74f);
    }


    void SaleTren(){
        int random;
        random = Random.Range(0,spawners.Length);
        GameObject clone =Instantiate(tren,spawners[random].position,Quaternion.identity);

        // lleva monedas?
        int monedasR = Random.Range(1,6);
        GameObject cloneMoneda;
        switch (monedasR){
            case 1:
                cloneMoneda =Instantiate(Coins1,spawners[random].position+ new Vector3(x,y,z),Quaternion.identity);
                break;
            case 2:
                cloneMoneda =Instantiate(Coins2,spawners[random].position + new Vector3(x,y,z),Quaternion.identity);
                break;
            default:
                break;
           
        }
        Destroy(clone.gameObject,4f);
    }
    
}