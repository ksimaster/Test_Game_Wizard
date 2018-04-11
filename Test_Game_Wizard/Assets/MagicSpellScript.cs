using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSpellScript : MonoBehaviour
{
    public Rigidbody fireArrow;
    public Rigidbody fireball;

    public float FireSpeed = 10f;
    public float ArrowSpeed = 15f;

    public GUI Gui_Panel;
    public bool panelOn = false;

   /* private void Awake()
    {
        // находим источник света
        Gui_Panel = GetComponent<GUI>();

        if (!panelOn) //изначальное состояние фонарика
        {
            Gui_Panel. = false;
        }
        else
        {
            Gui_Panel.enabled = true;
        }
    } */

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            FireBall();
            
        }

        if (Input.GetButtonDown("Fire1"))
        {
            FireArrow();

        }

    /*    if (Input.GetButtonDown("Fire3"))
        {
            FireArrow();

        } */

    }

   public void FireBall()
    {
        Rigidbody fireballClone = (Rigidbody)Instantiate(fireball, transform.position, transform.rotation);
        fireballClone.velocity = transform.forward * FireSpeed;
       
    }

  /*  public void CallPanel()
    {
        
        if (!panelOn)
        {
            Gui_Panel.enabled = true; // вызываем панель 
            panelOn = true;
        }
        else
        {
            Gui_Panel.enabled = false; // убираем панель

            panelOn = false;
        }

    } */

    public void FireArrow()
    {
        Rigidbody fireArrowClone = (Rigidbody)Instantiate(fireArrow, transform.position, transform.rotation);
        fireArrowClone.velocity = transform.forward * ArrowSpeed;
        
        
    }
    

}