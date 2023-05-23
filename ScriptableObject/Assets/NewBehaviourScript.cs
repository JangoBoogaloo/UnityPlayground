using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public ScriptableScriptable myScriptableScriptable;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var scriptable in myScriptableScriptable.myScriptables)
        {
            foreach (var point in scriptable.myPoints)
            {
                Debug.Log(point);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
