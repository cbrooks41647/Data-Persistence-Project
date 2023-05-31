using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public InputField InputNameField;
   public void NewNameText(Text name)
    {
        MainManager.Instance.NameText = name;
    }

    //Need to figure out how to handle the name input
}
