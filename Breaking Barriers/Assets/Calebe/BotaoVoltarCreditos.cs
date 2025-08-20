using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotaoVoltarCreditos : MonoBehaviour
{
    public string nomeCena;

    void Start()
    {
        Button botao = GetComponent<Button>();
        botao.onClick.AddListener(IrParaCena);
    }

    public void IrParaCena()
    {
        SceneManager.LoadScene(nomeCena);
    }
}
