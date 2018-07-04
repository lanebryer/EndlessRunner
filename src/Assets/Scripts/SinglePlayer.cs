﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SinglePlayer : MonoBehaviour {
    
    public void Start()
    {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(LoadScene);
    }

    public void LoadScene() {
        SceneManager.LoadScene("Level01");
    }
}
