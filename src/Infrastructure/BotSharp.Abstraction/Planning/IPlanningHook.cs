using BotSharp.Abstraction.Hooks;

namespace BotSharp.Abstraction.Planning;

public interface IPlanningHook : IHookBase
{
    Task<string> GetSummaryAdditionalRequirements(string planner, RoleDialogModel message)
        => Task.FromResult(string.Empty);

    Task OnSourceCodeGenerated(string planner, RoleDialogModel msg, string language)
        => Task.CompletedTask;

    Task OnPlanningCompleted(string planner, RoleDialogModel msg)
        => Task.CompletedTask;
}
