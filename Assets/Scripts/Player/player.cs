using FishNet.Object;
using FishNet.Object.Synchronizing;
using UnityEngine;

public sealed class player : NetworkBehaviour
{
    [SyncVar]
    public string username;

    [SyncVar]
    public bool isReady;
}
