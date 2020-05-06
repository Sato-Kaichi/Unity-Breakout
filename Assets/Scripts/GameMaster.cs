﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

  public int boxNum;
  public float nowTime;
  void Start()
  {
    nowTime = 0;
  }

  void Update()
  {
    nowTime += Time.deltaTime;
    if (boxNum <= 0)
    {
      GameOver(nowTime.ToString("F0") + "秒でクリアできた！");
    }
  }

  public void GameOver(string resultMessage)
  {
    DataSender.resultMessage = resultMessage;
    SceneManager.LoadScene("Result");
  }
}
