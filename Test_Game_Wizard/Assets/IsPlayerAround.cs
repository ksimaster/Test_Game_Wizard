using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerAround : MonoBehaviour {

    public GameObject Obj;
    public string NameAnimationLookPlayer;
    public string NameAnimationRun;
    public string NameAnimationBattle;
    public Collider col0;
   // public Collider col1;
   // public Collider col2;
    public Transform target;
    public float speedEnemy = 0.3f;
    //Rigidbody rbEnemy;
    // Use this for initialization
    void Start () {
        //rbEnemy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (col0.tag == "Player")
        {

            transform.LookAt(target); // враг смотрит на игрока (target)
            Obj.GetComponent<Animation>().Play(NameAnimationLookPlayer);
           // Debug.Log("IsTrigger LookPlayer well done");




        }
    }
    void FixedUpdate () {
        
        if ((System.Math.Abs(transform.position.x - target.position.x) <= 0.7f) || (System.Math.Abs(transform.position.z - target.position.z) <= 0.7f))
            {
                transform.LookAt(target);
                transform.position = Vector3.Lerp(transform.position, target.position, -speedEnemy * Time.deltaTime);
                Obj.GetComponent<Animation>().Play(NameAnimationBattle);
               // Debug.Log("IsTrigger Battle well done");
        }
        else
        {
            if (((System.Math.Abs(transform.position.x - target.position.x) < 5f) /* && (System.Math.Abs(transform.position.x - target.position.x) > 0.7f) */ ) || ((System.Math.Abs(transform.position.z - target.position.z) < 5f)/*&& (System.Math.Abs(transform.position.z - target.position.z) > 0.7f) */))
            {
                RunToPlayerGo();
            }
            else
            {
                transform.LookAt(target); // враг смотрит на игрока (target)
                Obj.GetComponent<Animation>().Play(NameAnimationLookPlayer);
            } 
        }
        
    }

  /*  private void OnTriggerEnter(Collider col0)
    {
        if (col0.tag == "Player")
        {
            
            transform.LookAt(target); // враг смотрит на игрока (target)
            Obj.GetComponent<Animation>().Play(NameAnimationLookPlayer);
            Debug.Log("IsTrigger LookPlayer well done");
            
            
            

        }
    } */

    void RunToPlayerGo()
    {
        Obj.GetComponent<Animation>().Play(NameAnimationRun);
        transform.LookAt(target);
        transform.position = Vector3.Lerp(transform.position, target.position, speedEnemy * Time.deltaTime);
       // Debug.Log("IsTrigger RunToPlayer well done");
    }

   /* private void OnTriggerEnterRunMode(Collider col1)
    {
        if (col1.tag == "Player")
        {
            
            transform.position = Vector3.Lerp(transform.position, target.position, speedEnemy * Time.deltaTime);
            transform.LookAt(target); // враг смотрит на игрока (target)
            Obj.GetComponent<Animation>().Play(NameAnimationRun);
            Debug.Log("IsTrigger CombatMode well done");
        }
    }

    private void OnTriggerEnterBattle(Collider col2)
    {
        if (col2.tag == "Player")
        {
            
            transform.LookAt(target);
            Obj.GetComponent<Animation>().Play(NameAnimationBattle);
            Debug.Log("IsTrigger Battle well done");
        }
    }
*/
}
