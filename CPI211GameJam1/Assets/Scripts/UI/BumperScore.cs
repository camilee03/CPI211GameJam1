using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bumperscore : MonoBehaviour
{
    Rigidbody body;
    public GameObject scoreObject;
    ScoreKeeper scoreKeeper;
    public int currentScore = 0;
    private AudioSource thisAudioSource;
    public float ImpactVolume = .5f;
    public AudioClip Impact;
    void Start()
    {

        currentScore = 0;
        thisAudioSource = transform.GetComponent<AudioSource>();
        body = GetComponent<Rigidbody>();
        if (scoreObject != null)
        {
            scoreKeeper = GetComponent<ScoreKeeper>();
        }
    }

 
   private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bumper"))
            {
            currentScore += 1;
            thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Impact);
            if (scoreObject != null)
            {
                scoreKeeper.IncrementScore();
            }   
        }
        if (currentScore == 5)
        {
            SceneManager.LoadScene(0); // NOTE: This doesn't do much yet, I need to find a way to get it to actually load scenes, but this is a good
            // proof of concept for now.
        }
    }

}
