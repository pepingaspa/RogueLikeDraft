using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{

    public DungeonGenerationData dungeonGenerationData;
    private List<Vector2Int> dungeonRooms;

    // Start is called before the first frame update
    void Start()
    {
        dungeonRooms = DungeonCrawlerController.GenerateDungeon(dungeonGenerationData);
        SpawnRooms(dungeonRooms);
            
    }

    private void SpawnRooms(IEnumerable<Vector2Int> rooms)
    {
        RoomController.instance.LoadRoom("Start", 0, 0);
        foreach(Vector2Int roomLocation in rooms)
        {
            //TODO : ajout plusieurs types de salle ici (avec random ?) . CF GetRandomRoomName
            RoomController.instance.LoadRoom(RoomController.instance.GetRandomRoomName(), roomLocation.x, roomLocation.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
