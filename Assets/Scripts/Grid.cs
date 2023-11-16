using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    /*
    //GRID
    public static int row = 3;
    public static int column = 5;

    public GameObject enemyPrefab;

    //TWO-DIMENSIONAL ARRAY
    private int[,] positions = new int[row, column]; //FILA = I   COLUMN = J
    public GameObject[,] enemyArray;


    private void Start()
    {
        //enemyArray = new GameObject[row, column];
     

        //integer numbers array
        for (int i = 0;  i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (i == 0)
                {
                    positions[i, j] = Random.Range(0,0);
                    Debug.Log($"({i}, {j})");
                }

               // enemyArray[i, j] = (GameObject)Instantiate(enemyPrefab, new Vector3(i, j, 0), Quaternion.identity);
               // Debug.Log($"({i}, {j})");
            }
        }
    }

   
    /*private void PaintEnemies()
    {

    }*/
}
