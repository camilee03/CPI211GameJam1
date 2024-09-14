using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_display : MonoBehaviour
{

    public GameObject Pinball;
    Bumperscore bumpers_score;
    TextMeshProUGUI textMeshProUGUI;


    // Start is called before the first frame update
    void Start()
    {
        if (Pinball != null)
        {
            bumpers_score = Pinball.GetComponent<Bumperscore>();
        }


        textMeshProUGUI = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = bumpers_score.currentScore.ToString();
    }
}
