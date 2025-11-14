using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class battlescene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goldtext;
    private int gold = 0;
   
    void changegold(int newgold)
    { 
        gold = newgold;
        goldtext.text = $"Gold{gold}";
    }
    private void Awake()
    {
        changegold(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) { changegold(gold+5); }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("samplescene");//씬을 교체해주는 메소드
        }
    }
}
