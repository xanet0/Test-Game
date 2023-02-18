using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public TextMeshProUGUI CounterUI;
    public int count = 0;
    private void Start()
    {
        CounterUI.text = count.ToString();
    }
    // ���������� ������ ������ ����. ������� ��� ����, ���-�� �� ������ ��������� �������
    public void loseCount()
    {
        count -= 1;
        CounterUI.text = count.ToString();
    }
    // ����������� ����
    public void addCount()
    {
        count += 1;
        CounterUI.text = count.ToString();
    }
}
