using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScore : MonoBehaviour
{
    Rigidbody rb;
    Bumperscore bumperscore;
    public GameObject Pinball;
    public int current_slotscore = 0;
   

    // Start is called before the first frame update
    public void Start()
    {
        current_slotscore = Bumperscore.currentScore;
        rb = GetComponent<Rigidbody>();
       




    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bumperslot"))
        {

            
            //print("scores");

            // Add score
            print(current_slotscore);

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

    


