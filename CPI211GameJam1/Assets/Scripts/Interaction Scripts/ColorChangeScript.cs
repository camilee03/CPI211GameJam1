using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public GameObject ColorChangeObj;
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
            other.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            ColorChangeObj.SetActive(false);
        }
    }
}
