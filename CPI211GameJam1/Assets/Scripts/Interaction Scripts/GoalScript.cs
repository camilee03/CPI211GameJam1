using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject GoalCylinder;
    // Start is called before the first frame update
    void Start()
    {
        GoalCylinder = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider ballCollide)
    {
        GoalCylinder.SetActive(false);
    }
}
