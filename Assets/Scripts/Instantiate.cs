using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Instantiate : MonoBehaviour
{

    public float timeCount = 0;
    public float bps = 1;
    public float offset = 0;
    

    public bool b0;
    public bool b1;
    public bool b2;
    public bool b3;
    public bool b4;
    public bool b5;
    public bool b6;
    public bool b7;

    

    bool beats_bool = true;

    public GameObject parentTrack;
    void Start()
    {
        StartCoroutine(WaitAndPrint(1 / bps));

    }

    void Update()
    {

    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(offset);
        while (beats_bool)
        {
            /*yield return new WaitForSeconds(waitTime);
            GameObject newNoteBlock = (GameObject)Instantiate(Resources.Load("Prefabs/noteBlock"), parentTrack.transform);
            newNoteBlock.transform.localPosition = new Vector2(0, -10f);*/
            bool[] beats = {b0,b1,b2,b3,b4,b5,b6,b7};
            foreach (bool b in beats)
            {
                if (b)
                {
                    GameObject newNoteBlock = (GameObject)Instantiate(Resources.Load("Prefabs/noteBlock"), parentTrack.transform);
                    newNoteBlock.transform.localPosition = new Vector2(0, -10f);
                }
                yield return new WaitForSeconds(1f);
            }
        }
        

    }


}


