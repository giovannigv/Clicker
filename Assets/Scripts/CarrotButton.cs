using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotButton : MonoBehaviour
{
    public int carrotPrice = 2;
    public void ProduceCarrot() {
        if(CoinGlobal.coinCount > 0) {
            CoinGlobal.coinCount -= 1;
            CarrotGlobal.carrotCount += 1;
        }
    }

    public void SellCarrot(int x) {
        if(CarrotGlobal.carrotCount > 0) {
            CarrotGlobal.carrotCount -= 1;
            CoinGlobal.coinCount += carrotPrice;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
