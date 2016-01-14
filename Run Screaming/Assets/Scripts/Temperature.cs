﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Temperature : MonoBehaviour
{
    float timer = 0;
    float end = 60;
    int temperature = 7;
    int threashold = 15;

    void Start()
    {
        
    }
 
    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnGUI()
    {


            int newTemperature = temperature + (int)(timer / threashold);
            GUI.Label(new Rect(20, 20, 200, 100),
                                    "Beer temperature: " + newTemperature + "°C");
        

        if (newTemperature > 15)
        {
            SceneManager.LoadScene("lose");
        }
    }
}