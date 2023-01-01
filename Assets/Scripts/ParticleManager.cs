using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public GameObject exploObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void explosionSpawn(Vector3 a) {
        Instantiate(exploObj, a, Quaternion.identity);
        Debug.Log("explo spawn: " + a);
    }
}
