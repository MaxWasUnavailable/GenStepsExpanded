using System.Collections.Generic;
using PhantomBrigade.Data;
using PhantomBrigade.Functions.Equipment;
using UnityEngine;

namespace GenStepsExpanded.Checks;

public class CheckChance : IPartGenCheck
{
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once UnassignedField.Global
    public float chance;

    public bool IsPassed(DataContainerPartPreset preset, Dictionary<string, GeneratedHardpoint> layout, int rating)
    {
        return Random.Range(0.0f, 1f) <= chance;
    }
}