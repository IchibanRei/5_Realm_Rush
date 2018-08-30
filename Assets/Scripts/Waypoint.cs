using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {


    // public is OK in a data class
    public bool isExplored = false;
    public Waypoint exploredFrom;
    public bool IsPlaceable = true;

    [SerializeField] Tower towerPrefab;

    Vector2Int gridPos;

    const int gridSize = 10;

    public int GetGridSize()
    {
        return gridSize;
    }

    public Vector2Int GetGridPos()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / gridSize),
            Mathf.RoundToInt(transform.position.z / gridSize)
        );
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (IsPlaceable)
            {
                print(gameObject.name + " clicked");
                AddNewTower();
            }
            else
            {
                print("Not placeable here");
            }
        }
    }

    private void AddNewTower()
    {
        Instantiate(towerPrefab, transform.position, Quaternion.identity);
        IsPlaceable = false;
        print("Tower Added");
    }
}
