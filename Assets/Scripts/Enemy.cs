using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   /* private enum Direction
    {
        Left,
        Right,
        Down,
        Up
    }*/

   
   //VARIABLES
    private Grid grid;

    private Vector2Int gridPosition; // Posici�n 2D
    private Vector2Int startGridPosition;

    private float horizontalInput, verticalInput;

    private float gridMoveTimer;
    private float gridMoveTimerMax = 1f; // El enemigo se mover� a cada segundo

    //private Vector3 _directionRight = Vector2.right; // Direcci�n del enemigo
    //private Vector3 _directionLeft = Vector2.left; // Direcci�n del enemigo

    private float speed = 5f; //velocity
    

    public void Setup(Grid grid)
    {
        // levelGrid de snake = levelGrid que viene por par�metro
        this.grid = grid;
    }

    private void Update()
    {
        Movement();
    }

    private void Awake()
    {
        startGridPosition = new Vector2Int(0, 0);
        gridPosition = startGridPosition;
    }

    private void Movement()
    {
        gridMoveTimer += Time.deltaTime;
        if (gridMoveTimer >= gridMoveTimerMax)
        {
            gridMoveTimer -= gridMoveTimerMax; // Se reinicia el temporizador

            //this.transform.position += _directionRight * speed * Time.deltaTime; //right movement

        }
    }

    
}
