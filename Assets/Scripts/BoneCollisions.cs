using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCollisions : MonoBehaviour
{

    public AudioManager AM;
    //public GameObject explo;
    public ParticleManager PM;

    // Start is called before the first frame update
    void Awake()
    {
        AM = GameObject.FindObjectOfType<AudioManager>();
        PM = GameObject.FindObjectOfType<ParticleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "animal") {
            PM.explosionSpawn(gameObject.transform.position);
            AM.boneSound();
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("detected/hit");
        }
    }
}
