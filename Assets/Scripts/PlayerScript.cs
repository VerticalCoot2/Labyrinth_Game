using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private int collectibles = 0;
    [SerializeField] private GameObject colHolder;
    int maxCol;

    [SerializeField] private GameObject winnerRoomDoor;
    void Start()
    {
        maxCol = colHolder.transform.childCount;
        winnerRoomDoor.SetActive(true);
    }
    void Update()
    {
        if(collectibles == maxCol)
        {
            winnerRoomDoor.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        switch(col.gameObject.tag)
        {
            case "collectible":
                collectibles++;
                Destroy(col.gameObject);
                break;
        }
    }
}
