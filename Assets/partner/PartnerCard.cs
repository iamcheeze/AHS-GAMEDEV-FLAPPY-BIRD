using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PartnerCard : MonoBehaviour
{
    public Image img;
    public TextMeshProUGUI textMeshProTitle;
    public TextMeshProUGUI textMeshProDesc;
    public TextMeshProUGUI textMeshProLink;

    public List<string> titleTexts;
    public List<string> linkTexts;
    public List<string> descTexts;
    public List<Sprite> imgs;

    int chosenNum;
    private int prevInt = -1;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        ChoosePartnerCard();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            ChoosePartnerCard();
            anim.Play("Bounce");
        }
    }

    void ChooseWhich()
    {
        int currInt;
        do
        {
            currInt = Random.Range(0, 7);
        } while (prevInt == currInt);

        prevInt = currInt;

        chosenNum = currInt;
    }

    void ChoosePartnerCard()
    {
        ChooseWhich();
        textMeshProTitle.text = titleTexts[chosenNum];
        textMeshProLink.text = linkTexts[chosenNum];
        textMeshProDesc.text = descTexts[chosenNum];
        img.sprite = imgs[chosenNum];
    }
}
