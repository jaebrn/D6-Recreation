using UnityEngine;

public class DiceController_Base : MonoBehaviour
{
   // die value management
    [SerializeField]
    public int m_dieValue, m_dieColor;

    // die face sprite array
    public Sprite[] dieFace;
    public SpriteRenderer spriteRend;

    // die color array
    public Color[] dieColor;

    GameManager gameManagerRef;
    public bool clickable = false;

    //positional vars
    public bool firstRow, secondRow, selected = false;
    public bool legalMove;
    public int selectedDieColor, selectedDieValue;
    private Vector2 startingPos, selectedPos;


    // Start is called before the first frame update
    void Start()
    {
        // color and value values determined randomly within array range
        m_dieValue = Random.Range(0, dieFace.Length);
        m_dieColor = Random.Range(0, dieColor.Length);

        // values applied and updated visually
        spriteRend.sprite = dieFace[m_dieValue]; // sprite displayed corresponds to the die value 
        spriteRend.color = dieColor[m_dieColor]; // sprite color updates according to color value
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 3)
        {
            secondRow = true;
        }
        else if (transform.position.y < 0)
        {
            selected = true;
            gameObject.tag = "Selected Die"; // applies tag
        }
        else
        {
            firstRow = true;
        }


    }

    //called when a die is clicked
    public void OnMouseDown()
    {
        if (firstRow) // die is in the first row
        {
            Debug.Log("I am clickable");

            GameObject selected;
            selected = GameObject.FindGameObjectWithTag("Selected Die"); // iding the selected die

            DiceController_Base diceController = selected.GetComponent<DiceController_Base>(); // accessing selected die script
            selectedDieColor = diceController.m_dieColor; // getting the color of the selected die
            selectedDieValue = diceController.m_dieValue; // getting the value of the selected die

            //if (selected == null) // if there is no currently selected die, move is legal
            //{
            //    legalMove = true;
            //    Debug.Log("Move is Legal; first move");
            //}

            if(selectedDieColor == m_dieColor || selectedDieValue == m_dieValue + 1 || (m_dieValue == 0 && selectedDieValue == 5)) // if: same color; value +1, or value restart from 1
            {
                legalMove = true;
                Debug.Log("Move is Legal");
                startingPos = transform.position;
                selectedPos = selected.transform.position;
                
                Destroy(selected); // destroys previously selected die
                transform.position = Vector2.Lerp(startingPos, selectedPos, 1); // moves clicked die to selected spot
            }
            else
            {
                Debug.Log("Move is not legal");
            }

        }

        // if selected die is clicked
        if (gameObject.tag == "Selected Die")
        {
            GameObject lifeCounterObj;
            lifeCounterObj = GameObject.FindGameObjectWithTag("Life Counter");
            Life_Counter lifeCounter = lifeCounterObj.GetComponent<Life_Counter>();
            lifeCounter.LoseLife();

            Destroy(gameObject); // destroys previously selected die
            Debug.Log("Clear selected Die");
        }

    
    }
    
    
}
