using UnityEngine;
using UnityEngine.UI;

public class TestText : MonoBehaviour
{
    [SerializeField]
    Text _text = default;

    float _timer = default;

    void Start()
    {

    }

    void Update()
    {
        _timer += Time.deltaTime;
        _text.text = $"TIME : {_timer.ToString("0")}";
    }
}
