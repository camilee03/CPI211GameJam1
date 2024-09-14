using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper_Sound : MonoBehaviour

{
    // Start is called before the first frame update
    private AudioSource thisAudioSource;
    public AudioClip Impact;
    public float ImpactVolume = 1f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bumper")
        {
            thisAudioSource.PlayOneShot(Impact);
            thisAudioSource.volume = ImpactVolume;
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
