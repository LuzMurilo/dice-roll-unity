using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultState : State
{
    float timeElapsed;
    bool resultFound;

    public ResultState(DiceController cont) : base(cont)
    {

    }

    public override IEnumerator Start()
    {
        Debug.Log("Result State");
        resultFound = false;
        timeElapsed = 0.0f;

        if (Controller.faces.Exists(face => face.up == Vector3.up))
        {
            CheckTopFace();
            resultFound = true;
        }
        

        return base.Start();
    }

    public override IEnumerator Update()
    {
        if (!resultFound)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= 1.0f)
            {
                if (Controller.faces.Exists(face => face.up == Vector3.up))
                {
                    CheckTopFace();
                    resultFound = true;
                }
                else
                {
                    Debug.LogWarning("Invalid Roll!");
                }
            }
        }
        return base.Update();
    }

    public void CheckTopFace()
    {        
        int topFaceIndex = Controller.faces.FindIndex( face => face.up == Vector3.up);
        topFaceIndex++;
        Debug.Log("Result is: " + topFaceIndex);
        UIController.MainInstance.PrintDiceResult(topFaceIndex);
    }
}
