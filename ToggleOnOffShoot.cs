using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOffShoot: MonoBehaviour
{
    private GameObject scriptholder;

  


    void OnEnable()
    {
        scriptholder = GameObject.Find("ScriptHolder");
        Debug.Log("Print");
        scriptholder.GetComponent<FlyingBall>().Shoot();
    }
    private void OnDisable()
    {
        Debug.Log("PrintDisable");
        

    }

}
