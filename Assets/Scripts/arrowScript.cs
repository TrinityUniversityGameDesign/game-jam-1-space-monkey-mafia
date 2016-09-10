using UnityEngine;
using System.Collections;

public class arrowScript : MonoBehaviour
{
    public GameObject noteBlock;
    public GameObject arrow;
    bool note_arrow_overlap = false;
    public float scrollSpeed = 0.3f;
    public KeyCode directionKey = KeyCode.UpArrow;
    bool keyPressed = false;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            keyPressed = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            keyPressed = false;
        }
        if(keyPressed)
        {
            print("Pressed");
        } else
        {
            print("Not Pressed");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.layer);
        if (other.gameObject.layer == LayerMask.NameToLayer("NoteLayer"))
        {
            note_arrow_overlap = true;
            Debug.Log("Trigger enter!");
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("NoteLayer"))
        {
            note_arrow_overlap = false;
            Debug.Log("Trigger exit!!!");
        }
    }
}
