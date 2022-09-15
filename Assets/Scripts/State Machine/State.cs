using System.Collections;
using UnityEngine;

public abstract class State
{
    protected DiceController Controller;

    public State(DiceController cont)
    {
        Controller = cont;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator Update()
    {
        yield break;
    }
}