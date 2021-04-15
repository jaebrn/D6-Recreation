using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dicePrefab; //iding prefab

    Vector2[] diceStartingPos = // pos array (first row only)
    {
        new Vector2(-7f, 0f),
        new Vector2(-3.5f, 0f),
        new Vector2(0f, 0f),
        new Vector2(3.5f, 0f),
        new Vector2(7f, 0f),
    };
    // Start is called before the first frame update
    void Start()
    {
        // instantiating starting row 
        for (int i = 0; i <= diceStartingPos.Length; i++) // instatiates number of dice == number of starting positions available
        {
            Instantiate(dicePrefab, diceStartingPos[i], UnityEngine.Quaternion.identity); // instantiates dice prefab at location array index i
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
