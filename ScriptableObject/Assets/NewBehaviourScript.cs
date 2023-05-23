using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public MyScriptable myScriptable;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var point in myScriptable.myPoints)
        {
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
