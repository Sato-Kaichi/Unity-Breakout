using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDataFetcher : MonoBehaviour
{
  public Text resultMessageText;
  void Start()
  {
    resultMessageText.text = DataSender.resultMessage;
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.Space))
    {
      SceneManager.LoadScene("Title");
    }
  }
}
