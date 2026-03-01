using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    public TMP_Text chatText;

    void Start()
    {
        if (chatText != null)
        {
            chatText.text = "Hello World!";
            chatText.fontSize = 36;
            chatText.color = Color.black;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (cube != null)
            {
                Destroy(cube);

                if (chatText != null)
                {
                    chatText.text = "Кубик удален!";
                    chatText.color = Color.red;
                }
            }
        }
    }
}