using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFlame : MonoBehaviour {

    [SerializeField]
    Object GoDeadFlame;
    [SerializeField]
    private float LifeTimeFlame = 3f;
    void Update()
    {
        Destroy(GoDeadFlame, LifeTimeFlame);
    }
}
