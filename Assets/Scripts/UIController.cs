using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public static UIController MainInstance;
    [SerializeField] TMP_Text diceNumber1;
    [SerializeField] TMP_Text diceNumber2;

    private void Awake() 
    {
        if (UIController.MainInstance == null)
        {
            UIController.MainInstance = this;
        }
    }

    public void PrintDiceResult(int result)
    {
        if (diceNumber1.text == "")
        {
            diceNumber1.text = "" + result;
        }
        else
        {
            diceNumber2.text = "" + result;
        }
    }

    public void ResetDiceResult()
    {
        diceNumber1.text = "";
        diceNumber2.text = "";
    }
}
