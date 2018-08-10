﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour {
    [SerializeField] [Range(1f, 20f)] float gridSize = 10f;
    TextMesh textMesh;
	// Update is called once per frame
	void Update ()
    {
        Vector3 snapPos;

        

        snapPos.x = Mathf.Round(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.Round(transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = snapPos.x / gridSize + "," + snapPos.z / gridSize;
        textMesh.text = labelText;
        gameObject.name = "Cube " + labelText;
    }
}