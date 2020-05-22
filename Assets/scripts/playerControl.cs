using UnityEngine;

public class playerControl : MonoBehaviour {

    public int pos;
    public float jumpForce;

    public bool grounded;

    public bool jump;
    private Rigidbody rb;
    private void Start() {
        pos= 2;
        grounded = false;
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        
        switch (pos){
            
            case 1:
                transform.position =  new Vector3 (transform.position.x,transform.position.y,0.5753551f);
                break;
            case 2:
                transform.position =  new Vector3 (transform.position.x,transform.position.y,2.305355f);
                break;
            case 3:
                transform.position =  new Vector3 (transform.position.x,transform.position.y,4.05535f);
                break;

        }

        if(pos <=0)
            pos = 1;

        if(pos >=4)
            pos = 3;
        
        if(Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow)){
            pos-=1;
        }

          if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            pos+=1;
        }


        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.S)) && grounded){
            jump = true;
        }
    }

    void FixedUpdate() {
        
        if(jump){
            rb.AddForce(transform.up* jumpForce * Time.deltaTime,ForceMode.Impulse);
            jump = false;
        }
    }

   
}