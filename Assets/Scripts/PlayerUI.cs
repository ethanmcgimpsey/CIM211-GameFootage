using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public int treasureCollected = 0;

    [SerializeField] private TextMeshProUGUI treasureText;
    [SerializeField] private GameObject winTrigger;

    private void Start()
    {
        winTrigger.SetActive(false);
    }

    void Update()
    {
        treasureText.text = treasureCollected.ToString() + " / 4";

        if (treasureCollected >= 4)
        {
            winTrigger.SetActive(true);
        }
    }
}
