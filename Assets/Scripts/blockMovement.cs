using UnityEngine;
using System.Collections;

public class blockMovement : MonoBehaviour {
    public GameObject noteBlock;
    public GameObject arrow;
    bool note_arrow_overlap = false;
    public float scrollSpeed = 0.3f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Notes"))
        {
            note_arrow_overlap = true;
            Debug.Log("Trigger enter!";
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Notes"))
        {
            note_arrow_overlap = false;
            Debug.Log("Trigger exit!!!");
        }
    }
}
