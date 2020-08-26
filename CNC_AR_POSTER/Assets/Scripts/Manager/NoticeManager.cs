using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoticeManager : MonoBehaviour
{
    [SerializeField]
    GameObject panel;
    [SerializeField]
    GameObject InquiryText;
    [SerializeField]
    GameObject emailText;
    // Start is called before the first frame update
    public void OnSendClick()
    {
        panel.SetActive(true);
        InquiryText.GetComponent<Text>().text = null;
        emailText.GetComponent<Text>().text = null;
    }
    public void OnOKClick()
    {
        panel.SetActive(false);
    }
}
