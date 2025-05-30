using BotSharp.Abstraction.Hooks;
using BotSharp.Abstraction.MLTasks;

namespace BotSharp.Abstraction.Realtime;

public interface IRealtimeHook : IHookBase
{
    Task OnModelReady(Agent agent, IRealTimeCompletion completer);
    string[] OnModelTranscriptPrompt(Agent agent);
    Task OnTranscribeCompleted(RoleDialogModel message, TranscriptionData data);
}
