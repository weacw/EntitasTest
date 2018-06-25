using UnityEngine;
using System.Collections.Generic;

public class TransparentService : IPhysicsRaycast
{
    public class TransparentParam
    {
        public Material[] materials;
        public Material[] sharedMats;
        public float currentFadeTime;
        public bool isTransparent;
    }

    private Transform cameraTransform = null;
    private Transform targetObject = null;
    private float destTransparent = 0.2f;
    private float fadeInTime = 1.0f;
    private LayerMask transparentLayer;
    private Dictionary<Renderer, TransparentParam> transparentDic = new Dictionary<Renderer, TransparentParam>();
    private List<Renderer> clearList = new List<Renderer>();

    public TransparentService(Transform _targetObject, Transform _camerTrans, float _destTransparent = .2f, float _fadeInTime = .5f, int _transparentLayer = ~(1 << 10))
    {
        targetObject = _targetObject;
        cameraTransform = _camerTrans;
        destTransparent = _destTransparent;
        fadeInTime = _fadeInTime;
        transparentLayer = _transparentLayer;
    }

    public bool PhysicsRaycast()
    {
        UpdateTransparentObject();
        RaycastHit[] rayHits = null;
        Vector3 targetPos = targetObject.position + Vector3.up *1.5f;
        Vector3 viewDir = (targetPos - cameraTransform.position).normalized;
        Vector3 oriPos = cameraTransform.position;
        float distance = Vector3.Distance(oriPos, targetPos);
        Ray ray = new Ray(oriPos, viewDir);
        rayHits = Physics.RaycastAll(ray, distance, transparentLayer);
        Debug.DrawLine(oriPos, targetPos, Color.red);
        foreach (var hit in rayHits)
        {
            Renderer[] renderers = hit.collider.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in renderers)
            {
                AddTransparent(r);
            }
        }
        RemoveUnuseTransparent();
        return true;
    }


    private void UpdateTransparentObject()
    {
        var var = transparentDic.GetEnumerator();
        while (var.MoveNext())
        {
            TransparentParam param = var.Current.Value;
            param.isTransparent = false;
            foreach (var mat in param.materials)
            {
                Color col = mat.GetColor("_Color");
                param.currentFadeTime += Time.deltaTime;
                float t = param.currentFadeTime / fadeInTime;
                col.a = Mathf.Lerp(1, destTransparent, t);
                mat.SetColor("_Color", col);
            }
        }
    }

    private void RemoveUnuseTransparent()
    {
        clearList.Clear();
        var var = transparentDic.GetEnumerator();
        while (var.MoveNext())
        {
            if (var.Current.Value.isTransparent == false)
            {
                var.Current.Key.materials = var.Current.Value.sharedMats;
                clearList.Add(var.Current.Key);
            }
        }
        foreach (var v in clearList)
            transparentDic.Remove(v);
    }

    private void AddTransparent(Renderer renderer)
    {
        TransparentParam param;
        transparentDic.TryGetValue(renderer, out param);
        if (param == null)
        {
            param = new TransparentParam();
            transparentDic.Add(renderer, param);
            param.sharedMats = renderer.sharedMaterials;
            param.materials = renderer.materials;
            foreach (var v in param.materials)
            {
                v.shader = Shader.Find("Custom/OcclusionTransparent");
            }
        }
        param.isTransparent = true;
    }
}
