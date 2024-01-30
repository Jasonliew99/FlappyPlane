using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float MoveSpeed = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x <= -13)
            Destroy(gameObject);

        Vector2 targetMovePos = transform.position;
        targetMovePos.x -= MoveSpeed * Time.deltaTime;

        transform.position = targetMovePos;
    }
}
