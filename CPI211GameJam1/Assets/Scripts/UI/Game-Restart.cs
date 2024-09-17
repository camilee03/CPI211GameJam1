using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{   
    //Try Again Text UI
    GameObject tryAgain;
    //GameObject Victory;
    //lose barrier cube
    GameObject loseBarrier;
    Slots_V2 total_score;
    // Start is called before the first frame update
    void Start()
    {
        //Shows try again object UI
        tryAgain = GameObject.FindGameObjectWithTag("TryAgain");
        //Victory = GameObject.FindGameObjectWithTag("Victory");
        loseBarrier = GameObject.FindGameObjectWithTag("losebarrier");
        tryAgain.SetActive(false);

    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.CompareTag("Pinball"))
        {
            if (Slots_V2.newscore < 25)
            {
                print("Bumper Test!!");
                tryAgain.SetActive(true);
                //disappear in two frames
                Invoke("resetGame", 2f);
            }
            //resetGame();
            else if (Slots_V2.newscore >= 25)
            {
                tryAgain.SetActive(false);
                //Victory.SetActive(true);
            }
        }
       }
      
    

    void resetGame()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("Pinball") != null)  {
            if (Slots_V2.newscore < 25) // check if the total score is is less than 26, if less than 26 then restart
            {
              loseBarrier.SetActive(true);
                
            }
        }
        else if (GameObject.FindWithTag("Pinball") != null) 
        {
            if (Slots_V2.newscore >= 25) // placeholder if statement, check if the total score is more than 26, if more than 26 then set TryAgain text to false
            {
                tryAgain.SetActive(false);
            }
        }
            else {
             if (Slots_V2.newscore < 25) // check if the total score is is less than 26, if less than 26 then restart { 
                Invoke("resetGame", 2f);
                tryAgain.SetActive(true);
            }
        }
             
        
    }


