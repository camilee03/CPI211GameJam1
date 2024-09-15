using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] bool debugLog;

    private void Update()
    {
        Debug.unityLogger.logEnabled = debugLog;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pinball"))
        {
            other.gameObject.SetActive(false);
            // Add score
            Debug.Log("Score!");
        }
    }
}
