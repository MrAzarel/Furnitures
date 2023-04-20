using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] public GameObject _upperCheckMark;
    [SerializeField] public GameObject _upperPanel;

    public bool _upperCheckMarkDowned = false;

    public void UpperCheckMarkBtn()
    {
        if (!_upperCheckMarkDowned)
        {
            _upperCheckMarkDowned = true;
            for (int i = 0; i < 100; i++)
            {
                Vector3 vectorCheck = _upperCheckMark.transform.position;
                Vector3 vectorPanel = _upperPanel.transform.position;
                _upperCheckMark.transform.position = new Vector3(vectorCheck.x, vectorCheck.y - 1, vectorCheck.z);
                _upperPanel.transform.position = new Vector3(vectorPanel.x, vectorPanel.y - 1, vectorPanel.z);
            }

            _upperCheckMark.transform.rotation = new Quaternion(0, 0, 180, 0);
        }
        else
        {
            _upperCheckMarkDowned = false;
            for (int i = 0; i < 100; i++)
            {
                Vector3 vectorCheck = _upperCheckMark.transform.position;
                Vector3 vectorPanel = _upperPanel.transform.position;
                _upperCheckMark.transform.position = new Vector3(vectorCheck.x, vectorCheck.y + 1, vectorCheck.z);
                _upperPanel.transform.position = new Vector3(vectorPanel.x, vectorPanel.y + 1, vectorPanel.z);
            }

            _upperCheckMark.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
