using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOffRotateRight : MonoBehaviour
{
    
    private GameObject scriptholder;
    private GameObject cannon;
    void OnEnable()
    {
        scriptholder = GameObject.Find("ScriptHolderRotateRight");
        cannon = GameObject.Find("Cannon");
        Debug.Log("Print");

        Rotate rotate = scriptholder.GetComponent<Rotate>();
        rotate.RotateR(cannon);
    }

    // Update is called once per frame
    void OnDisable()
    {
        Debug.Log("PrintDisable");
    }
}
