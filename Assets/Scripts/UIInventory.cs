using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backBtn;
    public Button BackBtn => backBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    public void Back()
    {
        UIManger.instance.BacktoMain();
    }
}
