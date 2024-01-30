using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float UpwardForce = 200.00f;
    public int INTERGER = 2;

    private Rigidbody2D _rigibody;
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;

    private void Start()
    {
       _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (_rigidbody == null)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * UpwardForce);
            Debug.Log("He should flap upawrds");
        }
    }
}
