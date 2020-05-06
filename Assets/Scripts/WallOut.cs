using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOut : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {

  }

  private void OnCollisionEnter(Collision collision)
  {
    GameObject.Find("Master").GetComponent<GameMaster>().GameOver("次ファイト。");

  }
}
