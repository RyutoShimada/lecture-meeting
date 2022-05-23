using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestImage : MonoBehaviour
{
    [SerializeField]
    Image _imageObject = default;

    [SerializeField]
    Sprite _source1 = default;

    [SerializeField]
    Sprite _source2 = default;

    [SerializeField]
    float _interval = default;

    float _timer = default;

    bool _isStop = default;

    private void Start()
    {
        _imageObject.sprite = _source1;
    }

    void Update()
    {
        if (_isStop) { return; }

        _timer += Time.deltaTime;
        if (_timer > _interval)
        {
            _timer = 0;
            _imageObject.sprite = _imageObject.sprite == _source1 ? _source2 : _source1;
        }
    }

    public void ControlTime()
    {
        _isStop ^= true;
    }
}
