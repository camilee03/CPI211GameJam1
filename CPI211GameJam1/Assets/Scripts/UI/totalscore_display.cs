using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class totalscore_display : MonoBehaviour
{

    public GameObject BumperSlot25;
    public GameObject BumperSlot50;
    public GameObject BumperSlot75;

    //Bumperscore bumpers_score;
    Slots total_score;

    TextMeshProUGUI textMeshProUGUI;


    // Start is called before the first frame update
    void Start()
    {
        if (BumperSlot25 != null)
        {
            //bumpers_score = Pinball.GetComponent<Bumperscore>();
            total_score = BumperSlot25.GetComponent<Slots>();


        }
        if (BumperSlot50 != null)
        {
            //bumpers_score = Pinball.GetComponent<Bumperscore>();
            total_score = BumperSlot50.GetComponent<Slots>();


        }
        if (BumperSlot75 != null)
        {
            //bumpers_score = Pinball.GetComponent<Bumperscore>();
            total_score = BumperSlot50.GetComponent<Slots>();


        }



        textMeshProUGUI = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        //textMeshProUGUI.text = bumpers_score.currentScore.ToString();
        textMeshProUGUI.text = Slots.newscore.ToString();
    }
}
