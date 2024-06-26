﻿using System;
using HarmonyLib;
using PhantomBrigade.Mods;
using UnityEngine;

namespace GenStepsExpanded;

/// <summary>
///     Main mod class for GenStepsExpanded
/// </summary>
public class GenStepsExpanded : ModLink
{
    private bool _isPatched;
    public static string Guid { get; } = "MaxWasUnavailable.GenStepsExpanded";
    public static string Name { get; } = "GenStepsExpanded";
    public static Version Version { get; } = new(0, 0, 1);

    /// <summary>
    ///     Singleton instance of the plugin.
    /// </summary>
    public static GenStepsExpanded? Instance { get; private set; }

    public override void OnLoad(Harmony harmonyInstance)
    {
        // Set instance
        Instance = this;

        // Patch using Harmony
        PatchAll(harmonyInstance);

        // Report plugin loaded
        Debug.Log($"Loaded {Name} v{Version}");
    }

    private void PatchAll(Harmony harmonyInstance)
    {
        if (_isPatched)
        {
            Debug.LogWarning("Already patched!");
            return;
        }

        Debug.Log("Patching...");

        harmonyInstance.PatchAll();

        _isPatched = true;

        Debug.Log("Patched!");
    }
}