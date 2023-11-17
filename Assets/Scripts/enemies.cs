using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enemies : MonoBehaviour
{
    //VARIABLE FOR THE ENEMY TO MOVE EVERY 1 SECOND
    private float gridMoveTimer;
    private float gridMoveTimerMax = 1f;

    //MOVESPEED
    public float moveSpeed = 500f;

    //TEXT
    [SerializeField] private TextMeshProUGUI messsageText;

    //PANEL
    public GameObject gameOverPanel;

    private void Awake()
    {
        gameOverPanel.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        gridMoveTimer += Time.deltaTime;
        if (gridMoveTimer >= gridMoveTimerMax)
        {
            gridMoveTimer -= gridMoveTimerMax; // Timer is reset

            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime); //we start moving to the right
        }
    }

    //FUNCTION THAT FIRES WHEN IT DETECT A TRIGGER
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the enemy touches the edge, it changes direction and goes down one position.
        if (collision.gameObject.tag == "Boundary")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1);
            moveSpeed *= -1; //change direction
        }else if(collision.gameObject.tag == "BoundaryDown")
        {
            Time.timeScale = 0;
            Debug.Log("GAMEOVER");
            GameOverUI();
        }
    }

    private void GameOverUI()
    {
        gameOverPanel.SetActive(true);
        messsageText.text = "GAME OVER";
    }


}
