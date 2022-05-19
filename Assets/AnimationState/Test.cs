using UnityEngine;

public class Test : MonoBehaviour
{
    Animator _anim = default;
    
    void Start()
    {
        TryGetComponent(out _anim);
    }

    public void Animation(string animationName)
    {
        _anim.Play(animationName);
    }
}
