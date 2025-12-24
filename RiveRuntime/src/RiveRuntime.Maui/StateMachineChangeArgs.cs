using System.Collections.Generic;

namespace RiveRuntime.Maui;

public record StateMachineChangeArgs(string StateMachine, string StateName, Dictionary<string, object> Inputs);