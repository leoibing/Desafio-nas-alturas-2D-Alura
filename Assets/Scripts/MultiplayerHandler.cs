using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiplayerHandler : MonoBehaviourPunCallbacks
{
    void Start()
    {
		PhotonNetwork.ConnectUsingSettings();
    }

	public override void OnConnectedToMaster()
	{
		PhotonNetwork.JoinLobby();
	}

	public override void OnJoinedLobby()
	{
		PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions { MaxPlayers = 32 }, TypedLobby.Default);
	}

	public override void OnJoinedRoom()
	{
		PhotonNetwork.Instantiate("Player", new Vector3(-7.0f,0,0), Quaternion.identity);
	}
}
