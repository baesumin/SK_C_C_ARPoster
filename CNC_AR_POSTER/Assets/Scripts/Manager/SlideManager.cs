using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideManager : MonoBehaviour
{
    [SerializeField]
    GameObject Panel;
    [SerializeField]
    GameObject Slider;
    [SerializeField]
    int state;
    [SerializeField]
    GameObject Home;
    [SerializeField]
    GameObject Apply;
    [SerializeField]
    GameObject Question;
    [SerializeField]
    GameObject My;
    [SerializeField]
    RectTransform BackGround;

    UserManager UM;

    float duration = 0.2f;
    float smoothness = 0.02f;
    void Start()
    {
        UM = GameObject.Find("UserManager").GetComponent<UserManager>();
        Home.GetComponent<RawImage>().color = new Color(240 / 255f, 240 / 255f, 240 / 255f);
    }
    public void OnHomeClick()
    {
        if (state != 0)
        {
            Panel.SetActive(false);
            Slider.GetComponent<RectTransform>().localPosition = new Vector2(-600, 0);
            Slider.SetActive(false);
            state = 0;
            BackGround.localPosition = new Vector2(0, 0);
            Home.GetComponent<RawImage>().color = new Color(240 / 255f, 240 / 255f, 240 / 255f);
            Apply.GetComponent<RawImage>().color = new Color(1, 1, 1);
            Question.GetComponent<RawImage>().color = new Color(1, 1, 1);
            My.GetComponent<RawImage>().color = new Color(1, 1, 1);
        }
    }
    public void OnApplyClick()
    {
        if (state != 1)
        {
            Panel.SetActive(false);
            Slider.GetComponent<RectTransform>().localPosition = new Vector2(-600, 0);
            Slider.SetActive(false);
            state = 1;
            BackGround.localPosition = new Vector2(720, 1280);
            Home.GetComponent<RawImage>().color = new Color(1, 1, 1);
            Apply.GetComponent<RawImage>().color = new Color(240 / 255f, 240 / 255f, 240 / 255f);
            Question.GetComponent<RawImage>().color = new Color(1, 1, 1);
            My.GetComponent<RawImage>().color = new Color(1, 1, 1);
        }
    }
    public void OnQuestionClick()
    {
        if (state != 2)
        {
            Panel.SetActive(false);
            Slider.GetComponent<RectTransform>().localPosition = new Vector2(-600, 0);
            Slider.SetActive(false);
            state = 2;
            BackGround.localPosition = new Vector2(0, 1280);
            Home.GetComponent<RawImage>().color = new Color(1, 1, 1);
            Apply.GetComponent<RawImage>().color = new Color(1, 1, 1);
            Question.GetComponent<RawImage>().color = new Color(240 / 255f, 240 / 255f, 240 / 255f);
            My.GetComponent<RawImage>().color = new Color(1, 1, 1);
        }
    }
    public void OnMyClick()
    {
        if (state != 3)
        {
            Panel.SetActive(false);
            Slider.GetComponent<RectTransform>().localPosition = new Vector2(-600, 0);
            Slider.SetActive(false);
            state = 3;
            BackGround.localPosition = new Vector2(-720, 1280);
            Home.GetComponent<RawImage>().color = new Color(1, 1, 1);
            Apply.GetComponent<RawImage>().color = new Color(1, 1, 1);
            Question.GetComponent<RawImage>().color = new Color(1, 1, 1);
            My.GetComponent<RawImage>().color = new Color(240 / 255f, 240 / 255f, 240 / 255f);

            Text t = GameObject.Find("Text (7)").GetComponent<Text>();
            t.text = UM.SVPoint.ToString();
        }
    }
    public void OnSlideClick()
    {
        Panel.SetActive(true);
        Slider.SetActive(true);
        Text t = GameObject.Find("Text(2)").GetComponent<Text>();
        t.text = UM.SVPoint.ToString();
        Vector2 v = new Vector2(-120, 0);
        StartCoroutine("LerpPos", v);
    }
    public void OnPanelClick()
    {
        Panel.SetActive(false);
        Slider.GetComponent<RectTransform>().localPosition = new Vector2(-600, 0);
        Slider.SetActive(false);
    }
    IEnumerator LerpPos(Vector2 v)
    {
        float progress = 0;
        float increment = smoothness / duration;
        while (progress < 1)
        {
            Slider.GetComponent<RectTransform>().localPosition = Vector2.Lerp(Slider.GetComponent<RectTransform>().localPosition, v, progress);
            progress += increment;
            yield return new WaitForSeconds(smoothness);
        }
    }
}
