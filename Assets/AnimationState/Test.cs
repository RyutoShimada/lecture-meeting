using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Test : MonoBehaviour
{
    [SerializeField]
    string _animationStateName = default;

    Animator _anim = default;

    void Start()
    {
        if (TryGetComponent(out _anim))
        {
            if (_animationStateName == "") { return; }
            _anim.Play(_animationStateName);
        }
        else
        {
            gameObject.AddComponent<Animator>();
        }
    }

    public void Animation(string animationName)
    {
        _anim.Play(animationName);
    }
}
