using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumperscore : MonoBehaviour
{
    Rigidbody body;
    public GameObject scoreObject;
    ScoreKeeper scoreKeeper;
    public int currentScore = 0;

    void Start()
    {

        currentScore = 0;

        body = GetComponent<Rigidbody>();
        if (scoreObject != null)
        {
            scoreKeeper = GetComponent<ScoreKeeper>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Pinball")
        {
            currentScore += 1;
            if (scoreObject != null)
            {
                scoreKeeper.IncrementScore();
            }
        }
    }
}
