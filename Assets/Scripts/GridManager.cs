using System.Collections.Generic;
using System.Data;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public GameObject cellPrefab;
    public RectTransform gameField;
    float cellSize =100f; 

    public void CreateGrid(int rows, int columns)
    {
        // Очистка предыдущих ячеек, если они есть
        foreach (Transform child in gameField)
        {
            Destroy(child.gameObject);
        }
        // Рассчет смещения для центрирования
        float offsetX = (columns - 1) * cellSize / 2f;
        float offsetY = (rows - 1) * cellSize / 2f;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Vector3 cellPosition = new Vector2(
                    j * cellSize - offsetX, 
                    -(i * cellSize - offsetY)
                    ); 

                GameObject cell = Instantiate (cellPrefab,gameField);
                RectTransform rect = cell.GetComponent<RectTransform>();

                rect.anchorMin = new Vector2(0.5f, 0.5f);
                rect.anchorMax = new Vector2(0.5f, 0.5f);
                rect.pivot = new Vector2 (0.5f, 0.5f);
                
                rect.anchoredPosition = cellPosition;
                rect.sizeDelta = new Vector2(cellSize,cellSize);

                cell.AddComponent<CellController>();
            }
        }
    }
}