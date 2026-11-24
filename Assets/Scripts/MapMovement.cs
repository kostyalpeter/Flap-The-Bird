using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        gameObject.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;

    }
    }
