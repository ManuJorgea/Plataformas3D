using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace UdeM.Controllers { 

    public class NPC3D : EntityController
    {
        protected NavMeshAgent _navigator;

        protected override void Start()
        {
            base.Start();
            _navigator = GetComponent<NavMeshAgent>();
            if ( _navigator == null )
            {
                Debug.Log("NavMeshAgent no esta presente");
            }
        }

    }
}