using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Grid grid;

    public void Setup(Grid grid)
    {
        // levelGrid de snake = levelGrid que viene por par�metro
        this.grid = grid;
    }
}
