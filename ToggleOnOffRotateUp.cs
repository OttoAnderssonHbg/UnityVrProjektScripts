using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOffRotateUp : MonoBehaviour
{
    private GameObject scriptholder;
    private GameObject barrel;
    void OnEnable()
    {
        scriptholder = GameObject.Find("ScriptHolderRotateUp");
        barrel = GameObject.Find("pCylinder7");
        Debug.Log("Print");

        Rotate rotate = scriptholder.GetComponent<Rotate>();
        rotate.RotateU(barrel);
    }

    // Update is called once per frame
    void OnDisable()
    {
        Debug.Log("PrintDisable");
    }
}
