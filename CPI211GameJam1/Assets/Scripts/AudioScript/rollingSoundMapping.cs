using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollingSoundMapping : MonoBehaviour
{
    public GameObject rollingBallPlayer;
    public float maxVelocity = 2f;
    private Rigidbody rollingBallPlayerBody;
    private AudioSource rollingAudio;
    public AnimationCurve thisCurve;
    // Start is called before the first frame update
    void Start()
    {
        rollingAudio = transform.GetComponent<AudioSource>();


        rollingAudio.volume = -10f;

        rollingBallPlayerBody = rollingBallPlayer.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector3 allSpeed = rollingBallPlayerBody.velocity;
        Vector2 flatSpeed = new Vector2(allSpeed.x, allSpeed.z);
        float speed = Mathf.Abs(flatSpeed.magnitude);
        
        float normalizedSpeed = Mathf.InverseLerp(0, maxVelocity, speed);
        
        rollingAudio.volume = thisCurve.Evaluate(normalizedSpeed);
        
    }
}
