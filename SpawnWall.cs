using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{

    public GameObject brick;
    public GameObject sB;
    //startBrick
    
    // Start is called before the first frame update
    void Start()
    {
        brick = GameObject.Find("wall");
        float sBx = sB.transform.position.x;
        float sBz = sB.transform.position.z;
        float sBy = sB.transform.position.y;
        Quaternion sBrot = sB.transform.rotation;


        RaycastHit hit;
        if (Physics.Raycast(new Ray(transform.position, Vector3.down), out hit, Mathf.Infinity))
        {
            sBy = hit.transform.position.y;
        }
        
       
        for(int i = 0; i < 5; i++ )
        {
            for(int j = 0; j < 10; j++)
            {
                GameObject.Instantiate(brick, new Vector3(sBx + j * 5, sBy + i * 5, sBz), sBrot);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
