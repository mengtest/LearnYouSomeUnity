﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[DisallowMultipleComponent]
public class UITemplate : MonoBehaviour {

#if UNITY_EDITOR
    [HideInInspector] public int GUID = 0;
	[HideInInspector] [System.NonSerialized]public List<GameObject> searPrefabs = new List<GameObject>();
    public void InitGUID()
    {
        if(GUID == 0)
        {
            GUID = Random.Range(int.MinValue, int.MaxValue);
        }
    }
#endif

}
