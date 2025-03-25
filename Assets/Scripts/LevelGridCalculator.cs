using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class LevelGridCalculator : MonoBehaviour
{

public int CalculateRows(int level)
{
    if (level<5) 
    {
        return 4;
    }
    if (level>5||level<10) 
    {
        return 6;
    }
    
    else return 3;
}
public int CalculateColumns(int level)
{
    if (level<5) {
        return 8;
    }
    if (level>5||level<10)
    {
        return 10;
    }
    else return 3;
    
}


}
