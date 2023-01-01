using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bone;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void boneSound() {
        bone.Play(0);
    }
}
