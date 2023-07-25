using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] playerPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = playerPrefabs[GameManager.Instance.chosenCar];
        Instantiate(player, player.transform.position, player.transform.rotation);
    }

}
