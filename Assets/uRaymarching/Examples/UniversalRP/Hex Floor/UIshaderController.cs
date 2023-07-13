using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class UIshaderController : MonoBehaviour
{
     public Transform UI;
    private Material r_material;
    public Vector4 r_sphere;
    public float r_radius;

    public Vector4 r_box;
    public float r_boxSphereSmooth;



    private void Start()
    {
        r_material = GetComponent<MeshRenderer>().sharedMaterial;
        Debug.Log("material"+ r_material);
    }

    public MovementControlNetwork _mvtCtrlNetwork;

    //public Material raymarchingMaterial
    //{
    //    get
    //    {
    //        if (!r_material && r_shader)
    //        {
    //            r_material = new Material(r_shader);
    //            r_material.hideFlags = HideFlags.HideAndDontSave;
    //        }
    //        return r_material;
    //    }
    //}
    private void Update()
    {

        //r_material.SetFloat("radius1", _mvtCtrlNetwork.leftTilt);
        //r_material.SetFloat("cubeSide", _mvtCtrlNetwork.rightTilt);
        //Vector3 UIpos = UI.transform.position;
        //Vector3 right = _mvtCtrlNetwork.gameObject.transform.right;
        //r_material.SetVector("r_sphere", r_sphere + new Vector4(UIpos.x, UIpos.y, UIpos.z) + _mvtCtrlNetwork.lerpDt * new Vector4(right.x, right.y, right.z) / 2);
        //r_material.SetVector("r_box", r_box + new Vector4(UIpos.x - _mvtCtrlNetwork.lerpDt / 2, UIpos.y, UIpos.z) - _mvtCtrlNetwork.lerpDt * new Vector4(right.x, right.y, right.z) / 2);


        r_material.SetVector("r_sphere",new Vector4(.2f,.2f,.2f,.2f));
        r_material.SetVector("r_box",new Vector4(.3f,.3f,.3f,.3f));


    }
}
