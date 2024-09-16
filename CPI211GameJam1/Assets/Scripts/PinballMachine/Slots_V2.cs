using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots_V2 : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] bool debugLog;
    private AudioSource thisAudioSource;
    static public int  newscore = 0;
    public AudioClip Impact;
    public float ImpactVolume = .5f;
    private void Start()
    {

        newscore = 0;
        thisAudioSource = transform.GetComponent<AudioSource>();
    }
    private void Update()
    {
        Debug.unityLogger.logEnabled = debugLog;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Pinball")
        {

            // Add score
            other.gameObject.SetActive(false);
            thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Impact);
            newscore = Bumperscore.currentScore + score;
            Debug.Log("Score!");
        }
    }
}
