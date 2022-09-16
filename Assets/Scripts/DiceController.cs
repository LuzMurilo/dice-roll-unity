using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceController : StateMachine
{
    [SerializeField] public List<Transform> faces;
    public Rigidbody diceRigidBody;

    private void Awake() 
    {
        diceRigidBody = GetComponent<Rigidbody>();

        if (faces.Count != 6)
        {
            Debug.LogError("Dice faces references not found!");
        }
    }

    private void Start() 
    {
        SetState(new SpawnState(this));
    }
}
