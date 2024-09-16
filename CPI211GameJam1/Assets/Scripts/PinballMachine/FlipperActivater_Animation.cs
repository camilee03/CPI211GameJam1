using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperActivater_Animation : MonoBehaviour
{
    Animator animator_left;
    Animator animator_right;
    public AnimationClip animationClip ;
    [SerializeField] Vector3 deltaRotation = new Vector3(0, 1000000f, 0);

    [SerializeField] GameObject leftFlipper;
    [SerializeField] GameObject rightFlipper;

    private void Start()
    {
        //animator_left = leftFlipper.GetComponent<Animator>();
        //animator_right = leftFlipper.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) { rightFlipper.GetComponent<Animator>().Play("Right Flipper", -1, 0f); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { leftFlipper.GetComponent<Animator>().Play("Left Flipper", -1, 0f); }
    }

    public void ActivateRightFlipper_anim()
    {
  
        //animator_right.Play(animationClip.name, -1, 0f);
        rightFlipper.GetComponent<Rigidbody>().AddTorque(deltaRotation);
        
    }
    public void ActivateLeftFlipper_anim()
    {
        
        leftFlipper.GetComponent<Rigidbody>().AddTorque(-deltaRotation);
        

    }
}
