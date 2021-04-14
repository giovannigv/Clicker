using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CoinGlobal: MonoBehaviour
{
    // Start is called before the first frame update
    public static BigInteger coinCount;
    public GameObject coinDisplay;
    public BigInteger internalCoin;
    void Start()
    {
        coinCount = 10;
    }

    // Update is called once per frame
    void Update(){
        internalCoin = coinCount;
        coinDisplay.GetComponent<Text>().text = internalCoin.ToString();
    }

    //teste lukinhas
}
