using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSphereWind : MonoBehaviour {

    Light AreaLightWind;
    public bool lightOn = false;

    private void Awake()
    {
        // находим источник света
        AreaLightWind = GetComponent<Light>();

        if (!lightOn) //изначальное состояние фонарика
        {
            AreaLightWind.enabled = false;
        }
        else
        {
            AreaLightWind.enabled = true;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) // включение если нажата клавиша F
        {
            if (!lightOn)
            {
                AreaLightWind.enabled = true; // меняем интенсивность свечения на 1 (то есть светит) 
                lightOn = true;
            }
            else
            {
                AreaLightWind.enabled = false; // убираем интенсивность до нуля (не светит)

                lightOn = false;
            }


        }

    }
}