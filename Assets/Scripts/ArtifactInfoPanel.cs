using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class ArtifactInfoPanel : MonoBehaviour
{
    [Header("Informações do Artefato")]
    public string nomeArtefato = "Nome do Artefato";
    [TextArea] public string descricaoArtefato = "Descrição do artefato egípcio.";

    [Header("UI do Painel")]
    public GameObject painelUI;
    public TextMeshProUGUI textoNome;
    public TextMeshProUGUI textoDescricao;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;

    void Start()
    {
        if (painelUI != null)
            painelUI.SetActive(false);

        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
        if (interactable != null)
            interactable.selectEntered.AddListener(AbrirPainel);
    }

    void AbrirPainel(SelectEnterEventArgs args)
    {
        if (painelUI != null)
            painelUI.SetActive(true);

        if (textoNome != null)
            textoNome.text = nomeArtefato;

        if (textoDescricao != null)
            textoDescricao.text = descricaoArtefato;
    }

    public void FecharPainel()
    {
        if (painelUI != null)
            painelUI.SetActive(false);
    }

    void OnDestroy()
    {
        if (interactable != null)
            interactable.selectEntered.RemoveListener(AbrirPainel);
    }
}