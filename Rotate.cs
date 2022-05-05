using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update




    public void RotateL(GameObject cannon)
    {
        Debug.Log("Rotate");
        cannon.transform.eulerAngles = new Vector3(cannon.transform.eulerAngles.x, cannon.transform.eulerAngles.y - 5, cannon.transform.eulerAngles.z );
    }
    public void RotateR(GameObject cannon)
    {
        Debug.Log("Rotate");
        cannon.transform.eulerAngles = new Vector3(cannon.transform.eulerAngles.x, cannon.transform.eulerAngles.y + 5, cannon.transform.eulerAngles.z);
    }
    public void RotateU(GameObject barrel)
    {
        Debug.Log("Rotate");
        
    }
}
