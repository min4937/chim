using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    float direcction = 0.05f;

    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direcction *= -1;
            renderer.flipX = !renderer.flipX;
        }
        if(transform.position.x > 2.6f)
        {
            renderer.flipX = true;
            direcction = -0.05f;
        }
        if (transform.position.x < -2.6f)
        {
            renderer.flipX = false;
            direcction = 0.05f;
        }
        transform.position += Vector3.right * direcction; 
    }
}
