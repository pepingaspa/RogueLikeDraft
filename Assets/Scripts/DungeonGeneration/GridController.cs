using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{

    public Room room;

    [System.Serializable]
    public struct Grid
    {
        public int colums, rows;
        public float verticalOffset, horizontalOffset;
    }

    public Grid grid;
    public GameObject gridTile;
    public List<Vector2> availablePoints = new List<Vector2>();

    private void Awake()
    {
        room = GetComponentInParent<Room>();
        grid.colums = room.width - 2;
        grid.rows = room.height - 2;
        GenerateGrid();
    }

    public void GenerateGrid()
    {
        grid.horizontalOffset += room.transform.localPosition.x;
        grid.verticalOffset += room.transform.localPosition.y;

        for(int y = 0; y < grid.rows; y++)
        {
            for(int x = 0; x < grid.colums; x++)
            {
                GameObject go = Instantiate(gridTile, transform);
                go.transform.position = new Vector2(x - (grid.colums - grid.horizontalOffset), y - (grid.rows - grid.verticalOffset));
                go.name = "X : " + x + " | Y : " + y;
                availablePoints.Add(go.transform.position);
                go.SetActive(false);
            }
        }

        GetComponentInParent<ObjectRoomSpawner>().InitialiseObjectSpawning();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
