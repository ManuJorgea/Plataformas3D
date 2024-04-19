using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdeM.Controllers;

public class JaneDowController : Character3DPlayer
{

    Animator _anim;
    

    protected override void Start() {
        base.Start();

        _anim = transform.Find("Animations").GetComponent<Animator>();

        if (_anim == null)
        {
            Debug.LogError("NO hay componente de animator en el character");
        }
    }

    protected override void Update() {
        base.Update();

        Vector3 speed = new(_axisH, 0, _axisV);
        _anim.SetFloat("Speed", speed.magnitude);
        _anim.SetBool("Fall", _isFalling);
        _anim.SetBool("Grounded", _isGrounded);
        _anim.SetFloat("High", _high);
    
    }

    protected override void StartFall() { 
        base.StartFall();
        _anim.SetTrigger("StartFall");
    
    }

    protected override void Jump()
    {
        base.Jump();
        _anim.SetTrigger("Jump");
    }

    protected override void DetectHigh() {
        base.DetectHigh();
        _high -= 1;
    }

    /*protected override void Punch()
    {
        base.Punch();
        _anim.SetTrigger("Punch");
    }*/

}
