using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode()]
public class FlexibleUI : MonoBehaviour {
    
	protected virtual void GUI()
    {

    }

    public virtual void Awake()
    {
        GUI();
    }

    public virtual void Update()
    {
        if(Application.isEditor)
        {
            GUI();
        }
    }
}
