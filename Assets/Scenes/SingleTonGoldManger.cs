using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleTonGoldManger : MonoBehaviour
{                                     
    public static SingleTonGoldManger Instance { get; private set; }//겟퍼와 셋퍼
    private int gold = 0;
    private TextMeshProUGUI goldTextMesh;
    private void Awake()
    {
        /* Instance = this;*///값을 대입 이럴땐set을 호출함 private이니까 내부에서만 수정가능하고
                             //get만 퍼플릭으로 허용해주겠다.
        if (Instance != null && Instance != this)
        {
            Debug.Log("중복된 개체가 만들어져서 파괴됨");
            Destroy(gameObject);
            return;
        
        }
        Instance = this;
        SceneManager.sceneLoaded += OnSceneLoaded;
        //선택적인 구현.
       /* DontDestroyOnLoad(this);*///아무런 소용없다.
        DontDestroyOnLoad(gameObject);//씬이 변경되더라도 파괴되지않도록 등록을 시키는것임

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { gold++;
            ChangeGoldText();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        { SwitchScene(); 
        }
    }
    private void SwitchScene()
    { 
    
    string current = SceneManager.GetActiveScene().name;//이름을 받아와서 알아낼수있음
        string nextSceneName = (current == "BATTLEscene") ? "samplescene" : "BATTLEscene";
        SceneManager.LoadScene(nextSceneName);

    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)//커스텀메소드
    {

        Debug.Log($"로드된 씬{scene.name}");

    }
    private void ChangeGoldText()
    {
        GameObject.Find("GoldText").TryGetComponent<TextMeshProUGUI>(out goldTextMesh);
        goldTextMesh.text = $"Gold {gold}";
    }
}
