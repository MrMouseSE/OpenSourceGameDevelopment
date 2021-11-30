using UnityEngine;

namespace Generator
{
    public static class SpaceChecker
    {
        public static bool IsSpaceForRoomBusy(RoomSettings roomSettings)
        {
            Collider[] results = {};
            Physics.OverlapBoxNonAlloc(new Vector3(roomSettings.RoomPosition.x, 0, roomSettings.RoomPosition.y),
                new Vector3((float)roomSettings.RoomSize.x / 2, 1, (float)roomSettings.RoomSize.y / 2), results, Quaternion.identity);
            return results.Length > 0;
        }
    }
}