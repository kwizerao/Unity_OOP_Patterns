using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPresenter : MonoBehaviour
{
    [Header("UI References")]
    public TextMeshProUGUI TrashText;
    public TextMeshProUGUI ObstacleText;
    public TextMeshProUGUI ScoreText;


    private void Start()
    {
        UpdateTrash();
        UpdateObstacles();
        UpdateScore();
    }


    public void UpdateTrash()
    {
        TrashText.text = "Trash :" + "<color=yellow>" +  GManager.Instance.trash + "</color>";
    }

    public void UpdateObstacles()
    {
        ObstacleText.text = "Obstacles :" + "<color=yellow>" + GManager.Instance.obstacles + "</color>";
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score :" + "<color=yellow>" + GManager.Instance.score + "</color>";
    }

}

