using UnityEngine;
using UnityEngine.UI;

public class TestText : MonoBehaviour
{
    [SerializeField]
    Text _text = default;

    float _timer = default;

    bool _isStop = default;

    void Update()
    {
        if (_isStop) { return; }

        _timer += Time.deltaTime;
        _text.text = $"TIME : {_timer.ToString("f2")}";
    }

    public void ControlTime()
    {
        _isStop = _isStop == true ? false : true;
    }
}
