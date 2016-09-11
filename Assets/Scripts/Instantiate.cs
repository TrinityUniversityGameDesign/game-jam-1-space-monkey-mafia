using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour
{

    public float timeCount = 0;
    public float bps = 1;
    public float offset = 0;
    bool beats_bool = true;
    public GameObject parentTrack;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(WaitAndPrint(1 / bps));

    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        Debug.Log(timeCount);

        if (timeCount % (1 / bps) == 0)
        {
            // Object.Instantiate(Resources.Load("Prefabs/noteBlock"), new Vector3(0, 7, 0), Quaternion.identity);
        }

    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(offset);
        while (beats_bool)
        {
            yield return new WaitForSeconds(waitTime);
            //Object.Instantiate(Resources.Load("Prefabs/noteBlock"), new Vector3(0, 7, 0), Quaternion.identity);
            GameObject newNoteBlock = (GameObject)Instantiate(Resources.Load("Prefabs/noteBlock"), parentTrack.transform);
            newNoteBlock.transform.localPosition = new Vector3(0, 0, -0.9f);
        }

    }


}


