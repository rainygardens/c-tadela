using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRound : MonoBehaviour
{
    public GameObject Card1;
    public GameObject PlayerHand;
    
    List<GameObject> cardstack = new List<GameObject>();

    void Start()
    {
        cardstack.Add(Card1);
    }

    public void OnClick()
    {
        for (var i = 0; i <= 2; i++)
        {
            GameObject playerCard = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerHand.transform, false);
        }
    }
}
