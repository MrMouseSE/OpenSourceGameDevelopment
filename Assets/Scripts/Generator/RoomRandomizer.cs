using UnityEngine;

namespace Generator
{
    public static class RoomRandomizer
    {
        public const int _maximumSize = 12;
        private const int _minimumSize = 2;
        
        public static void RandomizeNewRoom(RoomSettings roomSettings)
        {
            roomSettings.RoomSize = new Vector2Int(Random.Range(_minimumSize, _maximumSize), Random.Range(_minimumSize, _maximumSize));
            var roomArea = roomSettings.RoomSize.x * roomSettings.RoomSize.y;
            
            roomSettings.MaxNeighborhoodCount = Random.Range(1, 7);
            roomSettings.MaxInteriorsItems = Random.Range(0, roomArea / 4);
        }
    }
}