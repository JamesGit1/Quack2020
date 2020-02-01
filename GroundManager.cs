using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public Sprite TiledImage;
    public int HorSize = 25;
    public int VerSize = 25;

    // Start is called before the first frame update
    void Start()
    {
        var offset = new Vector3(0 - HorSize / 2, 0 - VerSize / 2, 0);
        for(int x = 0; x<HorSize; x++)
        {for(int y = 0; y < VerSize; y++)
            {
                var tile = new GameObject();
                tile.transform.position = new Vector3(x, y, 0) + offset;
                var spriteRenderer = tile.AddComponent<SpriteRenderer>();
                spriteRenderer.sprite = TiledImage;
                tile.name = "terrain" + tile.transform.position;
                tile.transform.parent = transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
