using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyNew : MonoBehaviour {

    public GameObject manager;
    public int buyPrice;
    public Text priceText;

    public void Update () {
        priceText.text = "Cost to unlock: " + buyPrice;
    }

    public void Unlock() {
        if(manager.GetComponent<GameStats> ().currMoney >= buyPrice) {
            manager.GetComponent<GameStats> ().currMoney -= buyPrice;
            Destroy (gameObject);
            }
    }
}
