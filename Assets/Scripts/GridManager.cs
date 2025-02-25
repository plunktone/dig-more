using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
public GameObject cellPrefab;
public Transform gameField;
public void CreateGrid(int rows, int columns)
{
    for(int i=0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            Vector3 cellPosition =gameField.position + new Vector3(j,i,0);
            Instantiate(cellPrefab,cellPosition,Quaternion.identity,gameField);
        }
    }

}
}
