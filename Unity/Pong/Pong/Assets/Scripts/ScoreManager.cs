using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text text;
    private int count;

    // Use this for initialization
    void Start () {
		text.text = "";
        count = 0;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "rightWall")
        {
            count = count + 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + count;
    }
}
