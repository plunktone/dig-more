using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject cellPrefab;
    public Transform gameField;
    public float cellSize = 1.0f; 

    public void CreateGrid(int rows, int columns)
    {
        Bounds fieldBounds = CalculateGameFieldBounds(rows, columns);

        float startX = gameField.position.x - fieldBounds.size.x / 2 + cellSize / 2;
        float startY = fieldBounds.size.y / 2 - cellSize / 2;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Vector3 cellPosition = new Vector3(startX + j * cellSize, startY - i * cellSize, 0); 
                Instantiate(cellPrefab, cellPosition, Quaternion.identity, gameField);
            }
        }
    }

    private Bounds CalculateGameFieldBounds(int rows, int columns)
    {
        float fieldWidth = columns * cellSize;
        float fieldHeight = rows * cellSize;

        return new Bounds(gameField.position, new Vector3(fieldWidth, fieldHeight, 0));
    }
}