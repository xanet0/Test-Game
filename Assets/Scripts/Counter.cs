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
    // Переменная потери одного очка. Сделано для того, что-бы не сильно нагружать телефон
    public void loseCount()
    {
        count -= 1;
        CounterUI.text = count.ToString();
    }
    // Прибавление очка
    public void addCount()
    {
        count += 1;
        CounterUI.text = count.ToString();
    }
}
