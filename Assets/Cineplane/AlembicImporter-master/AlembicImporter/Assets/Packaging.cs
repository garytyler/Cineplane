﻿#if UNITY_EDITOR
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;


public class AlembicImporterPackaging
{
    [MenuItem("Assets/Make Packages")]
    public static void MakePackage_Alembic()
    {
        MakePackage_AlembicImporter();
        MakePackage_AlembicExporter();
    }

    public static void MakePackage_AlembicImporter()
    {
        string[] files = new string[]
        {
"Assets/UTJ/AlembicImporter",
"Assets/UTJ/Plugins/x86/AlembicImporter.dll",
"Assets/UTJ/Plugins/x86_64/AlembicImporter.dll",
        };
        AssetDatabase.ExportPackage(files, "AlembicImporter.unitypackage", ExportPackageOptions.Recurse);
    }

    public static void MakePackage_AlembicExporter()
    {
        string[] files = new string[]
        {
"Assets/UTJ/AlembicExporter",
"Assets/UTJ/Plugins/x86/AlembicExporter.dll",
"Assets/UTJ/Plugins/x86_64/AlembicExporter.dll",
"Assets/UTJ/AlembicExporterExample",
        };
        AssetDatabase.ExportPackage(files, "AlembicExporter.unitypackage", ExportPackageOptions.Recurse);
    }

}
#endif // UNITY_EDITOR
