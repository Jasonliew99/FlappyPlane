using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalVelocityRotator : MonoBehaviour
{
    public float RotateDown = -10f;
    public float RotateUp = 40f;

    private Airplane _player;

    private float _currentY;
    private float _lastY;

    private float _velocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        _player = transform.parent.GetComponent<Airplane>();
        _currentY = _lastY = transform.parent.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player == null)
            return;

        _currentY = _player.transform.position.y;

        _velocity = _currentY - _lastY;

        _velocity *= 10f;
        _velocity = Mathf.Clamp(_velocity, -1, 1);
        _velocity = Unity.Mathematics.math.remap(-1, 1, 0, 1, _velocity);

        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0,0,RotateUp), Quaternion.Euler(0, 0 , RotateDown), _velocity);

        _lastY = _player.transform.position.y;
    }
}
