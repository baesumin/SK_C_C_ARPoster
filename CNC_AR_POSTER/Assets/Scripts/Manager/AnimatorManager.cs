using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField]
    GameObject Quad;
    [SerializeField]
    GameObject Quad2;
    [SerializeField]
    GameObject img;
    [SerializeField]
    GameObject img2;
    [SerializeField]
    GameObject text;
    [SerializeField]
    GameObject text2;
    [SerializeField]
    GameObject Video;

    UserManager UM;

    [SerializeField]
    int check = 0;
    void Start()
    {
        UM = GameObject.Find("UserManager").GetComponent<UserManager>();
    }
    public void OnPresentClick()
    {
        check = 2;
        img.SetActive(false);
        img2.SetActive(true);
        int point = Random.Range(100, 1000);
        text.GetComponent<Text>().text = point.ToString();
        UM.SVPoint += point;
        text.SetActive(true);
        text2.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Quad.GetComponent<MeshRenderer>().enabled == true)
        {
            if (check == 0) check = 1;
            Quad.GetComponent<Animator>().SetBool("IsRender", true);
        }
        else
        {
            //check = 0;
            Quad.GetComponent<Animator>().SetBool("IsRender", false);
        }

        if (Quad2.GetComponent<MeshRenderer>().enabled == true)
        {
            if (check == 0) check = 1;
            Quad2.GetComponent<Animator>().SetBool("IsRender", true);
            img.SetActive(true);
        }
        else
        {
            //check = 0;
            Quad2.GetComponent<Animator>().SetBool("IsRender", false);
        }

        if (Video.GetComponent<MeshRenderer>().enabled == true)
        {
            if (check == 0) check = 1;
            img.SetActive(true);
        }
        else
        {
            //check = 0;
        }

        if (check == 1)
        {
            img.SetActive(true);
            img2.SetActive(false);
            text.SetActive(false);
            text2.SetActive(false);
        }

    }
}
