using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperActivater : MonoBehaviour
{
    
    Vector3 deltaRotation = new Vector3(0, 10f, 0);

    [SerializeField] GameObject leftFlipper;
    [SerializeField] GameObject rightFlipper;

    [SerializeField] bool debugLog;
    bool maxRRotate = true;
    bool minRRotate = true;
    bool minLRotate = true;
    bool maxLRotate = true;



    private void Update()
    {
        Debug.unityLogger.logEnabled = debugLog;

        if (Input.GetKeyDown(KeyCode.RightArrow)) { ActivateFlipper(rightFlipper, deltaRotation); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { ActivateFlipper(leftFlipper, -deltaRotation); }

        ClampRightRotation(210, 150);
        ClampLeftRotation(70, -40);
    }

    public void ActivateFlipper(GameObject flipper, Vector3 rotation)
    {
        flipper.GetComponent<Rigidbody>().AddTorque(rotation, ForceMode.Impulse);
    }
    
    // Prevents the object from rotating beyond a certain point
    public void ClampLeftRotation(float maxRotation, float minRotation)
    {
        Vector3 currentRotation = leftFlipper.transform.rotation.eulerAngles;

        Vector3 speed = leftFlipper.GetComponentInChildren<Rigidbody>().angularVelocity;

        // clamps top rotation
        if (currentRotation.y >= maxRotation && maxLRotate)
        {
            leftFlipper.GetComponent<Rigidbody>().AddTorque(-speed/10, ForceMode.Impulse);
            maxLRotate = false;
            StartCoroutine(TimerLMax());
            Debug.Log("L Rotate R");
        }
        // clamps min rotation
        if (currentRotation.y <= minRotation && minLRotate)
        {
            leftFlipper.GetComponent<Rigidbody>().AddTorque(-speed/10, ForceMode.Impulse);
            minLRotate = false;
            StartCoroutine(TimerLMin());
            Debug.Log("L Rotate L");
        }
    }
    public void ClampRightRotation(float maxRotation, float minRotation)
    {
        Vector3 currentRotation = rightFlipper.transform.rotation.eulerAngles;

        Vector3 speed = rightFlipper.GetComponentInChildren<Rigidbody>().angularVelocity;

        // clamps top rotation
        if (currentRotation.y >= maxRotation && maxRRotate)
        {
            rightFlipper.GetComponent<Rigidbody>().AddTorque(-speed / 10, ForceMode.Impulse);
            maxRRotate = false;
            StartCoroutine(TimerRMax());
            Debug.Log("R Rotate L");
        }
        // calmps bottom rotation
        if (currentRotation.y <= minRotation && minRRotate)
        {
            rightFlipper.GetComponent<Rigidbody>().AddTorque(-speed / 10, ForceMode.Impulse);
            minRRotate = false;
            StartCoroutine(TimerRMin());
            Debug.Log("R Rotate R");
        }
    }

    IEnumerator TimerLMin()
    {
        yield return new WaitForSeconds(0.1f);
        minLRotate = true;
    }
    IEnumerator TimerLMax()
    {
        yield return new WaitForSeconds(0.1f);
        maxLRotate = true;
    }
    IEnumerator TimerRMin()
    {
        yield return new WaitForSeconds(0.1f);
        minRRotate = true;
    }
    IEnumerator TimerRMax()
    {
        yield return new WaitForSeconds(0.1f);
        maxRRotate = true;
    }
}
