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
    private int numSceneSwaps = 0;
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
            if (score >= 5)
            {
                Debug.Log("HIT!");
                if (numSceneSwaps == 0)
                {
                    SceneManager.LoadScene("Lvl2Luna");
                    bumpScoreObj.setScore(0);
                }
                else if (numSceneSwaps == 1)
                {
                    SceneManager.LoadScene("Lvl3Luna");
                    bumpScoreObj.setScore(0);
                }
                else
                {
                    Debug.Log("YOU WIN!");
                }
                numSceneSwaps++;
            }
            Debug.Log("Score!");
        }
    }
}
