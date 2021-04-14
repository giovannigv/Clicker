using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automate : MonoBehaviour
{
    public bool CreatingCarrot = false;
    public static int CarrotIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update() {
        InternalIncrease = CarrotIncrease;
        if(CreatingCarrot == false) {
            CreatingCarrot = true;
            StartCoroutine(CreateTheCarrot());
        }
    }
    //não associei a parte de ativar o botao, e preciso rever essa lógica

    IEnumerator CreateTheCarrot() {
        CoinGlobal.coinCount -= 1;
        CarrotGlobal.carrotCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCarrot = false;
    }
}
