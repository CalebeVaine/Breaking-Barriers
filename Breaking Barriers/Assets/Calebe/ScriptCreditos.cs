using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptCreditos : MonoBehaviour
{
    public string Irparacreditos;

    private void Start()
    {
        Button botao = GetComponent<Button>();
        botao.onClick.AddListener(irparacreditos);

    }
    public void irparacreditos()
    {
        SceneManager.LoadScene (Irparacreditos);
    }

}