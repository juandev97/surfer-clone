using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGround : MonoBehaviour
{
    private playerControl player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<playerControl>();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "ground")
        {
          player.grounded = true;  
        }           
    }

    private void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "ground")
        {
          player.grounded = true;  
        }      
    }

    private void OnCollisionExit(Collision other) {
        if(other.gameObject.tag == "ground")
        {
          player.grounded = false;  
        }      
    }

}
