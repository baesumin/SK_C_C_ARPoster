using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour
{
    [SerializeField]
    RectTransform BackGround;
    [SerializeField]
    RectTransform Notice1;
    [SerializeField]
    RectTransform Notice2;
    [SerializeField]
    Text text1;
    [SerializeField]
    Text text2;

    float duration = 0.2f;
    float smoothness = 0.02f;
    void Start()
    {
        Notice1.sizeDelta = new Vector2(Notice1.sizeDelta.x, 0);
        Notice2.sizeDelta = new Vector2(Notice1.sizeDelta.x, 0);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
    }
    public void OnApplyClick()
    {
        Vector2 v = new Vector2(720, BackGround.localPosition.y);
        StartCoroutine("LerpPos",v);
    }
    public void OnQuestionClick()
    {
        Vector2 v = new Vector2(-720, BackGround.localPosition.y);
        StartCoroutine("LerpPos",v);
    }
    public void OnBackClick()
    {
        Vector2 v = new Vector2(0, BackGround.localPosition.y);
        StartCoroutine("LerpPos",v);
    }
    public void OnNoticeClick()
    {
        BackGround.localPosition = new Vector2(BackGround.localPosition.x, -1280);
    }
    public void OnNoticeBackClick()
    {
        BackGround.localPosition = new Vector2(BackGround.localPosition.x, 0);
        Notice1.sizeDelta = new Vector2(Notice1.sizeDelta.x, 0);
        Notice2.sizeDelta = new Vector2(Notice1.sizeDelta.x, 0);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
    }
    public void OnNotice1Click()
    {
        Notice1.sizeDelta = new Vector2(Notice1.sizeDelta.x, 160);
        Notice2.sizeDelta = new Vector2(Notice1.sizeDelta.x, 0);
        text1.gameObject.SetActive(true);
        text2.gameObject.SetActive(false);
    }
    public void OnNotice2Click()
    {
        Notice1.sizeDelta = new Vector2(Notice1.sizeDelta.x, 0);
        Notice2.sizeDelta = new Vector2(Notice1.sizeDelta.x, 250);
        text1.gameObject.SetActive(false);
        text2.gameObject.SetActive(true);
    }
    IEnumerator LerpPos(Vector2 v)
    {
        float progress = 0;
        float increment = smoothness / duration;
        while (progress < 1)
        {
            BackGround.localPosition = Vector2.Lerp(BackGround.localPosition, v, progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);
        }
    }
    
}
