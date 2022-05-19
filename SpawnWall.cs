using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{

    public GameObject brick;
    public GameObject sB;
    private GameObject floor;
    //startBrick
    
    // Start is called before the first frame update
    void Start()
    {
        float sBx = sB.transform.position.x;
        float sBz = sB.transform.position.z;
        float sBy = sB.transform.position.y;
        Quaternion sBrot = sB.transform.rotation;

        floor = GameObject.Find("Floor");

        Mesh floormesh = floor.GetComponent<MeshFilter>().mesh;

        Mesh mesh = brick.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        float bx = mesh.bounds.size.x * 10;
        float by = mesh.bounds.size.y * 5;

        RaycastHit hit;
        if (Physics.Raycast(new Ray(transform.position, Vector3.down), out hit, Mathf.Infinity))
        {
            sBy = hit.transform.position.y + floormesh.bounds.size.y /2;
        }
        ///test

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject.Instantiate(brick, new Vector3(sBx + bx * j, sBy + by * i + by/2 , sBz), sBrot);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
