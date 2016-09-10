using UnityEngine;
using System.Collections;

public class arrowScript : MonoBehaviour
{
    public GameObject noteBlock;
    public GameObject arrow;
    bool note_arrow_overlap = false;
    public float scrollSpeed = 0.3f;
    public KeyCode directionKey = KeyCode.UpArrow;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(directionKey));
        {
            print("Pressed");
        }
        if (Input.GetKeyUp(directionKey))
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
