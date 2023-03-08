using UnityEngine;

public class Score
{
    //������ � canvas. ���������� ����
    private static uint _scoreValue;

    //�����������. ��������� ���������� �����
    public Score(uint scoreValue) { _scoreValue = scoreValue; }

    //setter ��� _scoreValue
    public uint GetScore() { return _scoreValue; }

    //���������� �����
    public void AddScore(uint newScoreValue) 
    { 
        _scoreValue += newScoreValue;
        EventManager.changeScoreInterface?.Invoke(PlayerController.GetScoreOfPlayer());
    }

}
