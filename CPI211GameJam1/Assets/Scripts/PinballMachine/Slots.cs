using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Slots : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] bool debugLog;
    public Bumperscore bumpScoreObj;
    private void Update()
    {
        Debug.unityLogger.logEnabled = debugLog;
     

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT!");
        if (other.gameObject.CompareTag("Pinball"))
        {
            // Add score

            score = bumpScoreObj.getScore();
            if (score >= 25)
            {
                Debug.Log("HIT!");
                if(SceneManager.GetActiveScene().name.Equals("Level 1"))
                {
                    if(score >= 25)
                    {
                        Debug.Log("Level 1 to Level 2");
                        SceneManager.LoadScene("Level 2");
                        bumpScoreObj.setScore(0);
                    }
                    else
                    {
                        other.gameObject.SetActive(false);
                    }
                    
                }
                else if(SceneManager.GetActiveScene().name.Equals("Level 2"))
                {
                    if(score >= 50)
                    {
                        Debug.Log("Level 2 to Level 3");
                        SceneManager.LoadScene("Level 3");
                        bumpScoreObj.setScore(0);
                    }
                    else
                    {
                        other.gameObject.SetActive(false);
                    }
                }
                else
                {
                    Debug.Log("YOU WIN!");
                }
            }
            Debug.Log("Score!");
        }
    }
}
