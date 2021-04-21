using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    [Header("Dice Table")]
    //Length and Height of the table
    public int columnLength;
    public int rowHeight;
    //Table
    public GameObject[,] DiceTable;
    //Die pos
    public Vector3 currentDiePosition;
    //Positional offsets
    public int xOffset;
    public int yOffset;
    //Die prefab
    public GameObject DiePrefab;


    // Start is called before the first frame update
    void Start()
    {
        //Instantiating 2D dice array 
        DiceTable = new GameObject[columnLength, rowHeight];

        for (int i = 0; i < columnLength; i++)
        {
            for (int j = 0; j < rowHeight; j++)
            {
                DiceTable[i, j] = Instantiate(DiePrefab, (new Vector2(currentDiePosition.x + i*xOffset, currentDiePosition.y + j*yOffset)) , Quaternion.identity);

            }         
        }
    }

    // Update is called once per frame
    void Update()
    {

    }   

}

