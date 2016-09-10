using UnityEngine;
using System.Collections;

public class noteMovement : MonoBehaviour {
    public float scrollspeed = 0.05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y-scrollspeed/5);

	}
}
