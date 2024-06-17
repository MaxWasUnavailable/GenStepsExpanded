using System.Collections.Generic;
using PhantomBrigade.Data;
using PhantomBrigade.Functions.Equipment;

namespace GenStepsExpanded.GenSteps;

#nullable disable
public class AddTagToPart : PartGenStepTargeted, IPartGenStep
{
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once UnassignedField.Global
    public string tag;

    public void Run(DataContainerPartPreset preset, Dictionary<string, GeneratedHardpoint> layout, int rating, bool log)
    {
        preset.tags.Add(tag);
    }
}