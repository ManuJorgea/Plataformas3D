using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdeM.Controllers { 

    public class Character3D : EntityController
    {
        protected CharacterController _cc;
        protected float _gravity = -0.981f;
        protected Vector3 _velocity;
        protected Vector3 _direction;

        protected float _turnSmoothTime;
        protected float _turnSmoothVelocity;

        protected override void Awake()
        {
            base.Awake();
            _turnSmoothTime = 0.2f;
            _turnSmoothVelocity = 0f;
            _jumpForce = 0.03f;
            _cc = gameObject.GetComponent<CharacterController>();

            if (_cc == null )
            {
                Debug.LogError("Debe tener el CharacterController attached");
            }

        }

        protected override void Update()
        {
            base.Update();
            _isGrounded = _cc.isGrounded;
        }

        protected override void LateUpdate() {
            base.LateUpdate();

            /* Velocity Y */
            _velocity.y += _gravity * Time.deltaTime;

            if (_isGrounded && _velocity.y < 0)
            {
                _velocity.y = -0.181f;
            }

            _cc.Move(_velocity);
        }

        protected override void Jump()
        {
            base.Jump();

            _velocity.y = Mathf.Sqrt(_jumpForce * -2 * _gravity);
        }
    }

}
