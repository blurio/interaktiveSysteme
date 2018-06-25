using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DangerImage : MonoBehaviour
{

    private RawImage danger;
    int air;



    private float nextActionTime = 0.0f;
    public float period = 1.0f;

	// Use this for initialization
	void Start()
	{
        danger = GetComponent<RawImage>();
        air = 100;
        danger.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            air -= 1;
        }

        if (air < 25)
        {
            danger.enabled = true;
        } else
        {
            danger.enabled = false;
        }
        if (Input.GetKeyDown("r"))
        {
            air = 100;
        }
	}
}
