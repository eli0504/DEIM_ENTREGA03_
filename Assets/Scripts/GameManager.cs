using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private Grid grid;
    private Enemy enemy;

    private void Awake()
    {
        // Singleton
        if (Instance != null)
        {
            Debug.LogError("There is more than one Instance");
        }

        Instance = this;
    }

    private void Start()
    {

        // Configuración de enemigos
        GameObject enemyGameObject = new GameObject("enemy");
        SpriteRenderer enemySpriteRenderer = enemyGameObject.AddComponent<SpriteRenderer>();
        enemySpriteRenderer.sprite = GameAssets.Instance.enemySprite;
        enemy = enemyGameObject.AddComponent<Enemy>();  

        //configuración Grid
        grid = new Grid(15, 10);
        enemy.Setup(grid);
        grid.Setup(enemy);
    }
}
