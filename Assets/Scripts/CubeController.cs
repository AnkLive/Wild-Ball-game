using UnityEngine;

public class CubeController : MonoBehaviour
{
    
    private Animator _anim;
    private Rigidbody _rb;

    void Start() 
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update() => _anim.SetFloat("Velocity", _rb.velocity.magnitude);

}
