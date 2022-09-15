using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiceController : MonoBehaviour
{
    [SerializeField] private List<Transform> faces;
    [SerializeField] private TextMeshProUGUI resultText;
    private bool checkTopFace;

    private void Awake() 
    {
        if (faces.Count != 6)
        {
            Debug.LogError("Dice faces references not found!");
            checkTopFace = false;
        }
        else
        {
            checkTopFace = true;
        }
    }

    private void Update() 
    {
        if (checkTopFace)
        {
            int topFaceIndex = faces.FindIndex( face => face.up == Vector3.up);
            topFaceIndex++;
            resultText.text = "" + topFaceIndex;
        }
    }
}
