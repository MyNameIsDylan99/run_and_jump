using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelSettings : ScriptableObject
{

    public float Gravity = -30;
    public AudioClip BackgroundMusic;
    public Sprite Background;
}
