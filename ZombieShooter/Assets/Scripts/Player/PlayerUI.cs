using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promtpText;
    void Start()
    {
        
    }

    public void UpdateText(string promptMessage)
    {
        promtpText.text = promptMessage;
    }
}
