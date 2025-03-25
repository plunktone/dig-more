using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentLevel=1;
    public LevelGridCalculator levelGridCalculator;
    public GridManager gridManager;

    void Start()
    {
        UpdateLevel(currentLevel);
    }
    public void UpdateLevel(int newLevel)
    {
        currentLevel = newLevel;
        UpdateGrid();
        Debug.Log(levelGridCalculator.CalculateRows(currentLevel));
        Debug.Log(" " + levelGridCalculator.CalculateRows(currentLevel));
    }

    void UpdateGrid()
    {
        int rows = levelGridCalculator.CalculateRows(currentLevel);
        int columns = levelGridCalculator.CalculateColumns(currentLevel);

       gridManager.CreateGrid(rows,columns);
    }

}
