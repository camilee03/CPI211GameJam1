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
            other.gameObject.SetActive(false);
            score = bumpScoreObj.getScore();
            if (score >= 1)
            {
                Debug.Log("HIT!");
                if(SceneManager.GetActiveScene().name.Equals("Lvl1Luna"))
                {
                    Debug.Log("Level 1 to Level 2");
                    SceneManager.LoadScene("Lvl2Luna");
                    bumpScoreObj.setScore(0);
                }
                else if(SceneManager.GetActiveScene().name.Equals("Lvl2Luna"))
                {
                    Debug.Log("Level 2 to Level 3");
                    SceneManager.LoadScene("Lvl3Luna");
                    bumpScoreObj.setScore(0);
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
