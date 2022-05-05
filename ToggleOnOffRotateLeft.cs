using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOffRotateLeft: MonoBehaviour
{
    
    private GameObject scriptholder;
    private GameObject cannon;
    void OnEnable()
    {
        scriptholder = GameObject.Find("ScriptHolderRotate");
        cannon = GameObject.Find("Cannon");
        Debug.Log("Print");
        
        Rotate rotate = scriptholder.GetComponent<Rotate>();
        rotate.RotateL(cannon);
    }

    // Update is called once per frame
    void OnDisable()
    {
        Debug.Log("PrintDisable");
    }
}
