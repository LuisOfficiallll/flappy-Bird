using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject pipePrefab;
    // Start is called before the first frame update
    void Start()
    {
       // InvokingRepeating("SpawnPipes", 1,1);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(pipePrefab, new Vector3(10,0,0), Quaternion.identity);
    }
}
