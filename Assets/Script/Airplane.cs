using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    public float UpwardForce = 200.00f;
    public int INTERGER = 2;

    AudioSource jumpsound;

    private Rigidbody2D _rigibody;
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;

    private void Start()
    {
       _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
        jumpsound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_rigidbody == null)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpsound.Play();
            _rigidbody.velocity = Vector2.zero;
            _rigidbody.AddForce(Vector2.up * UpwardForce);
            //Debug.Log("He should flap upawrds");
        }
    }
}
