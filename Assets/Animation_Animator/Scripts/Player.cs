using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField]
    float _speed = 15f;

    Rigidbody2D _rb2d = default;
    Animator _anim = default;

    void Start()
    {
        TryGetComponent(out _rb2d);
        TryGetComponent(out _anim);
    }
    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        var velo = _rb2d.velocity;

        if (x != 0)
        {
            velo.x = x * _speed;
            // Œü‚«‚ð•Ï‚¦‚é
            transform.localScale = new Vector3(-x, transform.localScale.y, transform.localScale.y);
        }
        else
        {
            velo.x = 0;
        }

        _rb2d.velocity = velo;
    }
}
