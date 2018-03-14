using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using SocketIO;

public class Network : MonoBehaviour
{
    static SocketIOComponent socket;
    //public GameObject playerPrefab;

    //Dictionary<string, GameObject> players;

    // Use this for initialization
    void Start()
    {
        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);
        socket.On("get data", GetData);
        socket.On("spawn player", OnSpawned);
        //socket.On("disconnected", OnDisconnected);
        //socket.On("move", OnMove);
        //players = new Dictionary<string, GameObject>();
    }

    // Tells us we are connected
    void OnConnected(SocketIOEvent e)
    {
        Debug.Log("We are Connected");
        //socket.Emit ("getName", GetName);
    }

    void GetData(SocketIOEvent e)
    {
        var playerName = "NAME"; //PlayerPrefs.GetString("playerName");
        Debug.Log(playerName);
    }

    void OnSpawned(SocketIOEvent e)
    {
        Debug.Log("Player Spawned!" + e.data);

    }

    //void Update()
    //{
    //    socket.Emit(PlayerPrefs.GetString("playerName"));
    //}

    float GetFloatFromJson(JSONObject data, string key)
    {
        return float.Parse(data[key].ToString().Replace("\"", ""));
    }
}
