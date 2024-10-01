using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public int gridX;
    public int gridY;

    public bool isWalkable;

    public int gCost; //경로값 g(n)
    public int hCost; //예측값 h(n)
    public Node parent;

    public Node(int gridY, int gridX, bool isWalkable)
    {
        this.gridX = gridX;
        this.gridY = gridY;
        this.isWalkable = isWalkable;
    }

    //최종값
    public int fCost
    {
        get { return gCost + hCost; }
    }
}
