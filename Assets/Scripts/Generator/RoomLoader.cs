using System;
using Generator;
using UnityEngine;

public class RoomLoader : MonoBehaviour
{
    public RoomPartsContainer RoomParts;

    private RoomPartsInstantiator _partsInstantiator;

    private void Awake()
    {
        _partsInstantiator = new RoomPartsInstantiator(RoomParts);
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        GenerateRoom(new Vector2Int(0,0));
    }

    private void GenerateRoom(Vector2Int roomPosition)
    {
        RoomSettings roomSettings = new RoomSettings();
        roomSettings.RoomPosition = roomPosition;
        RoomRandomizer.RandomizeNewRoom(roomSettings);

        if (SpaceChecker.IsSpaceForRoomBusy(roomSettings))
        {
            _partsInstantiator.InstantiateRoomParts(roomSettings);
        }
    }
}