using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CRTPostProcessing : MonoBehaviour
{
    [SerializeField]
    private Camera _main;
    [SerializeField]
    private Shader _crtShader;
    private Material _crtMaterial;
    private bool _isEnable = false;

    [SerializeField]
    [Range(0, 1)]
    private float _vertsForce = 0.0f;
    [SerializeField]
    [Range(0, 1)]
    private float _vertsForce2 = 0.0f;

    [SerializeField]
    [Range(-3, 20)]
    private float _contrast = 0.0f;
    [SerializeField]
    [Range(-200, 200)]
    private float _brightness = 0.0f;
    [SerializeField]
    [Range(0, 1)]
    private float _scansColor = 0;

    void Awake()
    {
        if(_main == null)
        {
            _main = Camera.main;
        }
        if (_main != null && _crtShader != null)
        {
            _isEnable = true;
            _crtMaterial = new Material(_crtShader);
            _crtMaterial.SetFloat("_vertsColor", 1 - _vertsForce);
            _crtMaterial.SetFloat("_vertsColor2", 1 - _vertsForce2);
            _crtMaterial.SetFloat("_contrast", _contrast);
            _crtMaterial.SetFloat("_br", _brightness);
            _crtMaterial.SetFloat("_scansColor", _scansColor);
        }
        else
        {
            _isEnable = false;
        }
    }

    private void OnValidate()
    {
        if (_main == null)
        {
            _main = Camera.main;
        }
        if (_main != null && _crtShader != null)
        {
            _isEnable = true;
            _crtMaterial = new Material(_crtShader);
            _crtMaterial.SetFloat("_vertsColor", 1 - _vertsForce);
            _crtMaterial.SetFloat("_vertsColor2", 1 - _vertsForce2);
            _crtMaterial.SetFloat("_contrast", _contrast);
            _crtMaterial.SetFloat("_br", _brightness);
            _crtMaterial.SetFloat("_scansColor", _scansColor);
        }
        else
        {
            _isEnable = false;
        }
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (_isEnable)
        {
            Graphics.Blit(source, destination, _crtMaterial);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}
