using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculo : MonoBehaviour{
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag=="Hero") {
            Debug.Log("Game Over");
            Destroy(collision.gameObject);
        }
        
    }
}
