using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour {

    public Transform target;
    public float speedEnemy = 0.1f;
    Rigidbody rbEnemy;
    public float jumpforce = 0.5f;
    private Vector3 jmp;
    

    private void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        jmp = transform.up * jumpforce;

    }

    // Update is called once per frame
    void Update () {
        //RunToPlayer();
        if (transform.position.y < target.position.y + 0.5f)
        {
            // Jump(); // прыжки enemy
        }
        if (Vector3.Distance(transform.position, target.position)<1.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    bool isGrounded()
    {
       Collider [] cc = Physics.OverlapSphere(new Vector3(transform.position.x, transform.position.y-0.5f, transform.position.z), 1.5f);
        int j = 0;
        for (int i = 0; i<cc.Length; i++)
        {
            if (cc[i].gameObject!=gameObject)
            {
                j++;
            }
        }
        return j > 0;
    }

    void Jump()
    {
        if (isGrounded()) {

            rbEnemy.AddForce(jmp, ForceMode.Impulse);
        }
    }

    /* private void OnCollisionEnter(Collision other)
     {
         if (other.gameObject.GetComponent<Shooting>()) {
             SceneManager.LoadScene(SceneManager.GetActiveScene());
         }
     } */

   void RunToPlayer()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speedEnemy * Time.deltaTime);
        transform.LookAt(target); // враг смотрит на игрока (target)
    }
}
