using Steamworks;
using UnityEngine;

public class SteamworksTest : MonoBehaviour
{
    [SerializeField] private uint SteamAppId;

    private void Start()
    {
        SteamClient.Init(SteamAppId);

        SteamFriends.OnGameOverlayActivated +=
            active => Debug.Log($"[Steamworks] OnGameOverlayActivated. Active: {active}");
    }
}
