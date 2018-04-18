﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramid : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int maxHeight = 10;
        SpringJoint spring;
        GameObject gameObject;

        for (int height = 0; height < maxHeight; height++)
        {
            int length = maxHeight - height;
            for (int x = -length; x <= length; x++)
            {
                for (int z = -length; z <= length; z++)
                {
                    gameObject = Tools.MakeCapsule(x, height, z);
                    spring = gameObject.AddComponent<SpringJoint>();

                }

            }
        }

    }

	void Update () {
		
	}
}
