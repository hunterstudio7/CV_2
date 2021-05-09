using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour {

    public float speed, tilt;
    public Vector3 target;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 0.1f)
            target.y = 0.1f;
        else if (transform.position == target && target.y == 0.1f)
            target.y = 1.5f;
        transform.Rotate(Vector3.up * Time.deltaTime * tilt);
    }
}
