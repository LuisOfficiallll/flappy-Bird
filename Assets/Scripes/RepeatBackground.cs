using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Vector3 startPos;
        StartPos = transform.position;
        float reapeatWidth;
        repeatWidth = startPos.x - 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
                                                                                                                                                                                                                                                           