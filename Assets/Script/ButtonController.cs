using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class ButtonController : MonoBehaviour
{

    public Button submit;
    public TMP_InputField input;
    public TMP_Text UiText;

    // Start is called before the first frame update
    void Start()
    {
        submit.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void OnButtonClick()
    {
        UiText.text = input.text;

        UiText.fontSize += 1;
    }
}
