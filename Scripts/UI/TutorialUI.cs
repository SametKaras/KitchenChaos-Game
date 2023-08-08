using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI keyMoveUpText;
    [SerializeField] private TextMeshProUGUI keyMoveDownText;
    [SerializeField] private TextMeshProUGUI keyMoveLeftText;
    [SerializeField] private TextMeshProUGUI keyMoveRightText;
    [SerializeField] private TextMeshProUGUI keyMoveInteractText;
    [SerializeField] private TextMeshProUGUI keyMoveInteractAlternateText;
    [SerializeField] private TextMeshProUGUI keyMovePauseText;
    [SerializeField] private TextMeshProUGUI keyMoveGamepadInteractText;
    [SerializeField] private TextMeshProUGUI keyMoveGamepadInteractAlternateText;
    [SerializeField] private TextMeshProUGUI keyMoveGamepadPauseText;

    private void Start()
    {
        KitchenGameManager.Instance.OnStateChanged +=KitchenGameManager_OnStateChanged;

        UpdateVisual();

        Show();
    }

    private void KitchenGameManager_OnStateChanged(object sender, System.EventArgs e)
    {
        if (KitchenGameManager.Instance.IsCountdownToStartActive())
        {
            Hide();
        }
    }

    private void UpdateVisual()
    {

    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
