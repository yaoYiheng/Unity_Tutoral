using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Projectile))]
public class ProjectileEditor : Editor 
{
    [DrawGizmo(GizmoType.Selected | GizmoType.NonSelected)]
    static void DrawGizmosSelected(Projectile projectile, GizmoType gizmoType)
    {
        Gizmos.DrawWireSphere(projectile.transform.position, 0.125f);
    }

    private void OnSceneGUI()
    {
        var projectile = target as Projectile;
        var transform = projectile.transform;

        projectile.damageRadius = Handles.RadiusHandle(transform.rotation,
                                                       transform.position,
                                                       projectile.damageRadius);
    }

}
