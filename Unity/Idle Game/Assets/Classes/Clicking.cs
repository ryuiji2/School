using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Clicking : MonoBehaviour {

    public GameObject manager;
    public Text amBought;
    public bool autoclick;
    public float autoTime;
    public int autoCost;
    public Text autoText;
    public Text buttonMoney;
    public Text upgrade;
    public float priceIncr;
    public int purchased;
    public int startPrice;
    public int upgradeCost;
    public float startMoneyToGet;
    public float moneyToGet;
    private bool managerBought;

    private void Start () {
        autoText.text = " Manager: " + autoCost;
        }

    void Update() {
        buttonMoney.text = "" + moneyToGet;
        upgrade.text = "" + upgradeCost;
        amBought.text = "Bought: " + purchased;
        if(autoclick == true) {
            StartCoroutine (Automatic (autoTime));
            autoclick = false;
            }

	}
    void TheCoroutine () {
        StartCoroutine (Automatic (autoTime));

        }
    public void ButtonClick () {
        manager.GetComponent<GameStats> ().currMoney += moneyToGet;

    }
    public void UpgradeClick () {
        if (manager.GetComponent<GameStats> ().currMoney >= upgradeCost) {
            manager.GetComponent<GameStats> ().currMoney -= upgradeCost;
            purchased++;
            upgradeCost = startPrice * purchased;
            moneyToGet = startMoneyToGet * (purchased * priceIncr);
            }
        }
    public void Manager () {
        if (manager.GetComponent<GameStats> ().currMoney >= autoCost) {
            if (managerBought == false) {
                autoclick = true;
                managerBought = true;
                autoText.text = " Bought!";
                }
            }
        }

    IEnumerator Automatic(float timeTowait) {
        yield return new WaitForSeconds (timeTowait);
        manager.GetComponent<GameStats> ().currMoney += moneyToGet;
        TheCoroutine ();
        }
}
