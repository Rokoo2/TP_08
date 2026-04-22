using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswordUI : MonoBehaviour
{
  
  public TextMeshProUGUI Txt_Resultado;

    // Start is called before the first frame update
    void Start()
    {
        CheckPassword();
    }

    public void CheckPassword()
    {
        Txt_Resultado.text = "Acá va el resultado";

    }


}
