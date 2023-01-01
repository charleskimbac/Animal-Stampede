using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollision : MonoBehaviour
{
    public GameObject explo;


    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "animal") {
            Instantiate(explo, gameObject.transform);
        }
    }
}