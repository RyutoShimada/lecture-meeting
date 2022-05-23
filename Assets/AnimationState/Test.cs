using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Test : MonoBehaviour
{
    Animator _anim = default;
    
    void Start()
    {
        if (!TryGetComponent(out _anim))
        {
            gameObject.AddComponent<Animator>();
        }
    }

    public void Animation(string animationName)
    {
        _anim.Play(animationName);
    }
}
