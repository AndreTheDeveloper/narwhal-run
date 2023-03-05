using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin_controller : MonoBehaviour
{
    public GameObject mainObject;
    public string playerTag;
    public TMP_Text myTMPText;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.CompareTag(playerTag)) {
            Destroy(gameObject);
        
            int currentValue = int.Parse(myTMPText.text);
            currentValue++;
            myTMPText.text = currentValue.ToString();
            
        }
    }
}
