using System.Collections.Generic;
using RiveRuntime.Maui.Enums;

namespace RiveRuntime.Maui;

public record StateMachineEventReceivedArgs(string Name, RiveSpriteViewEvent Type, Dictionary<string, object>? Properties);