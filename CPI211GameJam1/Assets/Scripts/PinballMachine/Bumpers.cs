using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    [SerializeField] GameObject bumperSlot;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pinball") && bumperSlot.activeInHierarchy)
        {
            bumperSlot.SetActive(false);
        }
    }
}
