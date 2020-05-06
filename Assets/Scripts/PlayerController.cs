using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  void Start()
  {

  }

  void Update()
  {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position += transform.forward * 0.1f;
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      transform.position -= transform.forward * 0.1f;
    }
  }
}
