using UnityEngine;
using UnityEngine.SceneManagement;

public class Health
{
    //������� ��������, ����������� �������� ��� ����������
    [SerializeField] protected uint _healthValue;
    [SerializeField] protected uint _MaxHaelthValue;

    //����������� ��������
    public Health(uint health, uint maxHaelthValue)
    {
        _healthValue = health;
        _MaxHaelthValue = maxHaelthValue;
    }

    //setter ��� _healthValue
    public uint GetHealth() { return _healthValue; }

    //setter ��� _MaxHaelthValue
    public uint GetMaxHaelth() { return _MaxHaelthValue; }

    //��������� �����
    public virtual void Damage(uint damageCalue) { _healthValue -= damageCalue; }

    //�������
    public virtual void Heal(uint healValue) { _healthValue += healValue;}

    //������
    public virtual void Kill() { _healthValue = 0; }
}
