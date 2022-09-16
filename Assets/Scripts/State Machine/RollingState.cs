using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingState : State
{
    public RollingState(DiceController cont) : base(cont)
    {

    }

    public override IEnumerator Start()
    {
        return base.Start();
    }

    public override IEnumerator Update()
    {
        if (Controller.diceRigidBody.angularVelocity.magnitude <= 0.1f)
        {
            Controller.SetState(new ResultState(Controller));
        }
        return base.Update();
    }
}
