using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

// Script responsável por exibir informações de um artefato egípcio
// quando o usuário interage com ele no ambiente VR
public class ArtifactInfoPanel : MonoBehaviour
{
    [Header("Informações do Artefato")]
    public string nomeArtefato = "Nome do Artefato"; // Nome exibido no painel
    [TextArea] public string descricaoArtefato = "Descrição do artefato egípcio."; // Texto histórico do artefato

    [Header("UI do Painel")]
    public GameObject painelUI; // Painel que será exibido/ocultado
    public TextMeshProUGUI textoNome; // Componente de texto para o nome
    public TextMeshProUGUI textoDescricao; // Componente de texto para a descrição

    // Referência ao componente de interação XR
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;

    void Start()
    {
        // Oculta o painel ao iniciar a cena
        if (painelUI != null)
            painelUI.SetActive(false);

        // Obtém o componente de interação e registra o evento de seleção
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
        if (interactable != null)
            interactable.selectEntered.AddListener(AbrirPainel);
    }

    // Chamado quando o usuário interage com o artefato
    void AbrirPainel(SelectEnterEventArgs args)
    {
        // Exibe o painel e preenche com as informações do artefato
        if (painelUI != null)
            painelUI.SetActive(true);
        if (textoNome != null)
            textoNome.text = nomeArtefato;
        if (textoDescricao != null)
            textoDescricao.text = descricaoArtefato;
    }

    // Fecha o painel — chamado pelo botão de fechar na UI
    public void FecharPainel()
    {
        if (painelUI != null)
            painelUI.SetActive(false);
    }

    // Remove o listener ao destruir o objeto, evitando memory leak
    void OnDestroy()
    {
        if (interactable != null)
            interactable.selectEntered.RemoveListener(AbrirPainel);
    }
}