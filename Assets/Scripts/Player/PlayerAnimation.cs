using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    
    [SerializeField]
    private PlayerMovement _movement;
    

    private void Update()
    {
        _animator.SetFloat("MovementSpeed",  _movement.Velocity.z);
    }
}
