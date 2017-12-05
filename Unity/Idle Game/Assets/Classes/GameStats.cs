using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour {

    public Text moneyText;
    public float currMoney;
	
	void Update () {
        moneyText.text = "" + currMoney;

	}
}
