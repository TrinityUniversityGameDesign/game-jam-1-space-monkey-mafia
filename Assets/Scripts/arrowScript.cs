using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class arrowScript : MonoBehaviour
{
    public GameObject noteBlock;
    public Rigidbody2D arrow;
    public GameObject collision;
    public GameObject flop;
    bool note_arrow_overlap = false;
    bool note_out = false;
    public float scrollSpeed = 0.3f;
    public KeyCode directionKey = KeyCode.UpArrow;
    public string dckey = "up";
    public Text scoreText;

    private Animator anim;


    public int score = 0;



    public float range = -1;




    // Use this for initialization
    void Start()
    {
        //noteBlock = GetComponent<Collider2D>();
        arrow = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(dckey))
        {
            if (note_arrow_overlap && collision != null)
            {
                range = Mathf.Abs(arrow.transform.position.y - collision.transform.position.y);
                if (range < .1)
                {
                    score += 100;
                    anim.SetInteger("precision", 3);
                    StartCoroutine(WaitAndPrint(0.5F));
                }
                else if (range < .25)
                {
                    score += 50;
                    anim.SetInteger("precision", 2);
                    StartCoroutine(WaitAndPrint(0.5F));
                }
                else if (range < 0.5)
                {
                    score += 25;
                    anim.SetInteger("precision", 1);
                    StartCoroutine(WaitAndPrint(0.5F));
                }
                else
                {
                    anim.SetInteger("precision", 4);
                    StartCoroutine(WaitAndPrint(0.5F));
                }
                
            }
            else
            {
                score -= 75;
                anim.SetInteger("precision", 4);
                StartCoroutine(WaitAndPrint(0.5F));

            }


            if (collision != null) DestroyObject(collision);
        }
        //print(range);

        scoreText.text = "Score = " + score;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.layer);
        if (other.gameObject.layer == LayerMask.NameToLayer("NoteLayer"))
        {
            collision = other.gameObject;
            note_arrow_overlap = true;
            Debug.Log("Trigger enter!");
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("NoteLayer"))
        {
            collision = null;
            note_arrow_overlap = false;
           
            Debug.Log("Trigger exit!!!");
        }
        DestroyObject(other.gameObject);
    }

    IEnumerator WaitAndPrint(float waitTime)
    {  
            yield return new WaitForSeconds(waitTime);
            anim.SetInteger("precision",0);
        

    }
}
