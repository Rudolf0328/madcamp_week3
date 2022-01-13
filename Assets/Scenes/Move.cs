using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    Vector3 right = new Vector3(1, 0, 0);
    Vector3 forward = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * Time.deltaTime;
        v = v * Time.deltaTime;

        transform.Translate(right * h * 20);
        transform.Translate(forward * v * 20);
    }
}