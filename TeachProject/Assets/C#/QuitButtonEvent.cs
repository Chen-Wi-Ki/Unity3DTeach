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
                _Text.text = "���O�P�w:�}�n";
                break;
            case 1:
                _Text.text = "���O�P�w:�����50��";
                break;
            case 2:
                _Text.text = "���O�P�w:�����100��";
                break;
            case 3:
                _Text.text = "���O�P�w:�����150��";
                break;
            case 4:
                _Text.text = "���O�P�w:�����200��";
                break;
            case 5:
                _Text.text = "���O�P�w:�����300��";
                break;
            case 6:
                _Text.text = "���O�P�w:���300�ץH�W";
                break;
            case 7:
                _Text.text = "���O�P�w:���400�ץH�W";
                break;
            case 8:
                _Text.text = "�z�ݭn�h�ݲ���...";
                break;
            case 9:
                _Text.text = "�z�ݭn�h�ݲ���...";
                break;
            case 10:
                _Text.text = "�z�ݭn�h�ݲ���...";
                break;
            case 11:
                _Text.text = "�z�ݭn�h�ݲ���...";
                break;
            case 12:
                _Text.text = "�z�ݭn�h�ݲ���...";
                break;
            case 13:
                _Text.text = "�z�ݭn�h�ݲ���...";
                break;
            default:
                _Text.text = "���O�P�w:�W�s���V!!!";
                break;
        }
    }
}
