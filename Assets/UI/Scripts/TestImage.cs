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

    private void Start()
    {
        _imageObject.sprite = _source1;
    }

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _interval)
        {
            _timer = 0;

            if (_imageObject.sprite == _source1)
            {
                _imageObject.sprite = _source2;
            }
            else
            {
                _imageObject.sprite = _source1;
            }
        }
    }
}
