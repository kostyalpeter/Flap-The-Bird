using System.Collections;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public GameObject map;
    public Vector3 Pos1;
    public Vector3 Pos2;
    bool Asked = false;
    float seconds;
    void Start()
    {
        seconds = Random.Range(1f, 3f);
        StartCoroutine(WaitForSeconds1());
    }

    void Update()
    {
        if(Asked)
        {
            Asked = false;
            Instantiate(map, Pos1, Quaternion.identity);
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
