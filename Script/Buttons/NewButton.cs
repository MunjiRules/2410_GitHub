﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewButton : MonoBehaviour
{

    void Start() { 
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;
    }

}
