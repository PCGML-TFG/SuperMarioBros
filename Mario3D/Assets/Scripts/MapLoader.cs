﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        MapReader.GM.GenerateMap();
    }
}
