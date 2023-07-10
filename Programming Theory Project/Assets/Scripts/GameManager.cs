using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private string nomeAmbiente;
    private int construcaoSelecionada;
    private int vegetacaoSelecionada;
    private int terrenoSelecionado;

    private void Awake()
    {
        // Garante que apenas uma instância do GameManager exista
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetNomeAmbiente(string nome)
    {
        nomeAmbiente = nome;
    }

    public string GetNomeAmbiente()
    {
        return nomeAmbiente;
    }

    public void SetConstrucaoSelecionada(int construcao)
    {
        construcaoSelecionada = construcao;
    }

    public int GetConstrucaoSelecionada()
    {
        return construcaoSelecionada;
    }

    public void SetVegetacaoSelecionada(int vegetacao)
    {
        vegetacaoSelecionada = vegetacao;
    }

    public int GetVegetacaoSelecionada()
    {
        return vegetacaoSelecionada;
    }

    public void SetTerrenoSelecionado(int terreno)
    {
        terrenoSelecionado = terreno;
    }

    public int GetTerrenoSelecionado()
    {
        return terrenoSelecionado;
    }
}
