using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSpawner : MonoBehaviour
{
    [SerializeField] Transform spawn1;
    [SerializeField] Transform spawn2;

    [SerializeField] GameObject dicePrefab;
    private List<GameObject> dices;

    private void Awake() {
        dices = new List<GameObject>();
    }

    public void SpawnDices()
    {
        if (dices.Count > 0)
        {
            dices.ForEach(dice => 
            {
                GameObject.Destroy(dice);
            });
            dices.RemoveAll(dice => true);
        }

        Quaternion diceRotation1 = Quaternion.Euler(GetRandomRotation());
        Quaternion diceRotation2 = Quaternion.Euler(GetRandomRotation());

        dices.Add(GameObject.Instantiate(dicePrefab, spawn1.position, diceRotation1));
        dices.Add(GameObject.Instantiate(dicePrefab, spawn2.position, diceRotation2));

        UIController.MainInstance.ResetDiceResult();
    }

    private Vector3 GetRandomRotation()
    {
        Vector3 randomVector = new Vector3();
        randomVector.x = Random.Range(0.0f, 360.0f);
        randomVector.y = Random.Range(0.0f, 360.0f);
        randomVector.z = Random.Range(0.0f, 360.0f);

        return randomVector;
    }
}
