using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GunStats : ScriptableObject
{
    public GameObject gunModel;
    [Range(1, 100)] public int shootDamage;
    [Range(25, 1000)] public int shootDistance;
    [Range(0.1f, 6)] public float shootRate;
    [Range(0.1f, 6)] public float reloadTime;
    [Range(1, 9)] public int projAmmount;
    
     public int ammoMax;
    public int magAmmount;
    public int magMax;
    public int ammoCurrent;
   

    public ParticleSystem hitEffect;
    public AudioClip shootSound;
    [Range(0, 1)] public float shootVol;
    public Image Icon;
}