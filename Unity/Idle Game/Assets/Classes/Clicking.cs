using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicking : MonoBehaviour {

    public int purchased;
    public int startPrice;
    public int costToBuy;
    public int moneyToGet;
    public Text moneyText;

	void Start () {
		


	}
    void ButtonClick () {
        purchased++;
        costToBuy = startPrice * purchased;

    }
}
