using UnityEngine;

namespace Generator
{
    [CreateAssetMenu(fileName = "RoomParts", menuName = "ScriptableObjects/RoomPartsContainer", order = 1)]
    public class RoomPartsContainer : ScriptableObject
    {
        public GameObject[] Walls;
        public GameObject[] WallsShort;
        public GameObject WallCorner;
        public GameObject WallCornerShort;
        [Space]
        public GameObject[] Floors;
        public GameObject[] Doors;
        public GameObject[] InteriorItems;
    }
}