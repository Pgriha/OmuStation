using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._RMC14.CCVar;

[CVarDefs]
public sealed partial class RMCCVars : CVars
{
    public static readonly CVarDef<bool> RMCDeadChatEnabled =
        CVarDef.Create("rmc.dead_chat_enabled", true, CVar.SERVER | CVar.NOTIFY | CVar.REPLICATED);

    public static readonly CVarDef<bool> RMCAutoPunctuate =
        CVarDef.Create("rmc.auto_punctuate", false, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE); // Cheeburbr. Портована нами авто пунктуація у клієнта
}
