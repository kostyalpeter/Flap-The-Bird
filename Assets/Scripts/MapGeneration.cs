using System.Collections;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public GameObject mapUp;
    public GameObject mapDown;
    public Vector3 Pos1;
    public Vector3 Pos2;
    bool Asked = false;
    float seconds;
    static bool Started;
    void Start()
    {
    }

    void Update()
    {
        if (Started)
        {
            seconds = Random.Range(1f, 3f);
            StartCoroutine(WaitForSeconds1());
            Started = false;
        }

        if(Asked)
        {
            Pos1.y = Random.Range(8f, 5f);
            Pos2.y = Random.Range(-6f, -5f);
            Asked = false;
            Instantiate(mapUp, Pos1, Quaternion.identity);
            Instantiate(mapDown, Pos2, Quaternion.identity);
            seconds = Random.Range(1f, 3f);
            StartCoroutine(WaitForSeconds1());
        }
        Debug.Log(Asked);
    }

    IEnumerator WaitForSeconds1()
    {
        yield return new WaitForSeconds(seconds);
        Asked = true;   
    }
}
