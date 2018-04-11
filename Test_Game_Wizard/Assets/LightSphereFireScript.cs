using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSphereFireScript : MonoBehaviour {
    Light AreaLightFire;
    public bool lightOn = false;

    private void Awake()
    {
        // находим источник света
        AreaLightFire = GetComponent<Light>();

        if (!lightOn) //изначальное состояние фонарика
        {
            AreaLightFire.enabled = false;
        }
        else
        {
            AreaLightFire.enabled = true;
        }
    }


    void Update () {
        if (Input.GetKeyDown(KeyCode.F)) // включение если нажата клавиша F
        {
            if (!lightOn) 
            {
                AreaLightFire.enabled = true; // меняем интенсивность свечения на 1 (то есть светит) 
                lightOn = true;
            }
            else
            {
                AreaLightFire.enabled = false; // убираем интенсивность до нуля (не светит)

                lightOn = false;
            }


        }
            
    }
}
