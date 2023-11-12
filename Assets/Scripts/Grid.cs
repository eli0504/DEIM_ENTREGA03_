using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid 
{
    private int width;
    private int height;

    private Enemy enemy;

    public Grid(int w, int h)
    {
        width = w;
        height = h;
    }

    public void Setup(Enemy enemy)
    {
        this.enemy = enemy;
    }
}
