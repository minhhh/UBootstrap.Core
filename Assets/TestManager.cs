using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UBootstrap;

public class TestManager : MonoBehaviour
{

    void Awake ()
    {
        Debug.Log (GameObjectHelper.Find ("GameObject"));
        Debug.Log (GameObjectHelper.FindObjectOfType <AComponent> ());
        Debug.Log (GameObjectHelper.FindObjectOfType (typeof(AComponent)));
        Debug.Log (GameObjectHelper.FindObjectsOfType <AComponent> ());
        Debug.Log (GameObjectHelper.FindObjectsOfType (typeof(AComponent)));
        Debug.Log (StringHelper.PadDigit (121, 2));
    }

	
    // Update is called once per frame
    void Update ()
    {
		
    }
}
