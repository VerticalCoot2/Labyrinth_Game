using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Collectable assets")]
    [SerializeField] private int collectibles = 0;
    [SerializeField] private GameObject colHolder;
    int maxCol;

    [Header("\nWin assets")]
    [SerializeField] private GameObject winnerRoomDoor;
    [SerializeField] private GameObject winnerText;

    void Start()
    {
        maxCol = colHolder.transform.childCount;
        winnerRoomDoor.SetActive(true);
        winnerText.SetActive(false);
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
            case "Finish":
                winnerText.SetActive(true);
                break;

        }
    }
}
