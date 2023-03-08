using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScoreOfPlayer : MonoBehaviour
{
    [SerializeField] private Text _scoreValueText;

    // �� ������ �������������
    private void Start() { EventManager.changeScoreInterface += onChangeScoreInterface;
        EventManager.changeScoreInterface?.Invoke(PlayerController.GetScoreOfPlayer());
    }

    // ��� ����������� ������ ������������
    private void OnDestroy() { EventManager.changeScoreInterface -= onChangeScoreInterface; }

    private void onChangeScoreInterface(Score score)
    {
        _scoreValueText.text = score.GetScore().ToString();
    }


}
