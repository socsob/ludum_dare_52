using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonorColorController : MonoBehaviour
{
    [SerializeField] MeshRenderer hat; //(0)
    [SerializeField] MeshRenderer person; //skin (0) and shirt (3)
    [SerializeField] MeshRenderer stripe; //(0)
    [SerializeField] MeshRenderer hand1, hand2;
    [SerializeField] MeshRenderer foot1, foot2;


    public void setMaterials(Material skinMat, Material shirtMat, Material stripeMat, Material hatMat)
    {
        print("setting colors");
        person.materials[0].color = skinMat.color;
        person.materials[3].color = shirtMat.color;
        stripe.materials[0].color = stripeMat.color;
        hat.materials[0].color = hatMat.color;
        hand1.material.color = skinMat.color;
        hand2.material.color = skinMat.color;
        foot1.material.color = shirtMat.color;
        foot2.material.color = shirtMat.color;
    }
}
