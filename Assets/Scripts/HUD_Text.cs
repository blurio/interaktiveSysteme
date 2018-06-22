using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD_Text : MonoBehaviour {

    Text text;
    int air;
    //int divingTime;
    Time time;
    float timer;
    string divingTime;
    int seconds;
    int minutes;


    private float nextActionTime = 0.0f;
    public float period = 1.0f;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        timer = 0;
        air = 100;
   	}

    
	
	// Update is called once per frame
	void Update () {
        
        timer += Time.deltaTime;
        seconds = (int)timer % 60;
        minutes = (int)timer / 60;

        divingTime = minutes + ":" + seconds;

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            air -= 1;
        }

        if (Input.GetKeyDown("r")){
            air = 100;
            timer = 0;
        }

        text.text = "depth: 3.2m \n pressure: 0.35bar \n air: " + air 
            + "% \n time: " + divingTime;
	}
}
