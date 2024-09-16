using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots_V2 : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] bool debugLog;
    static public int  newscore = 0;
    private void Start()
    {

        newscore = 0;
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

            newscore = Bumperscore.currentScore + score;
            Debug.Log("Score!");
        }
    }
}
