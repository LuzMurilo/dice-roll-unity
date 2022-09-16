using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultState : State
{
    float timeElapsed;
    bool resultFound;
    bool invalidResult;

    public ResultState(DiceController cont) : base(cont)
    {

    }

    public override IEnumerator Start()
    {
        resultFound = false;
        invalidResult = false;
        timeElapsed = 0.0f;

        return base.Start();
    }

    public override IEnumerator Update()
    {
        if (!resultFound && !invalidResult)
        {
            timeElapsed += Time.deltaTime;
            CheckTopFace();
        }

        return base.Update();
    }

    public void CheckTopFace()
    {        
        int topFaceIndex = Controller.faces.FindIndex( face => (face.up - Vector3.up).magnitude <= 0.1f);

        if (topFaceIndex != -1)
        {
            topFaceIndex++;
            Debug.Log("Result is: " + topFaceIndex);
            UIController.MainInstance.PrintDiceResult(topFaceIndex);
            resultFound = true;
        }
        else if (timeElapsed >= 3.0f)
        {
            Debug.LogWarning("Invalid Roll!");
            UIController.MainInstance.ShowWarningSign();
            invalidResult = true;
        }
    }
}
