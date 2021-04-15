using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController_Base : MonoBehaviour
{
   // die value management
    [Range(0, 5)] // range is 0-5 for the purposes of calling the correct sprite from the array: a 0 value die displays a face value of 1
    [SerializeField]
    protected int m_dieValue;

    // die face sprite array
    public Sprite[] dieFace;
    public SpriteRenderer spriteRend;

    // Start is called before the first frame update
    void Start()
    {
        m_dieValue = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRend.sprite = dieFace[m_dieValue]; // sprite displayed corresponds to the die value 
    }
}
