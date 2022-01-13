using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    // Check whether the collision occured
    void onCollisionEnter(Collision obj){
        Debug.Log("충돌 발생");
    }
}