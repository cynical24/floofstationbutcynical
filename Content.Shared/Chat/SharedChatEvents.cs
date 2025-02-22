﻿using Content.Shared.Speech;
using Robust.Shared.Prototypes;
using Content.Shared.Inventory;

namespace Content.Shared.Chat;

/// <summary>
///     This event should be sent everytime an entity talks (Radio, local chat, etc...).
///     The event is sent to both the entity itself, and all clothing (For stuff like voice masks).
/// </summary>
public sealed class TransformSpeakerSpeechEvent : EntityEventArgs, IInventoryRelayEvent
{
    public SlotFlags TargetSlots { get; } = SlotFlags.WITHOUT_POCKET;
    public EntityUid Sender;
    public string? VoiceName;
    public ProtoId<SpeechVerbPrototype>? SpeechVerb;

    public TransformSpeakerSpeechEvent(EntityUid sender, string? name = null)
    {
        Sender = sender;
        VoiceName = name;
        SpeechVerb = null;
    }
}
