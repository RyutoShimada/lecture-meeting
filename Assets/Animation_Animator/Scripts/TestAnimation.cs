using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour
{
    Animator _anim = default;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out _anim);
    }

    public void Zero()
    {
        _anim.Play("0");
    }

    public void One()
    {
        _anim.Play("1");
    }

    public void Two()
    {
        _anim.Play("2");
    }

    public void Three()
    {
        _anim.Play("3");
    }
}
