using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecaoTerreno : MonoBehaviour
{
    public Button terreno1Button;
    public Button terreno2Button;
    public Button terreno3Button;

    private int terrenoSelecionado;

    private void Start()
    {
        terreno1Button.onClick.AddListener(() => SelecionarTerreno(1));
        terreno2Button.onClick.AddListener(() => SelecionarTerreno(2));
        terreno3Button.onClick.AddListener(() => SelecionarTerreno(3));
    }

    private void SelecionarTerreno(int terreno)
    {
        terrenoSelecionado = terreno;

        // Armazena o terreno selecionado em um objeto de dados ou gerenciador de jogo, se necessário
        GameManager.Instance.SetTerrenoSelecionado(terrenoSelecionado);// Exemplo:

        // Carrega a cena final correspondente ao terreno selecionado
        switch (terrenoSelecionado)
        {
            case 1:
                SceneManager.LoadScene("Final3");
                break;
            case 2:
                SceneManager.LoadScene("Final2");
                break;
            case 3:
                SceneManager.LoadScene("Final1");
                break;
        }
    }
}
