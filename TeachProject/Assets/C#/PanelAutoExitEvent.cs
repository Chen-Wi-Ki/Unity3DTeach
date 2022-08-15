using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAutoExitEvent : MonoBehaviour
{
    public Text TimeText;
    public GameObject StartButtonObj;
    // Start is called before the first frame update
    public void CallAutoExitEvent()
    {
        StartCoroutine(SetTimeOut());
    }

    IEnumerator SetTimeOut()
    {
        TimeText.text = "6";
        yield return new WaitForSeconds(1.0f);
        TimeText.text = "5";
        yield return new WaitForSeconds(1.0f);
        TimeText.text = "4";
        yield return new WaitForSeconds(1.0f);
        TimeText.text = "3";
        yield return new WaitForSeconds(1.0f);
        TimeText.text = "2";
        yield return new WaitForSeconds(1.0f);
        TimeText.text = "1";
        yield return new WaitForSeconds(1.0f);
        gameObject.SetActive(false);
        StartButtonObj.SetActive(true);
    }
}
