using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    Vector2 m_moveLimit = new Vector2(4.0f, 0);

    Vector3 right = new Vector3(1, 0, 0);
    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 upward = new Vector3(0, 1, 0);

    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // float t = Input.GetAxis("")

        h = h * Time.deltaTime;
        v = v * Time.deltaTime;

        transform.Translate(right * h * 20);
        transform.Translate(forward * v * 20);

        if(Input.GetMouseButton(0)) {
          // Get the mouse delta. This is not in the range -1...1
          float h1 = horizontalSpeed * Input.GetAxis("Mouse X");
          float v1 = verticalSpeed * Input.GetAxis("Mouse Y");

          transform.Rotate(v1, h1, 0);
        }
    }

  public Vector3 ClampPosition(Vector3 position) {
    return new Vector3 (
      Mathf.Clamp(position.x, -m_moveLimit.x, m_moveLimit.x), -7f, 0
    );
  }
}