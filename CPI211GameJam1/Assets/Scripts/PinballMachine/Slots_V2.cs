using System.Collections;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Slots_V2 : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] bool debugLog;
    private AudioSource thisAudioSource;
    GameObject vicObj;
    static public int  newscore = 0;
    public AudioClip Impact;
    public float ImpactVolume = .5f;
    public Bumperscore bumpScoreObj;
    private void Start()
    {
        vicObj = GameObject.FindGameObjectWithTag("Victory");
        newscore = 0;
        thisAudioSource = transform.GetComponent<AudioSource>();
    }
    private void Update()
    {
        Debug.unityLogger.logEnabled = debugLog;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pinball"))
        {
            thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Impact);
            newscore = Bumperscore.currentScore + score;
            bumpScoreObj.setScore(newscore);
            Debug.Log("Score!");

            score = bumpScoreObj.getScore();
            if (score >= 25)
            {
                Debug.Log("HIT!");
                if (SceneManager.GetActiveScene().name.Equals("Level 1"))
                {
                    if (score >= 25)
                    {
                        Debug.Log("Level 1 to Level 2");
                        vicObj.SetActive(true);
                        SceneManager.LoadScene(1);
                        bumpScoreObj.setScore(0);
                    }
                    else
                    {
                        Debug.Log("Redo");
                        other.gameObject.SetActive(false);
                    }
                }
                if (SceneManager.GetActiveScene().name.Equals("Level 2"))
                {
                    if (score >= 10)
                    {
                        Debug.Log("Level 2 to Level 3");
                        vicObj.SetActive(true);
                        SceneManager.LoadScene(2);
                        bumpScoreObj.setScore(0);
                    }
                    else
                    {
                        Debug.Log("Redo");
                        other.gameObject.SetActive(false);
                    }
                }
                else
                {
                    if(score >= 75)
                    {
                        vicObj.SetActive(true);
                        Debug.Log("YOU WIN!");
                    }
                    else
                    {
                        other.gameObject.SetActive(false);
                    }
                }
            }
            Debug.Log("Score!");
        }
            // Add score
            //other.gameObject.SetActive(false);
            /*thisAudioSource.volume = ImpactVolume;
            thisAudioSource.PlayOneShot(Impact);
            newscore = Bumperscore.currentScore + score;
            bumpScoreObj.setScore(newscore);
            Debug.Log("Score!");
        }*/
    }
}
