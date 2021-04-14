using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class CarrotGlobal: MonoBehaviour
{
    // Start is called before the first frame update
    public static BigInteger carrotCount;
    public GameObject carrotDisplay;
    public BigInteger internalCarrot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        internalCarrot = carrotCount;
        carrotDisplay.GetComponent<Text>().text = internalCarrot.ToString();
    }
}
