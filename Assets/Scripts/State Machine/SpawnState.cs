using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnState : State
{

    public SpawnState(DiceController cont) : base(cont)
    {

    }

    public override IEnumerator Start()
    {
        Debug.Log("Spawn State");

        float randomRotationX = Random.Range(-5.0f, 10.0f);
        float randomRotationY = Random.Range(-5.0f, 10.0f);

        Controller.diceRigidBody.angularVelocity = new Vector3(randomRotationX, randomRotationY, 10.0f);

        Controller.SetState(new RollingState(Controller));

        return base.Start();
    }
}
