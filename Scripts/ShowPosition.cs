using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 objectPosition = transform.position;
        Debug.Log(gameObject.name + " Position: " + objectPosition);
    }
}