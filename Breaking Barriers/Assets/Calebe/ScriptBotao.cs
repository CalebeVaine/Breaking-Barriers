using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptBotao : MonoBehaviour
{
    public string Iniciargame;
    private void Start()
    {
        Button botao = GetComponent<Button>();
        botao.onClick.AddListener(iniciargame);
    }

    public void iniciargame()
    {
        SceneManager.LoadScene(Iniciargame);
    }



}