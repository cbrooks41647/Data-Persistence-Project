using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField InputNameField;
   public void OnNameEdit(string name)
    {
        MainManager.Instance.NameText.text = name;
    }

    private void Start()
    {
        InputNameField.onEndEdit.AddListener(OnNameEdit);
    }
}
