using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Audio : MonoBehaviour
{

  

    [SerializeField] GameObject leftFlipper;
    [SerializeField] GameObject rightFlipper;
    private AudioSource thisAudioSource;
    public AudioClip Flipper;
    public float ImpactVolume = .5f;


    private void Start()
    {
        thisAudioSource = transform.GetComponent<AudioSource>();
    }
    //play flipper sound on button push
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Flipper);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Flipper);
        }
    }

  
}
