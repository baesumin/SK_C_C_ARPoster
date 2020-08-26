using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonManager1 : MonoBehaviour
{
    [SerializeField]
    GameObject image_target1;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (image_target1.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled == true)
        {
            image_target1.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.Lerp(image_target1.transform.GetChild(0).GetComponent<SpriteRenderer>().color, new Color(0, 0, 0), Time.deltaTime);
        }
        else
        {
            image_target1.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
        }
        
    }
    public void OnBackClick()
    {

    }
    
}
