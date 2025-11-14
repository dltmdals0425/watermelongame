using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class samplescene : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        { changegold(5); }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("BATTLEscene");
        }
    }
}
