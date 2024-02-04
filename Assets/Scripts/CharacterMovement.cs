using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 500f;
    private Rigidbody2D _rb;

    private Vector2 _movement;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.AddForce(_movement * _speed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        UnityEngine.Debug.Log("Hello World");
        _movement = value.Get<Vector2>();
    }
}
