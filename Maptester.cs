using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maptester : MonoBehaviour
{
    //for moving rooms
    public int minX;
    public int minY;

    //size of rooms
    public int mapHieght;
    public int mapWidth;

    public GameObject mapContainer;
    public GameObject tilePrefab;
    public GameObject edgePrefab;
    public Vector2 tileSize = new Vector2(2, 2);

    public Map map;

    void Start()
    {
        //setup
        minX = 0;
        minY = 0;
        mapHieght = Random.Range(2, 20);
        mapWidth = Random.Range(2, 20);
        map = new Map();   
    }

    public void MakeMap()
    {
        //sets size
        map.NewMap(mapWidth, mapHieght);
        CreateGrid();
    }

    void CreateGrid()
    {        
        //local values
        var total = map.tiles.Length;
        var maxColumns = map.columns;
        var maxRows = map.rows;
        var column = 0;
        var row = 0;

        //setting tiles
        for(int i = 0; i < total; i++)
        {
            column = i % maxColumns;

            var newX = column * tileSize.x + minX;
            var newY = -row * tileSize.y + minY;

            var go = Instantiate(tilePrefab);
            go.name = "Tile " + i;
            go.transform.SetParent(mapContainer.transform);
            go.transform.position = new Vector3(newX, newY, 0);

            //setting edges
            //top
            if(newX==minX)
            {
                var gao = Instantiate(edgePrefab);
                gao.name = "Edge" + (newX - 2) + newY;
                gao.transform.position = new Vector3(newX - 2, newY, 0);
            }
            //bottom
            else if (newX == (minX + maxColumns*2)-2)
            {
                var gao = Instantiate(edgePrefab);
                gao.name = "Edge" + (newX + 2) + newY;
                gao.transform.position = new Vector3(newX + 2, newY, 0);
            }

            //left
            if (newY == minY)
            {
                var gao = Instantiate(edgePrefab);
                gao.name = "Edge" + newX + (newY + 2);
                gao.transform.position = new Vector3(newX, newY + 2, 0);
            }
            //right
            else if (newY == -(maxRows*2)+2+minY)
            {
                var gao = Instantiate(edgePrefab);
                gao.name = "Edge" + newX + (newY - 2);
                gao.transform.position = new Vector3(newX, newY -2, 0);
            }

            var sr = GetComponent<SpriteRenderer>();
            
            //new row
            if(column == (maxColumns - 1))
            {
                row++;
                column = 0;
            }
        }
    }
}
