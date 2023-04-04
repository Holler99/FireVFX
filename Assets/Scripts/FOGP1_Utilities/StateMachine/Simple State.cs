using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FGOP1_Utilities.StateMachine
{
    [System.Serializeable]
    public class SimpleState
    {
        [Header("State Event")]
        public UnityEvent StateEnter;
        public UnityEvent StateUpdate;
        public UnityEvent StateExit;

        //[HideInInspector]
        public virtual void OnStart()
        {
            StateEnter.Invoke();
        }

        public virtual void OnUpdate()
        {
            StateUpdate.Invoke();
        }

        public virtual void OnExit()
        {
            StateExit.Invoke();
        }
    }
}
