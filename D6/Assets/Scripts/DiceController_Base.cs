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
        
    }
}
