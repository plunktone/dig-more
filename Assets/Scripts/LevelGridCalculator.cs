using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class LevelGridCalculator : MonoBehaviour
{

public int CalculateRows(int level)
{
    if (level<5) {
        return 9;
    }
     else return 3;
}
public int CalculateColumns(int level)
{
    if (level<5) {
        return 5;
    }
    else return 3;
    
}


}
