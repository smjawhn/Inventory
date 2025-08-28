using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backBtn;
    [SerializeField] private TMP_Text atkTxt;
    [SerializeField] private TMP_Text defTxt;
    [SerializeField] private TMP_Text hpTxt;
    [SerializeField] private TMP_Text criTxt;

    public Button BackBtn => backBtn;
    public TMP_Text AtkTxt => atkTxt;
    public TMP_Text DefTxt => defTxt;
    public TMP_Text HPTxt => hpTxt;
    public TMP_Text CriTxt => criTxt;


    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    public void Back()
    {
        UIManger.instance.BacktoMain();
    }
}
