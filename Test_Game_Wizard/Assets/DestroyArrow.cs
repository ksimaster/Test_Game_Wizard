using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour {
    [SerializeField]
    Object GoDeadArrow;
    [SerializeField]
	private float LifeTimeArrow = 3f;
    Collider FireArrowCollider;

    void Start()
    {
        FireArrowCollider = GetComponent<Collider>();    
    }

    void Update () {
        Destroy(GoDeadArrow, LifeTimeArrow);
        if (FireArrowCollider.isTrigger==true)
        {
            Destroy(GoDeadArrow, 0);
        }
        
	}
}
