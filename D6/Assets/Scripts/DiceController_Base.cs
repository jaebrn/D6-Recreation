using UnityEngine;

public class DiceController_Base : MonoBehaviour
{
   // die value management
    [SerializeField]
    protected int m_dieValue, m_dieColor;

    // die face sprite array
    public Sprite[] dieFace;
    public SpriteRenderer spriteRend;

    // die color array
    public Color[] dieColor;

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
       // check die y axis position and apply tag or string or something accordingly
       //die will either register as: 
            //first row, second row, or currently selected
    }

    //called when a die is clicked
    public void OnMouseDown()
    {
        // if clicked die is currently selected, clear it
                // die.position.y =-
                // if die.pos.u =< something offscreen, delete
        // if die is on first row, run legality check against selected die
                // if legality check returns true, die moves, yadda yadda
        // else if die is on second row or legality check returns false, do dice shimmy. 

    }
}
