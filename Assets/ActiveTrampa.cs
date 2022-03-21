using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTrampa : MonoBehaviour
{
    public GameObject activarTrampa;
    public Rigidbody Obstaculo;

        
    void OnTriggerEnter (Collider other){
        if (other.gameObject.tag == "Hero"){
            Obstaculo.GetComponent<Rigidbody> ().useGravity = true;

        }

    }
}
