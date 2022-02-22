using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCollision : MonoBehaviour
{
    public int point = 0;
    public Text ClockScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClockScore.text = "Clock: " + point;
    }

    
}
