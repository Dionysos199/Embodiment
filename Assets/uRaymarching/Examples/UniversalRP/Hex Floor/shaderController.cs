using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class shaderController : MonoBehaviour
{
     public Transform UI;
    private Material r_material;
    public float r_maxDistance;
    public Vector3 r_modInterval;
    public Vector4 r_sphere;
    public float r_radius;

    public Vector4 r_box;
    public Vector4 r_sphere2;
    public float r_boxSphereSmooth;
    public float r_boxRound;
    public float r_sphereIntersectSmooth;
    public float r_shadowIntensity;
    public float r_lightIntensity;
    public Vector2 r_shadowDistance;
    public Color r_lightColor;
    public float r_shadowPenumbra;
    public int r_maxIterations;
    public float r_accuracy;
    public Transform r_light;
    public Color r_color;
    public int r_ambientIterations;
    public float r_ambientIntesity;
    public float r_ambientSteps;


    [Header("fractals")]
    public Vector3 _mandleBrot1;
    public Vector4 _mandleBrotColor1;
    public float _power;


    public Vector4 r_sphere4;
    public float r_sphereSmooth;
    public float r_degreeRotate;
    public float r_rotationDegree;

    public int r_reflectionCount;
    public float r_reflectionIntensity;
    public float r_environmentIntensity;
    public Cubemap r_reflectionCube;

    public MovementControlNetwork _mvtCtrlNetwork;

    [SerializeField]
    private Shader r_shader;
    public Material raymarchingMaterial
    {
        get
        {
            if (!r_material && r_shader)
            {
                r_material = new Material(r_shader);
                r_material.hideFlags = HideFlags.HideAndDontSave;
            }
            return r_material;
        }
    }
    private void Update()
    {

        raymarchingMaterial.SetFloat("radius1", _mvtCtrlNetwork.leftTilt);
        raymarchingMaterial.SetFloat("cubeSide", _mvtCtrlNetwork.rightTilt);
        raymarchingMaterial.SetVector("_mandleBrot1", _mandleBrot1);
        raymarchingMaterial.SetVector("_mandleBrotColor1", _mandleBrotColor1);
        raymarchingMaterial.SetFloat("_power", _power);

        raymarchingMaterial.SetInt("r_maxIterations", r_maxIterations);
        raymarchingMaterial.SetFloat("r_accuracy", r_accuracy);
        raymarchingMaterial.SetColor("r_mainColor", r_color);
        Vector3 UIpos = UI.transform.position;
        Vector3 right = _mvtCtrlNetwork.gameObject.transform.right;
        raymarchingMaterial.SetVector("r_sphere", r_sphere + new Vector4(UIpos.x, UIpos.y, UIpos.z) + _mvtCtrlNetwork.lerpDt * new Vector4(right.x, right.y, right.z) / 2);
        raymarchingMaterial.SetVector("r_box", r_box + new Vector4(UIpos.x - _mvtCtrlNetwork.lerpDt / 2, UIpos.y, UIpos.z) - _mvtCtrlNetwork.lerpDt * new Vector4(right.x, right.y, right.z) / 2);


        raymarchingMaterial.SetVector("r_light", r_light ? r_light.forward : Vector3.down);

        raymarchingMaterial.SetColor("r_lightColor", r_lightColor);
        raymarchingMaterial.SetFloat("r_lightIntensity", r_lightIntensity);
        raymarchingMaterial.SetFloat("r_shadowIntensity", r_shadowIntensity);
        raymarchingMaterial.SetFloat("r_shadowPenumbra", r_shadowPenumbra);
        raymarchingMaterial.SetVector("r_shadowDistance", r_shadowDistance);
        raymarchingMaterial.SetInt("r_ambientIterations", r_ambientIterations);
        raymarchingMaterial.SetFloat("r_ambientSteps", r_ambientSteps);
        raymarchingMaterial.SetFloat("r_ambientIntesity", r_ambientIntesity);
        raymarchingMaterial.SetVector("r_sphere4", r_sphere4);
        raymarchingMaterial.SetFloat("r_sphereSmooth", r_sphereSmooth);
        raymarchingMaterial.SetFloat("r_degreeRotate", r_degreeRotate);


        raymarchingMaterial.SetFloat("r_maxdistance", r_maxDistance);
        raymarchingMaterial.SetVector("r_modInterval", r_modInterval);
        raymarchingMaterial.SetVector("r_sphere2", r_sphere2);
        raymarchingMaterial.SetFloat("r_boxRound", r_boxRound);
        raymarchingMaterial.SetFloat("r_boxSphereSmooth", r_boxSphereSmooth);
        raymarchingMaterial.SetFloat("r_sphereIntersectSmooth", r_sphereIntersectSmooth);

        raymarchingMaterial.SetInt("r_reflectionCount", r_reflectionCount);
        raymarchingMaterial.SetFloat("r_reflectionIntensity", r_reflectionIntensity);
        raymarchingMaterial.SetFloat("r_environmentIntensity", r_environmentIntensity);
        raymarchingMaterial.SetTexture("r_reflectionCube", r_reflectionCube);

    }
}
