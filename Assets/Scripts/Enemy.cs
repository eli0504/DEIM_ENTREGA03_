using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private enum Direction
    {
        Left,
        Right,
        Down,
        Up
    }

    private Grid grid;

    private Vector2Int gridPosition; // Posición 2D
    private Vector2Int startGridPosition;

    private float horizontalInput, verticalInput;

    private float gridMoveTimer;
    private float gridMoveTimerMax = 1f; // El enemigo se moverá a cada segundo
    private Direction gridMoveDirection; // Dirección del enemigo

    public void Setup(Grid grid)
    {
        // levelGrid de snake = levelGrid que viene por parámetro
        this.grid = grid;
    }

    private void Awake()
    {
        startGridPosition = new Vector2Int(0, 0);
        gridPosition = startGridPosition;

        gridMoveDirection = Direction.Right; // Dirección arriba por defecto
    }

    private void Movement()
    {

    }
}
