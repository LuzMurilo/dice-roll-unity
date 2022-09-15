using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    protected State CurrentState;

    public void SetState(State newState)
    {
        CurrentState = newState;
        StartCoroutine(CurrentState.Start());
    }

    private void Update() 
    {
        StartCoroutine(CurrentState.Update());
    }
}