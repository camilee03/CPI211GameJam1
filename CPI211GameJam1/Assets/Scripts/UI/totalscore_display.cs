using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class totalscore_display : MonoBehaviour
{

    public GameObject BumperSlot_25;
    public GameObject BumperSlot_50;
    public GameObject BumperSlot_75;

    //Bumperscore bumpers_score;
    Slots_V2 total_score;

    TextMeshProUGUI textMeshProUGUI;


    // Start is called before the first frame update
    void Start()
    {
        if (BumperSlot_25 != null)
        {
            //bumpers_score = Pinball.GetComponent<Bumperscore>();
            total_score = BumperSlot_25.GetComponent<Slots_V2>();


        }
        if (BumperSlot_50 != null)
        {
            //bumpers_score = Pinball.GetComponent<Bumperscore>();
            total_score = BumperSlot_50.GetComponent<Slots_V2>();


        }
        if (BumperSlot_75 != null)
        {
            //bumpers_score = Pinball.GetComponent<Bumperscore>();
            total_score = BumperSlot_75.GetComponent<Slots_V2>();


        }



        textMeshProUGUI = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        //textMeshProUGUI.text = bumpers_score.currentScore.ToString();
        textMeshProUGUI.text = Slots_V2.newscore.ToString();
    }
}
