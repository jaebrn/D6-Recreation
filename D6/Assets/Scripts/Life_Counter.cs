using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life_Counter : MonoBehaviour
{
    public Sprite[] lifeCounter;
    public SpriteRenderer spriteRend;
    public int currentLives;

    // Start is called before the first frame update
    void Start()
    {
        currentLives = 6;

    }

    // Update is called once per frame
    void Update()
    {
        spriteRend.sprite = lifeCounter[currentLives];
    }

    public void LoseLife()
    {
        currentLives = currentLives - 1;
        if(currentLives <=0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("End");
        }
        else
        {
            spriteRend.sprite = lifeCounter[currentLives];
            Debug.Log("Lose life");
        }
    }
}
