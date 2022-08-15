using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButtonEvent : MonoBehaviour
{
    public Floor1MoveEvent _Floor1MoveEvent;
    public Square1MoveEvent _Square1MoveEvent;
    public GameObject PanelObj;

    public Square2TriggerEvent _Square2TriggerEvent;
    public Text _Text;
    public void QuitEvent()
    {
        PanelObj.SetActive(true);
        _Floor1MoveEvent.enabled = false;
        _Square1MoveEvent.enabled = false;
        gameObject.SetActive(false);

        switch (_Square2TriggerEvent.Level)
        {
            case 0:
                _Text.text = "視力判定:良好";
                break;
            case 1:
                _Text.text = "視力判定:近視約50度";
                break;
            case 2:
                _Text.text = "視力判定:近視約100度";
                break;
            case 3:
                _Text.text = "視力判定:近視約150度";
                break;
            case 4:
                _Text.text = "視力判定:近視約200度";
                break;
            case 5:
                _Text.text = "視力判定:近視約300度";
                break;
            case 6:
                _Text.text = "視力判定:近視300度以上";
                break;
            case 7:
                _Text.text = "視力判定:近視400度以上";
                break;
            case 8:
                _Text.text = "您需要去看眼科...";
                break;
            case 9:
                _Text.text = "您需要去看眼科...";
                break;
            case 10:
                _Text.text = "您需要去看眼科...";
                break;
            case 11:
                _Text.text = "您需要去看眼科...";
                break;
            case 12:
                _Text.text = "您需要去看眼科...";
                break;
            case 13:
                _Text.text = "您需要去看眼科...";
                break;
            default:
                _Text.text = "視力判定:超群卓越!!!";
                break;
        }
    }
}
