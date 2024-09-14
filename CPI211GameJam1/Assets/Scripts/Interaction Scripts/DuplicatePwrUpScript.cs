using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicatePwrUpScript : MonoBehaviour
{
    public GameObject DupBallPwrUpObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pinball"))
        {
            for(int i = 0; i < 1; i++)
            {
                Instantiate(other.gameObject);
            }
            
            DupBallPwrUpObj.SetActive(false);
        }
    }
}
