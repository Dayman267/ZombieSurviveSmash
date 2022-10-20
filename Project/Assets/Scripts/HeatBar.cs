using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeatBar : MonoBehaviour
{
    public Text healthText;
    public int healthPoint = 100;
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = healthPoint.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            healthPoint -= 10;
            healthText.text = healthPoint.ToString();
        }

    }
}
