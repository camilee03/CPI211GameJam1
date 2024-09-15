using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperActivater : MonoBehaviour
{
    [SerializeField] Vector3 deltaRotation = new Vector3(0, 1000000f, 0);

    [SerializeField] GameObject leftFlipper;
    [SerializeField] GameObject rightFlipper;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) { ActivateRightFlipper(); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { ActivateLeftFlipper(); }
    }

    public void ActivateRightFlipper()
    {
        rightFlipper.GetComponent<Rigidbody>().AddTorque(deltaRotation);
    }
    public void ActivateLeftFlipper() 
    {
        leftFlipper.GetComponent<Rigidbody>().AddTorque(-deltaRotation);
    }
}
