using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    GameObject tryAgain;
    GameObject loseBarrier;
    // Start is called before the first frame update
    void Start()
    {
        tryAgain = GameObject.FindGameObjectWithTag("TryAgain");
        loseBarrier = GameObject.FindGameObjectWithTag("losebarrier");
        tryAgain.SetActive(false);

    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.CompareTag("losebarrier"))
        {

            tryAgain.SetActive(true);

            Invoke("resetGame", 2f);
           
        }
       
    }
    void resetGame()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    // Update is called once per frame
    void Update()
    {

    }
}

