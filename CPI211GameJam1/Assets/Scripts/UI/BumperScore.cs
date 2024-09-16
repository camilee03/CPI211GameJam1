using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
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
    GameObject loseBarrier;
    GameObject tryAgain;

    void Start()
    {
       currentScore = 0;
        thisAudioSource = transform.GetComponent<AudioSource>();
        body = GetComponent<Rigidbody>();
     
       

    }

    public int getScore()
    {
        return currentScore;
    }

    public int setScore(int pScore) 
    { 
        return currentScore = pScore; 
    }

private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bumper"))
            {
            currentScore += 1;
            thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Impact);
            // if (scoreObject != null)

              // {
               // scoreKeeper.IncrementScore();
            //}
        


           


        }
    }
}



