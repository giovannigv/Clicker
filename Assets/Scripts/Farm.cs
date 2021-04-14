using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farm : MonoBehaviour
{
    [Header("Item Variables")]
    [Space]
    public long price;
    public long level;
    public string Name;
    public SpriteRenderer sprite;
    public long earn;
    public int time;
    

    [Header("GameObjects")]
    [Space]
    public GameObject priceDisplay;
    public GameObject levelDisplay;
    public GameObject nameDisplay;
    //public GameObject earnDisplay;
    public GameObject timeDisplay;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplaysItem();   
    }

    private void DisplaysItem() {
        priceDisplay.GetComponent<Text>().text = "$ " + price.ToString();
        levelDisplay.GetComponent<Text>().text = level.ToString();
        nameDisplay.GetComponent<Text>().text = Name.ToString();
        timeDisplay.GetComponent<Text>().text = time.ToString() + " seg";
        //earnDisplay.GetComponent<Text>().text = "$ " + earn.ToString();
    }

    public void SellFarm() {
        if(CoinGlobal.coinCount >= price) {
            CoinGlobal.coinCount -= price;
            level += 1;
            StartCoroutine(BuyFarm());
        }
    }
    
    private IEnumerator BuyFarm() {
        
        WaitForSecondsRealtime wait = new WaitForSecondsRealtime(time);

        while (true) {
            yield return wait;
            Debug.Log("Compra");
            CoinGlobal.coinCount += earn;

        }
    }
}
