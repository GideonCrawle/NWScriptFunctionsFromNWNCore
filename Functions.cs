using NWN.Core;
using StackExchange.Redis;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace NWN {
    public static partial class NWScript {
        //     Maths operation: integer absolute value of nValue * Return value on error: 0
        public static int abs(int value) => Core.NWScript.abs(value);

        public static float acos(float value) => Core.NWScript.acos(value);

        //     Attack oAttackee. - bPassive: If this is TRUE, attack is in passive mode.
        public static void ActionAttack(NWObject target, bool passive = false)
            => Core.NWScript.ActionAttack(target, passive ? 1 : 0);

        //     The action subject will fake casting a spell at lLocation; the conjure and cast
        //     animations and visuals will occur, nothing else.
        public static void ActionCastFakeSpellAtLocation(Spell spell, Location target, ProjectilePathType projectilePathType = ProjectilePathType.Default)
            => Core.NWScript.ActionCastFakeSpellAtLocation((int)spell, target, (int)projectilePathType);

        //     The action subject will fake casting a spell at oTarget; the conjure and cast
        //     animations and visuals will occur, nothing else.
        public static void ActionCastFakeSpellAtObject(Spell spell, NWObject target, ProjectilePathType projectilePathType = ProjectilePathType.Default)
            => Core.NWScript.ActionCastFakeSpellAtObject((int)spell, target, (int)projectilePathType);

        //     Cast spell nSpell at lTargetLocation. - nSpell: SPELL_* - lTargetLocation - nMetaMagic:
        //     METAMAGIC_* - bCheat: If this is TRUE, then the executor of the action doesn't
        //     have to be able to cast the spell. - nProjectilePathType: PROJECTILE_PATH_TYPE_*
        //     - bInstantSpell: If this is TRUE, the spell is cast immediately; this allows
        //     the end-user to simulate a high-level magic user having lots of advance warning
        //     of impending trouble.
        public static void ActionCastSpellAtLocation(Spell spell, Location target, Metamagic metamagic = Metamagic.Any, bool cheat = false, ProjectilePathType projectilePathType = ProjectilePathType.Default, bool instant = false)
            => Core.NWScript.ActionCastSpellAtLocation((int)spell, target, (int)metamagic, cheat ? 1 : 0, (int)projectilePathType, instant ? 1 : 0);

        //     This action casts a spell at target. 
        public static void ActionCastSpellAtObject(Spell spell, NWObject target, Metamagic metamagic = Metamagic.Any, bool cheat = false, int domainLevel = 0, ProjectilePathType projectilePathType = ProjectilePathType.Default, bool instant = false)
            => Core.NWScript.ActionCastSpellAtObject((int)spell, target, (int)metamagic, cheat ? 1 : 0, domainLevel, (int)projectilePathType, instant ? 1 : 0);

        //     Cause the action subject to close oDoor
        public static void ActionCloseDoor(NWObject door)
            => Core.NWScript.ActionCloseDoor(door);

        //     Counterspell oCounterSpellTarget.
        public static void ActionCounterSpell(NWObject counterSpellTarget)
            => Core.NWScript.ActionCounterSpell(counterSpellTarget);

        //     Do aActionToDo.
        public static void ActionDoCommand(ActionDelegate actionToDo)
            => Core.NWScript.ActionDoCommand(actionToDo);

        //     Equip oItem into nInventorySlot.No return
        //     value, but if an error occurs the log file will contain "ActionEquipItem failed."
        //     Note: If the creature already has an item equipped in the slot specified, it
        //     will be unequipped automatically by the call to ActionEquipItem. In order for
        //     ActionEquipItem to succeed the creature must be able to equip the item oItem
        //     normally. This means that: 1) The item is in the creature's inventory. 2) The
        //     item must already be identified (if magical). 3) The creature has the level required
        //     to equip the item (if magical and ILR is on). 4) The creature possesses the required
        //     feats to equip the item (such as weapon proficiencies).
        public static void ActionEquipItem(NWItem oItem, InventorySlot inventorySlot)
            => Core.NWScript.ActionEquipItem(oItem, (int)inventorySlot);

        //     The creature will equip the melee weapon in its possession that can do the most
        //     damage. If no valid melee weapon is found, it will equip the most damaging range
        //     weapon. This function should only ever be called in the EndOfCombatRound scripts,
        //     because otherwise it would have to stop the combat round to run simulation. -
        //     versus: You can try to get the most damaging weapon against versus
        public static void ActionEquipMostDamagingMelee(NWObject? versus = null, bool offHand = false)
            => Core.NWScript.ActionEquipMostDamagingMelee(versus ?? NWObject.OBJECT_INVALID, offHand ? 1 : 0);

        //     The creature will equip the range weapon in its possession that can do the most
        //     damage. If no valid range weapon can be found, it will equip the most damaging
        //     melee weapon. - oVersus: You can try to get the most damaging weapon against
        //     oVersus
        public static void ActionEquipMostDamagingRanged(NWObject? versus = null)
            => Core.NWScript.ActionEquipMostDamagingRanged(versus ?? NWObject.OBJECT_INVALID);

        //     The creature will equip the armour in its possession that has the highest armour
        //     class.
        public static void ActionEquipMostEffectiveArmor()
            => Core.NWScript.ActionEquipMostEffectiveArmor();

        //     Makes a player examine the object oExamine. This causes the examination pop-up
        //     box to appear for the object specified.
        public static void ActionExamine(NWObject target)
            => Core.NWScript.ActionExamine(target);

        //     The action subject will follow oFollow until a ClearAllActions() is called. -
        //     oFollow: this is the object to be followed - fFollowDistance: follow distance
        //     in metres * No return value
        public static void ActionForceFollowObject(NWObject target, float followDistance = 0)
            => Core.NWScript.ActionForceFollowObject(target, followDistance);

        //     Force the action subject to move to lDestination.
        public static void ActionForceMoveToLocation(Location destination, bool run = false, float timeout = 30.0f)
            => Core.NWScript.ActionForceMoveToLocation(destination, run ? 1 : 0, timeout);

        //     Force the action subject to move to oMoveTo.
        public static void ActionForceMoveToObject(NWObject moveTo, bool run = false, float range = 1.0f, float timeout = 30.0f)
            => Core.NWScript.ActionForceMoveToObject(moveTo, run ? 1 : 0, range, timeout);

        //     Give oItem to oGiveTo If oItem is not a valid item, or oGiveTo is not a valid
        //     object, nothing will happen.
        public static void ActionGiveItem(NWItem item, NWObject recipient)
            => Core.NWScript.ActionGiveItem(item, recipient);

        //     Use placeable.
        public static void ActionInteractObject(NWPlaceable placeable)
            => Core.NWScript.ActionInteractObject(placeable);

        //     The subject will jump to lLocation instantly (even between areas). If lLocation
        //     is invalid, nothing will happen.
        public static void ActionJumpToLocation(Location loc)
            => Core.NWScript.ActionJumpToLocation(loc);

        //     Jump to an object ID, or as near to it as possible.
        public static void ActionJumpToObject(NWObject target, bool straightLine)
            => Core.NWScript.ActionJumpToObject(target, straightLine ? 1 : 0);

        //     The action subject will lock oTarget, which can be a door or a placeable object.
        public static void ActionLockObject(NWObject target)
            => Core.NWScript.ActionLockObject(target);

        //     Causes the action subject to move away from lMoveAwayFrom.
        public static void ActionMoveAwayFromLocation(Location moveAwayFrom, bool run = false, float moveAwayRange = 40.0f)
            => Core.NWScript.ActionMoveAwayFromLocation(moveAwayFrom, run ? 1 : 0, moveAwayRange);

        //     Cause the action subject to move to a certain distance away from oFleeFrom. -
        //     oFleeFrom: This is the object we wish the action subject to move away from. If
        //     oFleeFrom is not in the same area as the action subject, nothing will happen.
        //     - bRun: If this is TRUE, the action subject will run rather than walk - fMoveAwayRange:
        //     This is the distance we wish the action subject to put between themselves and
        //     oFleeFrom * No return value, but if an error occurs the log file will contain
        //     "ActionMoveAwayFromObject failed."
        public static void ActionMoveAwayFromObject(NWObject fleeFrom, bool run = false, float moveAwayRange = 40.0f)
            => Core.NWScript.ActionMoveAwayFromObject(fleeFrom, run ? 1 : 0, moveAwayRange);

        //     The action subject will move to lDestination. - lDestination: The object will
        //     move to this location. If the location is invalid or a path cannot be found to
        //     it, the command does nothing. - bRun: If this is TRUE, the action subject will
        //     run rather than walk * No return value, but if an error occurs the log file will
        //     contain "MoveToPoint failed."
        public static void ActionMoveToLocation(Location destination, bool run = false)
            => Core.NWScript.ActionMoveToLocation(destination, run ? 1 : 0);

        //     Cause the action subject to move to a certain distance from oMoveTo. If there
        //     is no path to oMoveTo, this command will do nothing. - oMoveTo: This is the object
        //     we wish the action subject to move to - bRun: If this is TRUE, the action subject
        //     will run rather than walk - fRange: This is the desired distance between the
        //     action subject and oMoveTo * No return value, but if an error occurs the log
        //     file will contain "ActionMoveToObject failed."
        public static void ActionMoveToObject(NWObject moveTo, bool run = false, float range = 1.0f)
            => Core.NWScript.ActionMoveToObject(moveTo, run ? 1 : 0, range);

        //     Cause the action subject to open oDoor
        public static void ActionOpenDoor(NWObject door)
            => Core.NWScript.ActionOpenDoor(door);

        //     Pause the current conversation.
        public static void ActionPauseConversation()
            => Core.NWScript.ActionPauseConversation();

        //     Pick up oItem from the ground. * No return value, but if an error occurs the
        //     log file will contain "ActionPickUpItem failed."
        public static void ActionPickUpItem(NWItem item)
            => Core.NWScript.ActionPickUpItem(item);

        //     Cause the action subject to play an animation - nAnimation: ANIMATION_* - fSpeed:
        //     Speed of the animation - fDurationSeconds: Duration of the animation (this is
        //     not used for Fire and Forget animations)
        public static void ActionPlayAnimation(Animation animation, float speed = 1.0f, float durationSeconds = 0.0f)
            => Core.NWScript.ActionPlayAnimation((int)animation, speed, durationSeconds);

        //     Put down oItem on the ground. * No return value, but if an error occurs the log
        //     file will contain "ActionPutDownItem failed."
        public static void ActionPutDownItem(NWItem item)
            => Core.NWScript.ActionPutDownItem(item);

        //     The action subject will generate a random location near its current location
        //     and pathfind to it. ActionRandomwalk never ends, which means it is neccessary
        //     to call ClearAllActions in order to allow a creature to perform any other action
        //     once ActionRandomWalk has been called. * No return value, but if an error occurs
        //     the log file will contain "ActionRandomWalk failed."
        public static void ActionRandomWalk() => Core.NWScript.ActionRandomWalk();

        //     The creature will rest if not in combat and no enemies are nearby. - bCreatureToEnemyLineOfSightCheck:
        //     TRUE to allow the creature to rest if enemies are nearby, but the creature can't
        //     see the enemy. FALSE the creature will not rest if enemies are nearby regardless
        //     of whether or not the creature can see them, such as if an enemy is close by,
        //     but is in a different room behind a closed door.
        public static void ActionRest(bool creatureToEnemyLineOfSightCheck = false)
            => Core.NWScript.ActionRest(creatureToEnemyLineOfSightCheck ? 1 : 0);

        //     Resume a conversation after it has been paused.
        public static void ActionResumeConversation()
            => Core.NWScript.ActionResumeConversation();

        //     Sit in oChair. Note: Not all creatures will be able to sit and not all objects
        //     can be sat on. The object oChair must also be marked as usable in the toolset.
        //     For Example: To get a player to sit in oChair when they click on it, place the
        //     following script in the OnUsed event for the object oChair. void main() { object
        //     oChair = OBJECT_SELF; AssignCommand(GetLastUsedBy(),ActionSit(oChair)); }
        public static void ActionSit(NWPlaceable chair)
            => Core.NWScript.ActionSit(chair);

        //     Add a speak action to the action subject. - sStringToSpeak: String to be spoken
        //     - nTalkVolume: TALKVOLUME_*
        public static void ActionSpeakString(string stringToSpeak, TalkVolume talkVolume = TalkVolume.Talk)
            => Core.NWScript.ActionSpeakString(stringToSpeak, (int)talkVolume);

        //     Causes the creature to speak a translated string. - nStrRef: Reference of the
        //     string in the talk table - nTalkVolume: TALKVOLUME_*
        public static void ActionSpeakStringByStrRef(int strRef, TalkVolume talkVolume = TalkVolume.Talk)
            => Core.NWScript.ActionSpeakStringByStrRef(strRef, (int)talkVolume);

        //     Starts a conversation with oObjectToConverseWith - this will cause their OnDialog
        //     event to fire. - oObjectToConverseWith - sDialogResRef: If this is blank, the
        //     creature's own dialogue file will be used - bPrivateConversation Turn off bPlayHello
        //     if you don't want the initial greeting to play
        public static void ActionStartConversation(NWObject objectToConverseWith, string dialogResRef = "", bool privateConversation = false, bool playHello = true)
            => Core.NWScript.ActionStartConversation(objectToConverseWith, dialogResRef, privateConversation ? 1 : 0, playHello ? 1 : 0);

        //     Take oItem from oTakeFrom If oItem is not a valid item, or oTakeFrom is not a
        //     valid object, nothing will happen.
        public static void ActionTakeItem(NWItem item, NWObject takeFrom)
            => Core.NWScript.ActionTakeItem(item, takeFrom);

        //     Unequip oItem from whatever slot it is currently in.
        public static void ActionUnequipItem(NWItem item)
            => Core.NWScript.ActionUnequipItem(item);

        //     The action subject will unlock oTarget, which can be a door or a placeable object.
        public static void ActionUnlockObject(NWObject target)
            => Core.NWScript.ActionUnlockObject(target);

        //     Use nFeat on oTarget. - nFeat: FEAT_* - oTarget
        public static void ActionUseFeat(Feat feat, NWObject target)
            => Core.NWScript.ActionUseFeat((int)feat, target);

        //     Runs the action "UseSkill" on the current creature Use nSkill on oTarget. - nSkill:
        //     SKILL_* - oTarget - nSubSkill: SUBSKILL_* - oItemUsed: Item to use in conjunction
        //     with the skill
        public static void ActionUseSkill(Skill skill, NWObject target, SubSkill subSkill = SubSkill.None, NWItem? itemUsed = null)
            => Core.NWScript.ActionUseSkill((int)skill, target, (int)subSkill, itemUsed ?? NWObject.OBJECT_SELF);

        //     Use tChosenTalent at lTargetLocation.
        public static void ActionUseTalentAtLocation(IntPtr chosenTalent, Location targetLocation)
            => Core.NWScript.ActionUseTalentAtLocation(chosenTalent, targetLocation);

        //     Use tChosenTalent on oTarget.
        public static void ActionUseTalentOnObject(IntPtr chosenTalent, NWObject target)
            => Core.NWScript.ActionUseTalentOnObject(chosenTalent, target);

        //     Do nothing for fSeconds seconds.
        public static void ActionWait(float seconds)
            => Core.NWScript.ActionWait(seconds);

        //     Try to send oTarget to a new server defined by sIPaddress. - oTarget - sIPaddress:
        //     this can be numerical "192.168.0.84" or alphanumeric "www.bioware.com". It can
        //     also contain a port "192.168.0.84:5121" or "www.bioware.com:5121"; if the port
        //     is not specified, it will default to 5121. - sPassword: login password for the
        //     destination server - sWaypointTag: if this is set, after portalling the character
        //     will be moved to this waypoint if it exists - bSeamless: if this is set, the
        //     client wil not be prompted with the information window telling them about the
        //     server, and they will not be allowed to save a copy of their character if they
        //     are using a local vault character.
        public static void ActivatePortal(NWPlayer target, string ipAddress = "", string password = "", string waypointTag = "", bool seamless = false)
            => Core.NWScript.ActivatePortal(target, ipAddress, password, waypointTag, seamless ? 1 : 0);

        //     Add oHenchman as a henchman to oMaster If oHenchman is either a DM or a player
        //     character, this will have no effect.
        public static void AddHenchman(NWCreature master, NWCreature? henchman = null)
            => Core.NWScript.AddHenchman(master, henchman ?? NWObject.OBJECT_SELF);

        //     *********************** START OF ITEM PROPERTY FUNCTIONS **********************
        //     adds an item property to the specified item Only temporary and permanent duration
        //     types are allowed.
        public static void AddItemProperty(DurationType durationType, ItemProperty itemProperty, NWObject item, float duration = 0.0f)
            => Core.NWScript.AddItemProperty((int)durationType, itemProperty, item, duration);

        //     Add a journal quest entry to oCreature. - szPlotID: the plot identifier used
        //     in the toolset's Journal Editor - nState: the state of the plot as seen in the
        //     toolset's Journal Editor - oCreature - bAllPartyMembers: If this is TRUE, the
        //     entry will show up in the journal of everyone in the party - bAllPlayers: If
        //     this is TRUE, the entry will show up in the journal of everyone in the world
        //     - bAllowOverrideHigher: If this is TRUE, you can set the state to a lower number
        //     than the one it is currently on
        public static void AddJournalQuestEntry(string plotID, int state, NWPlayer target, bool allPartyMembers = true, bool allPlayers = false, bool allowOverrideHigher = false)
            => Core.NWScript.AddJournalQuestEntry(plotID, state, target, allPartyMembers ? 1 : 0, allPlayers ? 1 : 0, allowOverrideHigher ? 1 : 0);

        //     Add oPC to oPartyLeader's party. This will only work on two PCs. - oPC: player
        //     to add to a party - oPartyLeader: player already in the party
        public static void AddToParty(NWPlayer player, NWPlayer partyLeader)
            => Core.NWScript.AddToParty(player, partyLeader);

        //     Adjust the alignment of oSubject. - oSubject - nAlignment: -> ALIGNMENT_LAWFUL/ALIGNMENT_CHAOTIC/ALIGNMENT_GOOD/ALIGNMENT_EVIL:
        //     oSubject's alignment will be shifted in the direction specified -> ALIGNMENT_ALL:
        //     nShift will be added to oSubject's law/chaos and good/evil alignment values ->
        //     ALIGNMENT_NEUTRAL: nShift is applied to oSubject's law/chaos and good/evil alignment
        //     values in the direction which is towards neutrality. e.g. If oSubject has a law/chaos
        //     value of 10 (i.e. chaotic) and a good/evil value of 80 (i.e. good) then if nShift
        //     is 15, the law/chaos value will become (10+15)=25 and the good/evil value will
        //     become (80-25)=55 Furthermore, the shift will at most take the alignment value
        //     to 50 and not beyond. e.g. If oSubject has a law/chaos value of 40 and a good/evil
        //     value of 70, then if nShift is 15, the law/chaos value will become 50 and the
        //     good/evil value will become 55 - nShift: this is the desired shift in alignment
        //     - bAllPartyMembers: when TRUE the alignment shift of oSubject also has a diminished
        //     affect all members of oSubject's party (if oSubject is a Player). When FALSE
        //     the shift only affects oSubject. * No return value
        public static void AdjustAlignment(NWCreature subject, Alignment alignment, int shift, bool allPartyMembers = true)
            => Core.NWScript.AdjustAlignment(subject, (int)alignment, shift, allPartyMembers ? 1 : 0);

        //     Adjust how oSourceFactionMember's faction feels about oTarget by the specified
        //     amount. Note: This adjusts Faction Reputation, how the entire faction that oSourceFactionMember
        //     is in, feels about oTarget. * No return value Note: You can't adjust a player
        //     character's (PC) faction towards NPCs, so attempting to make an NPC hostile by
        //     passing in a PC object as oSourceFactionMember in the following call will fail:
        //     AdjustReputation(oNPC,oPC,-100); Instead you should pass in the PC object as
        //     the first parameter as in the following call which should succeed: AdjustReputation(oPC,oNPC,-100);
        //     Note: Will fail if oSourceFactionMember is a plot object.
        public static void AdjustReputation(NWCreature target, NWCreature sourceFactionMember, int adjustment)
            => Core.NWScript.AdjustReputation(target, sourceFactionMember, adjustment);

        //     Change the ambient day track for oArea to nTrack. - oArea - nTrack
        public static void AmbientSoundChangeDay(NWArea area, Track track)
            => Core.NWScript.AmbientSoundChangeDay(area, (int)track);

        //     Change the ambient night track for oArea to nTrack. - oArea - nTrack
        public static void AmbientSoundChangeNight(NWArea area, Track track)
            => Core.NWScript.AmbientSoundChangeNight(area, (int)track);

        //     Play the ambient sound for oArea.
        public static void AmbientSoundPlay(NWArea area)
            => Core.NWScript.AmbientSoundPlay(area);

        //     Set the ambient day volume for oArea to nVolume. - oArea - nVolume: 0 - 100
        public static void AmbientSoundSetDayVolume(NWArea area, int volume)
            => Core.NWScript.AmbientSoundSetDayVolume(area, volume);

        //     Set the ambient night volume for oArea to nVolume. - oArea - nVolume: 0 - 100
        public static void AmbientSoundSetNightVolume(NWArea area, int volume)
            => Core.NWScript.AmbientSoundSetNightVolume(area, volume);

        //     Stop the ambient sound for oArea.
        public static void AmbientSoundStop(NWArea area)
            => Core.NWScript.AmbientSoundStop(area);

        //     Convert fAngle to a vector
        public static Vector3 AngleToVector(float angle)
            => Core.NWScript.AngleToVector(angle);

        //     Apply eEffect at lLocation.
        public static void ApplyEffectAtLocation(DurationType durationType, Effect effect, Location location, float duration = 0.0f)
            => Core.NWScript.ApplyEffectAtLocation((int)durationType, effect, location, duration);

        //     Apply eEffect to oTarget.
        public static void ApplyEffectToObject(DurationType durationType, Effect effect, NWObject target, float duration = 0.0f)
            => Core.NWScript.ApplyEffectToObject((int)durationType, effect, target, duration);

        public static float asin(float value)
            => Core.NWScript.asin(value);

        //     Assign aActionToAssign to oActionSubject. * No return value, but if an error
        //     occurs, the log file will contain "AssignCommand failed." (If the object doesn't
        //     exist, nothing happens.)
        public static void AssignCommand(NWObject actionSubject, ActionDelegate actionToAssign)
            => Core.NWScript.AssignCommand(actionSubject, actionToAssign);

        //     Maths operation: arctan of fValue
        public static float atan(float value)
            => Core.NWScript.atan(value);

        //     replace this function it does nothing.
        public static IntPtr BadBadReplaceMeThisDoesNothing()
            => Core.NWScript.BadBadReplaceMeThisDoesNothing();

        //     Use this in an OnDialog script to start up the dialog tree. - sResRef: if this
        //     is not specified, the default dialog file will be used - oObjectToDialog: if
        //     this is not specified the person that triggered the event will be used
        public static int BeginConversation(string resRef = "", NWObject? objectToDialog = null)
            => Core.NWScript.BeginConversation(resRef, objectToDialog ?? NWObject.OBJECT_INVALID);

        //     Sets the screen to black. Can be used in preparation for a fade-in (FadeFromBlack)
        //     Can be cleared by either doing a FadeFromBlack, or by calling StopFade. - oCreature:
        //     creature controlled by player that should see black screen
        public static void BlackScreen(NWCreature creature)
            => Core.NWScript.BlackScreen(creature);

        //     Remove oPlayer from the server. You can optionally specify a reason to override
        //     the text shown to the player.
        public static void BootPC(NWPlayer player, string reason = "")
            => Core.NWScript.BootPC(player, reason);

        //     Make oObjectToChangeFaction join the faction of oMemberOfFactionToJoin. NB. **
        //     This will only work for two NPCs **
        public static void ChangeFaction(NWCreature objectToChangeFaction, NWCreature memberOfFactionToJoin)
            => Core.NWScript.ChangeFaction(objectToChangeFaction, memberOfFactionToJoin);

        //     Make oCreatureToChange join one of the standard factions. ** This will only work
        //     on an NPC ** - nStandardFaction: STANDARD_FACTION_*
        public static void ChangeToStandardFaction(NWCreature creatureToChange, StandardFaction faction)
            => Core.NWScript.ChangeToStandardFaction(creatureToChange, (int)faction);

        //     Clear all the actions of the caller. * No return value, but if an error occurs,
        //     the log file will contain "ClearAllActions failed.". - nClearCombatState: if
        //     true, this will immediately clear the combat state on a creature, which will
        //     stop the combat music and allow them to rest, engage in dialog, or other actions
        //     that they would normally have to wait for.
        public static void ClearAllActions(bool clearCombatState = false)
            => Core.NWScript.ClearAllActions(clearCombatState ? 1 : 0);

        //     Clear all personal feelings that oSource has about oTarget.
        public static void ClearPersonalReputation(NWCreature target, NWCreature? source = null)
            => Core.NWScript.ClearPersonalReputation(target, source ?? NWObject.OBJECT_SELF);

        //     Creates a copy of a existing area, including everything inside of it (except
        //     players). Returns the new area, or OBJECT_INVALID on error. Note: You will have
        //     to manually adjust all transitions (doors, triggers) with the relevant script
        //     commands, or players might end up in the wrong area.
        public static uint CopyArea(NWArea area)
            => Core.NWScript.CopyArea(area);

        //     duplicates the item and returns a new object oItem - item to copy oTargetInventory
        //     - create item in this object's inventory. If this parameter is not valid, the
        //     item will be created in oItem's location bCopyVars - copy the local variables
        //     from the old item to the new one * returns the new item * returns OBJECT_INVALID
        //     for non-items. * can only copy empty item containers. will return OBJECT_INVALID
        //     if oItem contains other items. * if it is possible to merge this item with any
        //     others in the target location, then it will do so and return the merged object.
        public static NWItem CopyItem(NWItem item, NWObject? targetInventory = null, bool copyVars = false)
            => Core.NWScript.CopyItem(item, targetInventory ?? NWObject.OBJECT_INVALID, copyVars ? 1 : 0).AsItem();

        //     Creates a new copy of an item, while making a single change to the appearance
        //     of the item. Helmet models and simple items ignore iIndex. iType iIndex iNewValue
        //     ITEM_APPR_TYPE_SIMPLE_MODEL [Ignored] Model # ITEM_APPR_TYPE_WEAPON_COLOR ITEM_APPR_WEAPON_COLOR_*
        //     1-4 ITEM_APPR_TYPE_WEAPON_MODEL ITEM_APPR_WEAPON_MODEL_* Model # ITEM_APPR_TYPE_ARMOR_MODEL
        //     ITEM_APPR_ARMOR_MODEL_* Model # ITEM_APPR_TYPE_ARMOR_COLOR ITEM_APPR_ARMOR_COLOR_*
        //     [0] 0-175 [1] [0] Alternatively, where ITEM_APPR_TYPE_ARMOR_COLOR is specified,
        //     if per-part coloring is desired, the following equation can be used for nIndex
        //     to achieve that: ITEM_APPR_ARMOR_NUM_COLORS + (ITEM_APPR_ARMOR_MODEL_ * ITEM_APPR_ARMOR_NUM_COLORS)
        //     + ITEM_APPR_ARMOR_COLOR_ For example, to change the CLOTH1 channel of the torso,
        //     nIndex would be: 6 + (7 * 6) + 2 = 50 [1] When specifying per-part coloring,
        //     the value 255 is allowed and corresponds with the logical function 'clear colour
        //     override', which clears the per-part override for that part.
        public static NWItem CopyItemAndModify(NWItem item, ItemAppearanceType type, ItemAppearanceIndex index, int newValue, bool copyVars = false)
            => Core.NWScript.CopyItemAndModify(item, (int)type, (int)index, newValue, copyVars ? 1 : 0).AsItem();

        //     Duplicates the object specified by oSource. ONLY creatures and items can be specified.
        //     If an owner is specified and the object is an item, it will be put into their
        //     inventory If the object is a creature, they will be created at the location.
        //     If a new tag is specified, it will be assigned to the new object.
        public static uint CopyObject(NWObject source, Location location, NWObject? owner = null, string newTag = "")
            => Core.NWScript.CopyObject(source, location, owner ?? NWObject.OBJECT_INVALID, newTag);

        //     Maths operation: cosine of fValue
        public static float cos(float value)
            => Core.NWScript.cos(value);

        //     Instances a new area from the given resref, which needs to be a existing module
        //     area. Will optionally set a new area tag and displayed name. The new area is
        //     accessible immediately, but initialisation scripts for the area and all contained
        //     creatures will only run after the current script finishes (so you can clean up
        //     objects before returning). Returns the new area, or OBJECT_INVALID on failure.
        //     Note: When spawning a second instance of a existing area, you will have to manually
        //     adjust all transitions (doors, triggers) with the relevant script commands, or
        //     players might end up in the wrong area.
        public static uint CreateArea(string resRef, string newTag = "", string newName = "")
            => Core.NWScript.CreateArea(resRef, newTag, newName);

        //     Create an item with the template sItemTemplate in oTarget's inventory. - nStackSize:
        //     This is the stack size of the item to be created - sNewTag: If this string is
        //     not empty, it will replace the default tag from the template * Return value:
        //     The object that has been created. On error, this returns OBJECT_INVALID. If the
        //     item created was merged into an existing stack of similar items, the function
        //     will return the merged stack object. If the merged stack overflowed, the function
        //     will return the overflowed stack that was created.
        public static uint CreateItemOnObject(string itemTemplate, NWObject? target = null, int stackSize = 1, string newTag = "")
            => Core.NWScript.CreateItemOnObject(itemTemplate, target ?? NWObject.OBJECT_SELF, stackSize, newTag);

        //     Create an object of the specified type at lLocation. - nObjectType: OBJECT_TYPE_ITEM,
        //     OBJECT_TYPE_CREATURE, OBJECT_TYPE_PLACEABLE, OBJECT_TYPE_STORE, OBJECT_TYPE_WAYPOINT
        //     - sTemplate - lLocation - bUseAppearAnimation - sNewTag - if this string is not
        //     empty, it will replace the default tag from the template
        public static uint CreateObject(ObjectType objectType, string template, Location location, bool useAppearAnimation = false, string newTag = "")
            => Core.NWScript.CreateObject((int)objectType, template, location, useAppearAnimation ? 1 : 0, newTag);

        //     Creates a square Trap object. - nTrapType: The base type of trap (TRAP_BASE_TYPE_*)
        //     - lLocation: The location and orientation that the trap will be created at. -
        //     fSize: The size of the trap. Minimum size allowed is 1.0f. - sTag: The tag of
        //     the trap being created. - nFaction: The faction of the trap (STANDARD_FACTION_*).
        //     - sOnDisarmScript: The OnDisarm script that will fire when the trap is disarmed.
        //     If "" no script will fire. - sOnTrapTriggeredScript: The OnTrapTriggered script
        //     that will fire when the trap is triggered. If "" the default OnTrapTriggered
        //     script for the trap type specified will fire instead (as specified in the traps.2da).
        public static uint CreateTrapAtLocation(TrapBaseType trapType, Location location, float size = 2, string tag = "", int faction = 0, string onDisarmScript = "", string onTrapTriggeredScript = "")
            => Core.NWScript.CreateTrapAtLocation((int)trapType, location, size, tag, faction, onDisarmScript, onTrapTriggeredScript);

        //     Creates a Trap on the object specified. - nTrapType: The base type of trap (TRAP_BASE_TYPE_*)
        //     - oObject: The object that the trap will be created on. Works only on Doors and
        //     Placeables. - nFaction: The faction of the trap (STANDARD_FACTION_*). - sOnDisarmScript:
        //     The OnDisarm script that will fire when the trap is disarmed. If "" no script
        //     will fire. - sOnTrapTriggeredScript: The OnTrapTriggered script that will fire
        //     when the trap is triggered. If "" the default OnTrapTriggered script for the
        //     trap type specified will fire instead (as specified in the traps.2da). Note:
        //     After creating a trap on an object, you can change the trap's properties using
        //     the various SetTrap* scripting commands by passing in the object that the trap
        //     was created on (i.e. oObject) to any subsequent SetTrap* commands.
        public static void CreateTrapOnObject(TrapBaseType trapType, NWObject target, int faction = 0, string onDisarmScript = "", string onTrapTriggeredScript = "")
            => Core.NWScript.CreateTrapOnObject((int)trapType, target, faction, onDisarmScript, onTrapTriggeredScript);

        //     Get the total from rolling (nNumDice x d10 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d10(int numDice = 1) => Core.NWScript.d10(numDice);

        //     Get the total from rolling (nNumDice x d100 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d100(int numDice = 1) => Core.NWScript.d100(numDice);

        //     Get the total from rolling (nNumDice x d12 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d12(int numDice = 1) => Core.NWScript.d12(numDice);

        //     Get the total from rolling (nNumDice x d2 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d2(int numDice = 1) => Core.NWScript.d2(numDice);

        //     Get the total from rolling (nNumDice x d20 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d20(int numDice = 1) => Core.NWScript.d20(numDice);

        //     Get the total from rolling (nNumDice x d3 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d3(int numDice = 1) => Core.NWScript.d3(numDice);

        //     Get the total from rolling (nNumDice x d4 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d4(int numDice = 1) => Core.NWScript.d4(numDice);

        //     Get the total from rolling (nNumDice x d6 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d6(int numDice = 1) => Core.NWScript.d6(numDice);

        //     Get the total from rolling (nNumDice x d8 dice). - nNumDice: If this is less
        //     than 1, the value 1 will be used.
        public static int d8(int numDice = 1) => Core.NWScript.d8(numDice);

        //     Changes the current Day/Night cycle for this player to night - oPlayer: which
        //     player to change the lighting for - fTransitionTime: how long the transition
        //     should take
        public static void DayToNight(NWPlayer player, float transitionTime = 0.0f)
            => Core.NWScript.DayToNight(player, transitionTime);

        //     Decrement the remaining uses per day for this creature by one. - oCreature: creature
        //     to modify - nFeat: constant FEAT_*
        public static void DecrementRemainingFeatUses(NWCreature creature, Feat feat)
            => Core.NWScript.DecrementRemainingFeatUses(creature, (int)feat);

        //     Decrement the remaining uses per day for this creature by one. - oCreature: creature
        //     to modify - nSpell: constant SPELL_*
        public static void DecrementRemainingSpellUses(NWCreature creature, Spell spell)
            => Core.NWScript.DecrementRemainingSpellUses(creature, (int)spell);

        //     Delay aActionToDelay by fSeconds. * No return value, but if an error occurs,
        //     the log file will contain "DelayCommand failed.". It is suggested that functions
        //     which create effects should not be used as parameters to delayed actions. Instead,
        //     the effect should be created in the script and then passed into the action. For
        //     example: effect eDamage = EffectDamage(nDamage, DAMAGE_TYPE_MAGICAL); DelayCommand(fDelay,
        //     ApplyEffectToObject(DURATION_TYPE_INSTANT, eDamage, oTarget);
        public static void DelayCommand(float seconds, ActionDelegate actionToDelay)
            => Core.NWScript.DelayCommand(seconds, actionToDelay);

        //     This will remove ANY campaign variable. Regardless of type. Note that by normal
        //     database standards, deleting does not actually removed the entry from the database,
        //     but flags it as deleted. Do not expect the database files to shrink in size from
        //     this command. If you want to 'pack' the database, you will have to do it externally
        //     from the game.
        public static void DeleteCampaignVariable(string campaignName, string varName, NWPlayer? player = null)
            => Core.NWScript.DeleteCampaignVariable(campaignName, varName, player ?? NWObject.OBJECT_INVALID);

        //     Delete oObject's local float variable sVarName
        public static void DeleteLocalFloat(NWObject obj, string varName)
            => Core.NWScript.DeleteLocalFloat(obj, varName);

        //     Delete oObject's local integer variable sVarName
        public static void DeleteLocalInt(NWObject obj, string varName)
            => Core.NWScript.DeleteLocalInt(obj, varName);

        //     Delete oObject's local location variable sVarName
        public static void DeleteLocalLocation(NWObject obj, string varName)
            => Core.NWScript.DeleteLocalLocation(obj, varName);

        //     Delete oObject's local object variable sVarName
        public static void DeleteLocalObject(NWObject obj, string varName)
            => Core.NWScript.DeleteLocalObject(obj, varName);

        //     Delete oObject's local string variable sVarName
        public static void DeleteLocalString(NWObject obj, string varName)
            => Core.NWScript.DeleteLocalString(obj, varName);

        //     Destroys the given area object and everything in it. Return values: 0: Object
        //     not an area or invalid. -1: Area contains spawn location and removal would leave
        //     module without entrypoint. -2: Players in area. 1: Area destroyed successfully.
        public static int DestroyArea(NWArea area)
            => Core.NWScript.DestroyArea(area);

        //     This will delete the entire campaign database if it exists.
        public static void DestroyCampaignDatabase(string campaignName)
            => Core.NWScript.DestroyCampaignDatabase(campaignName);

        //     Destroy oObject (irrevocably). This will not work on modules and areas.
        public static void DestroyObject(NWObject target, float delay = 0.0f)
            => Core.NWScript.DestroyObject(target, delay);

        //     Perform nDoorAction on oTargetDoor.
        public static void DoDoorAction(NWObject door, DoorAction doorAction)
            => Core.NWScript.DoDoorAction(door, (int)doorAction);

        //     The caller performs nPlaceableAction on oPlaceable. - oPlaceable - nPlaceableAction:
        //     PLACEABLE_ACTION_*
        public static void DoPlaceableObjectAction(NWPlaceable placeable, PlaceableAction placeableAction)
            => Core.NWScript.DoPlaceableObjectAction(placeable, (int)placeableAction);

        //     Only if we are in a single player game, AutoSave the game.
        public static void DoSinglePlayerAutoSave()
            => Core.NWScript.DoSinglePlayerAutoSave();

        //     Does a single attack on every hostile creature within 10ft. of the attacker and
        //     determines damage accordingly. If the attacker has a ranged weapon equipped,
        //     this will have no effect. ** NOTE ** This is meant to be called inside the spell
        //     script for whirlwind attack, it is not meant to be used to queue up a new whirlwind
        //     attack. To do that you need to call ActionUseFeat(FEAT_WHIRLWIND_ATTACK, oEnemy)
        //     - int bDisplayFeedback: TRUE or FALSE, whether or not feedback should be displayed
        //     - int bImproved: If TRUE, the improved version of whirlwind is used
        public static void DoWhirlwindAttack(bool displayFeedback = true, bool improved = false)
            => Core.NWScript.DoWhirlwindAttack(displayFeedback ? 1 : 0, improved ? 1 : 0);

        //     Create an Ability Decrease effect. - nAbility: ABILITY_* - nModifyBy: This is
        //     the amount by which to decrement the ability
        public static Effect EffectAbilityDecrease(Ability ability, int modifyBy)
            => Core.NWScript.EffectAbilityDecrease((int)ability, modifyBy);
        //
        // Summary:
        //     Create an Ability Increase effect - bAbilityToIncrease: ABILITY_*
        public static Effect EffectAbilityIncrease(Ability ability, int modifyBy)
            => Core.NWScript.EffectAbilityIncrease((int)ability, modifyBy);

        //     Create an AC Decrease effect. - nValue - nModifyType: AC_* - nDamageType: DAMAGE_TYPE_*
        //     * Default value for nDamageType should only ever be used in this function prototype.
        public static Effect EffectACDecrease(int value, AC modifyType = AC.Dodge, DamageType damageType = DamageType.AcVsAll)
            => Core.NWScript.EffectACDecrease(value, (int)modifyType, (int)damageType);

        //     Create an AC Increase effect - nValue: size of AC increase - nModifyType: AC_*_BONUS
        //     - nDamageType: DAMAGE_TYPE_* * Default value for nDamageType should only ever
        //     be used in this function prototype.
        public static Effect EffectACIncrease(int value, AC modifyType = AC.Dodge, DamageType damageType = DamageType.AcVsAll)
            => Core.NWScript.EffectACIncrease(value, (int)modifyType, (int)damageType);

        //     Create an Appear effect to make the object "fly in". - nAnimation determines
        //     which appear and disappear animations to use. Most creatures only have animation
        //     1, although a few have 2 (like beholders)
        public static Effect EffectAppear(Animation animation = Animation.LoopingPause2)
            => Core.NWScript.EffectAppear((int)animation);

        //     Create an Area Of Effect effect in the area of the creature it is applied to.
        //     If the scripts are not specified, default ones will be used.
        public static Effect EffectAreaOfEffect(AoE aoeType, string onEnterScript = "", string heartbeatScript = "", string onExitScript = "")
            => Core.NWScript.EffectAreaOfEffect((int)aoeType, onEnterScript, heartbeatScript, onExitScript);

        //     Create an Attack Decrease effect. - nPenalty - nModifierType: ATTACK_BONUS_*
        public static Effect EffectAttackDecrease(int penalty, AttackBonus modifierType = AttackBonus.Misc)
            => Core.NWScript.EffectAttackDecrease(penalty, (int)modifierType);

        //     Create an Attack Increase effect - nBonus: size of attack bonus - nModifierType:
        //     ATTACK_BONUS_*
        public static Effect EffectAttackIncrease(int bonus, AttackBonus modifierType = AttackBonus.Misc)
            => Core.NWScript.EffectAttackIncrease(bonus, (int)modifierType);

        //     Create a Beam effect. - nBeamVisualEffect: VFX_BEAM_* - oEffector: the beam is
        //     emitted from this creature - nBodyPart: BODY_NODE_* - bMissEffect: If this is
        //     TRUE, the beam will fire to a random vector near or past the target * Returns
        //     an effect of type EFFECT_TYPE_INVALIDEFFECT if nBeamVisualEffect is not valid.
        public static Effect EffectBeam(VFX beamVisualEffect, NWObject oEmitter, BodyNode bodyPart, bool missEffect = false)
            => Core.NWScript.EffectBeam((int)beamVisualEffect, oEmitter, (int)bodyPart, missEffect ? 1 : 0);

        //     Create a Blindness effect.
        public static Effect EffectBlindness()
            => Core.NWScript.EffectBlindness();

        //     Create a Charm effect
        public static Effect EffectCharmed()
            => Core.NWScript.EffectCharmed();
        public static Effect EffectConcealment(int percentage, MissChanceType missChanceType = MissChanceType.Normal)
            => Core.NWScript.EffectConcealment(percentage, (int)missChanceType);

        //     Create a Confuse effect
        public static Effect EffectConfused() => Core.NWScript.EffectConfused();

        //     Create a Curse effect. - nStrMod: strength modifier - nDexMod: dexterity modifier
        //     - nConMod: constitution modifier - nIntMod: intelligence modifier - nWisMod:
        //     wisdom modifier - nChaMod: charisma modifier
        public static Effect EffectCurse(int strMod = 1, int dexMod = 1, int conMod = 1, int intMod = 1, int wisMod = 1, int chaMod = 1)
            => Core.NWScript.EffectCurse(strMod, dexMod, conMod, intMod, wisMod, chaMod);

        //     Returns an effect that is guaranteed to dominate a creature Like EffectDominated
        //     but cannot be resisted
        public static Effect EffectCutsceneDominated()
            => Core.NWScript.EffectCutsceneDominated();

        //     Creates a cutscene ghost effect, this will allow creatures to pathfind through
        //     other creatures without bumping into them for the duration of the effect.
        public static Effect EffectCutsceneGhost()
            => Core.NWScript.EffectCutsceneDominated();

        //     Returns an effect that when applied will paralyze the target's legs, rendering
        //     them unable to walk but otherwise unpenalized. This effect cannot be resisted.
        public static Effect EffectCutsceneImmobilize()
            => Core.NWScript.EffectCutsceneImmobilize();

        //     returns an effect that is guaranteed to paralyze a creature. this effect is identical
        //     to EffectParalyze except that it cannot be resisted.
        public static Effect EffectCutsceneParalyze()
            => Core.NWScript.EffectCutsceneParalyze();

        //     Create a Damage effect - damageAmount: amount of damage to be dealt. This should
        //     be applied as an instantaneous effect.
        public static Effect EffectDamage(int damageAmount, DamageType damageType = DamageType.Magical, DamagePower damagePower = DamagePower.Normal)
            => Core.NWScript.EffectDamage(damageAmount, (int)damageType, (int)damagePower);

        //     Create a Damage Decrease effect. - nPenalty - nDamageType: DAMAGE_TYPE_*
        public static Effect EffectDamageDecrease(int penalty, DamageType damageType = DamageType.Magical)
            => Core.NWScript.EffectDamageDecrease(penalty, (int)damageType);

        //     Create a Damage Immunity Decrease effect. - nDamageType: DAMAGE_TYPE_* - nPercentImmunity
        public static Effect EffectDamageImmunityDecrease(DamageType damageType, int percentImmunity)
            => Core.NWScript.EffectDamageImmunityDecrease((int)damageType, percentImmunity);

        //     Creates a Damage Immunity Increase effect. - nDamageType: DAMAGE_TYPE_* - nPercentImmunity
        public static Effect EffectDamageImmunityIncrease(DamageType damageType, int percentImmunity)
            => Core.NWScript.EffectDamageImmunityIncrease((int)damageType, percentImmunity);

        //     Create a Damage Increase effect - nBonus: DAMAGE_BONUS_* - nDamageType: DAMAGE_TYPE_*
        //     NOTE! You *must* use the DAMAGE_BONUS_* constants! Using other values may result
        //     in odd behaviour.
        public static Effect EffectDamageIncrease(int bonus, DamageType damageType = DamageType.Magical)
            => Core.NWScript.EffectDamageIncrease(bonus, (int)damageType);

        //     Create a Damage Reduction effect - nAmount: amount of damage reduction - nDamagePower:
        //     DAMAGE_POWER_* - nLimit: How much damage the effect can absorb before disappearing.
        //     Set to zero for infinite
        public static Effect EffectDamageReduction(int amount, DamagePower damagePower, int limit = 0)
            => Core.NWScript.EffectDamageReduction(amount, (int)damagePower, limit);

        //     Create a Damage Resistance effect that removes the first nAmount points of damage
        //     of type nDamageType, up to nLimit (or infinite if nLimit is 0) - nDamageType:
        //     DAMAGE_TYPE_* - nAmount - nLimit
        public static Effect EffectDamageResistance(DamageType damageType, int amount, int limit = 0)
            => Core.NWScript.EffectDamageResistance((int)damageType, amount, limit);

        //     Create a Damage Shield effect which does (nDamageAmount + nRandomAmount) damage
        //     to any melee attacker on a successful attack of damage type nDamageType. - nDamageAmount:
        //     an integer value - nRandomAmount: DAMAGE_BONUS_* - nDamageType: DAMAGE_TYPE_*
        //     NOTE! You *must* use the DAMAGE_BONUS_* constants! Using other values may result
        //     in odd behaviour.
        public static Effect EffectDamageShield(int damageAmount, DamageBonus damageBonus, DamageType damageType)
            => Core.NWScript.EffectDamageShield(damageAmount, (int)damageBonus, (int)damageType);

        //     Create a Darkness effect.
        public static Effect EffectDarkness()
            => Core.NWScript.EffectDarkness();

        //     Create a Daze effect
        public static Effect EffectDazed()
            => Core.NWScript.EffectDazed();

        //     Create a Deaf effect
        public static Effect EffectDeaf()
            => Core.NWScript.EffectDeaf();

        //     Create a Death effect - nSpectacularDeath: if this is TRUE, the creature to which
        //     this effect is applied will die in an extraordinary fashion - nDisplayFeedback
        public static Effect EffectDeath(bool spectacularDeath = false, bool displayFeedback = true)
            => Core.NWScript.EffectDeath(spectacularDeath ? 1 : 0, displayFeedback ? 1 : 0);

        //     Create a Disappear effect to make the object "fly away" and then destroy itself.
        //     - nAnimation determines which appear and disappear animations to use. Most creatures
        //     only have animation 1, although a few have 2 (like beholders)
        public static Effect EffectDisappear(Animation animation = Animation.LoopingPause2)
            => Core.NWScript.EffectDisappear((int)animation);

        //     Create a Disappear/Appear effect. The object will "fly away" for the duration
        //     of the effect and will reappear at lLocation. - nAnimation determines which appear
        //     and disappear animations to use. Most creatures only have animation 1, although
        //     a few have 2 (like beholders)
        public static Effect EffectDisappearAppear(Location location, Animation animation = Animation.LoopingPause2)
            => Core.NWScript.EffectDisappearAppear(location, (int)animation);

        //     Create a Disease effect. - nDiseaseType: DISEASE_*
        public static Effect EffectDisease(Disease diseaseType)
            => Core.NWScript.EffectDisease((int)diseaseType);

        //     Create a Dispel Magic All effect. If no parameter is specified, USE_CREATURE_LEVEL
        //     will be used. This will cause the dispel effect to use the level of the creature
        //     that created the effect.
        public static Effect EffectDispelMagicAll(int casterLevel = 0)
            => Core.NWScript.EffectDispelMagicAll(casterLevel);

        //     Create a Dispel Magic Best effect. If no parameter is specified, USE_CREATURE_LEVEL
        //     will be used. This will cause the dispel effect to use the level of the creature
        //     that created the effect.
        public static Effect EffectDispelMagicBest(int casterLevel = 0)
            => Core.NWScript.EffectDispelMagicBest(casterLevel);

        //     Create a Dominate effect
        public static Effect EffectDominated()
            => Core.NWScript.EffectDominated();

        //     Create an Entangle effect When applied, this effect will restrict the creature's
        //     movement and apply a (-2) to all attacks and a -4 to AC.
        public static Effect EffectEntangle()
            => Core.NWScript.EffectEntangle();

        //     Returns an effect of type EFFECT_TYPE_ETHEREAL which works just like EffectSanctuary
        //     except that the observers get no saving throw
        public static Effect EffectEthereal()
            => Core.NWScript.EffectEthereal();

        //     Create a Frighten effect
        public static Effect EffectFrightened()
            => Core.NWScript.EffectFrightened();
        //
        // Summary:
        //     Create a Haste effect.
        public static Effect EffectHaste()
            => Core.NWScript.EffectHaste();
        public static Effect EffectHeal(int damageToHeal)
            => Core.NWScript.EffectHeal(damageToHeal);

        //     Create a Hit Point Change When Dying effect. - fHitPointChangePerRound: this
        //     can be positive or negative, but not zero. * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT
        //     if fHitPointChangePerRound is 0.
        public static Effect EffectHitPointChangeWhenDying(float hitPointChangePerRound)
            => Core.NWScript.EffectHitPointChangeWhenDying(hitPointChangePerRound);

        //     Create an Immunity effect. - nImmunityType: IMMUNITY_TYPE_*
        public static Effect EffectImmunity(ImmunityType immunityType)
            => Core.NWScript.EffectImmunity((int)immunityType);

        //     Create an Invisibility effect. - nInvisibilityType: INVISIBILITY_TYPE_* * Returns
        //     an effect of type EFFECT_TYPE_INVALIDEFFECT if nInvisibilityType is invalid.
        public static Effect EffectInvisibility(InvisibilityType invisibilityType)
            => Core.NWScript.EffectInvisibility((int)invisibilityType);

        //     Create a Knockdown effect This effect knocks creatures off their feet, they will
        //     sit until the effect is removed. This should be applied as a temporary effect
        //     with a 3 second duration minimum (1 second to fall, 1 second sitting, 1 second
        //     to get up).
        public static Effect EffectKnockdown() => Core.NWScript.EffectKnockdown();

        //     Link the two supplied effects, returning eChildEffect as a child of eParentEffect.
        //     Note: When applying linked effects if the target is immune to all valid effects
        //     all other effects will be removed as well. This means that if you apply a visual
        //     effect and a silence effect (in a link) and the target is immune to the silence
        //     effect that the visual effect will get removed as well. Visual Effects are not
        //     considered "valid" effects for the purposes of determining if an effect will
        //     be removed or not and as such should never be packaged *only* with other visual
        //     effects in a link.
        public static Effect EffectLinkEffects(Effect childEffect, Effect parentEffect)
            => Core.NWScript.EffectLinkEffects(childEffect, parentEffect);
        public static Effect EffectMissChance(int percentage, MissChanceType missChanceType = MissChanceType.Normal)
            => Core.NWScript.EffectMissChance(percentage, (int)missChanceType);

        //     Create a Modify Attacks effect to add attacks. - nAttacks: maximum is 5, even
        //     with the effect stacked * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT
        //     if nAttacks > 5.
        public static Effect EffectModifyAttacks(int attacks)
            => Core.NWScript.EffectModifyAttacks(attacks);

        //     Create a Movement Speed Decrease effect. - nPercentChange - range 0 through 99
        //     eg. 0 = no change in speed 50 = 50% slower 99 = almost immobile
        public static Effect EffectMovementSpeedDecrease(int percentChange)
            => Core.NWScript.EffectMovementSpeedDecrease(percentChange);

        //     Create a Movement Speed Increase effect. - nPercentChange - range 0 through 99
        //     eg. 0 = no change in speed 50 = 50% faster 99 = almost twice as fast
        public static Effect EffectMovementSpeedIncrease(int percentChange)
            => Core.NWScript.EffectMovementSpeedIncrease(percentChange);

        //     Create a Negative Level effect. - nNumLevels: the number of negative levels to
        //     apply. * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nNumLevels >
        //     100.
        public static Effect EffectNegativeLevel(int numLevels, int hpBonus = 0)
            => Core.NWScript.EffectNegativeLevel(numLevels, hpBonus);

        //     Create a Paralyze effect
        public static Effect EffectParalyze()
            => Core.NWScript.EffectParalyze();

        //     returns an effect that will petrify the target * currently applies EffectParalyze
        //     and the stoneskin visual effect.
        public static Effect EffectPetrify()
            => Core.NWScript.EffectPetrify();

        //     Create a Poison effect. - nPoisonType: POISON_*
        public static Effect EffectPoison(Poison poisonType)
            => Core.NWScript.EffectPoison((int)poisonType);

        //     Create a Polymorph effect.
        public static Effect EffectPolymorph(PolymorphType polymorphSelection, bool locked = false)
            => Core.NWScript.EffectPolymorph((int)polymorphSelection, locked ? 1 : 0);

        //     Create a Regenerate effect. - nAmount: amount of damage to be regenerated per
        //     time interval - fIntervalSeconds: length of interval in seconds
        public static Effect EffectRegenerate(int amount, float intervalSeconds)
            => Core.NWScript.EffectRegenerate(amount, intervalSeconds);

        //     Create a Resurrection effect. This should be applied as an instantaneous effect.
        public static Effect EffectResurrection()
            => Core.NWScript.EffectResurrection();
        public static Effect EffectSanctuary(int difficultyClass)
            => Core.NWScript.EffectSanctuary(difficultyClass);

        //     Create a Saving Throw Decrease effect. - nSave: SAVING_THROW_* (not SAVING_THROW_TYPE_*)
        //     SAVING_THROW_ALL SAVING_THROW_FORT SAVING_THROW_REFLEX SAVING_THROW_WILL - nValue:
        //     size of the Saving Throw decrease - nSaveType: SAVING_THROW_TYPE_* (e.g. SAVING_THROW_TYPE_ACID
        //     )
        public static Effect EffectSavingThrowDecrease(SavingThrow savingThrow, int value, SavingThrowType savingThrowType = SavingThrowType.All)
            => Core.NWScript.EffectSavingThrowDecrease((int)savingThrow, value, (int)savingThrowType);

        //     Create a Saving Throw Increase effect - nSave: SAVING_THROW_* (not SAVING_THROW_TYPE_*)
        //     SAVING_THROW_ALL SAVING_THROW_FORT SAVING_THROW_REFLEX SAVING_THROW_WILL - nValue:
        //     size of the Saving Throw increase - nSaveType: SAVING_THROW_TYPE_* (e.g. SAVING_THROW_TYPE_ACID
        //     )
        public static Effect EffectSavingThrowIncrease(SavingThrow savingThrow, int value, SavingThrowType savingThrowType = SavingThrowType.All)
            => Core.NWScript.EffectSavingThrowIncrease((int)savingThrow, value, (int)savingThrowType);

        //     Create a See Invisible effect.
        public static Effect EffectSeeInvisible()
            => Core.NWScript.EffectSeeInvisible();

        //     Create a Silence effect.
        public static Effect EffectSilence()
            => Core.NWScript.EffectSilence();

        //     Create a Skill Decrease effect. * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT
        //     if nSkill is invalid.
        public static Effect EffectSkillDecrease(Skill skill, int value)
            => Core.NWScript.EffectSkillDecrease((int)skill, value);

        //     Create a Skill Increase effect. - nSkill: SKILL_* - nValue * Returns an effect
        //     of type EFFECT_TYPE_INVALIDEFFECT if nSkill is invalid.
        public static Effect EffectSkillIncrease(Skill skill, int value)
            => Core.NWScript.EffectSkillIncrease((int)skill, value);

        //     Create a Sleep effect
        public static Effect EffectSleep()
            => Core.NWScript.EffectSleep();

        //     Create a Slow effect.
        public static Effect EffectSlow()
            => Core.NWScript.EffectSlow();

        //     Creates an effect that inhibits spells - nPercent - percentage of failure - nSpellSchool
        //     - the school of spells affected.
        public static Effect EffectSpellFailure(int percent = 100, SpellSchool spellSchool = SpellSchool.General)
            => Core.NWScript.EffectSpellFailure(percent, (int)spellSchool);

        //     Create a Spell Immunity effect. There is a known bug with this function. There
        //     *must* be a parameter specified when this is called (even if the desired parameter
        //     is SPELL_ALL_SPELLS), otherwise an effect of type EFFECT_TYPE_INVALIDEFFECT will
        //     be returned. - nImmunityToSpell: SPELL_* * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT
        //     if nImmunityToSpell is invalid.
        public static Effect EffectSpellImmunity(Spell spell = Spell.AllSpells)
            => Core.NWScript.EffectSpellImmunity((int)spell);

        //     Create a Spell Level Absorption effect. - nMaxSpellLevelAbsorbed: maximum spell
        //     level that will be absorbed by the effect - nTotalSpellLevelsAbsorbed: maximum
        //     number of spell levels that will be absorbed by the effect - nSpellSchool: SPELL_SCHOOL_*
        //     * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if: nMaxSpellLevelAbsorbed
        //     is not between -1 and 9 inclusive, or nSpellSchool is invalid.
        public static Effect EffectSpellLevelAbsorption(int maxSpellLevelAbsorbed, int totalSpellLevelsAbsorbed = 0, SpellSchool spellSchool = SpellSchool.General)
            => Core.NWScript.EffectSpellLevelAbsorption(maxSpellLevelAbsorbed, totalSpellLevelsAbsorbed, (int)spellSchool);

        //     Create a Spell Resistance Decrease effect.
        public static Effect EffectSpellResistanceDecrease(int value)
            => Core.NWScript.EffectSpellResistanceDecrease(value);

        //     Create a Spell Resistance Increase effect. - nValue: size of spell resistance
        //     increase
        public static Effect EffectSpellResistanceIncrease(int value)
            => Core.NWScript.EffectSpellResistanceIncrease(value);

        //     Create a Stun effect
        public static Effect EffectStunned() => Core.NWScript.EffectStunned();

        //     Create a Summon Creature effect. The creature is created and placed into the
        //     caller's party/faction. - sCreatureResref: Identifies the creature to be summoned
        //     - nVisualEffectId: VFX_* - fDelaySeconds: There can be delay between the visual
        //     effect being played, and the creature being added to the area - nUseAppearAnimation:
        //     should this creature play it's "appear" animation when it is summoned. If zero,
        //     it will just fade in somewhere near the target. If the value is 1 it will use
        //     the appear animation, and if it's 2 it will use appear2 (which doesn't exist
        //     for most creatures)
        public static Effect EffectSummonCreature(string creatureResref, VFX vfx = VFX.None, float delaySeconds = 0, bool useAppearAnimation = false)
            => Core.NWScript.EffectSummonCreature(creatureResref, (int)vfx, delaySeconds, useAppearAnimation ? 1 : 0);

        //     Create a Swarm effect. - nLooping: If this is TRUE, for the duration of the effect
        //     when one creature created by this effect dies, the next one in the list will
        //     be created. If the last creature in the list dies, we loop back to the beginning
        //     and sCreatureTemplate1 will be created, and so on... - sCreatureTemplate1 - sCreatureTemplate2
        //     - sCreatureTemplate3 - sCreatureTemplate4
        public static Effect EffectSwarm(bool looping, string creatureTemplate1, string creatureTemplate2 = "", string creatureTemplate3 = "", string creatureTemplate4 = "")
            => Core.NWScript.EffectSwarm(looping ? 1 : 0, creatureTemplate1, creatureTemplate2, creatureTemplate3, creatureTemplate4);
        public static Effect EffectTemporaryHitpoints(int hitPoints)
            => Core.NWScript.EffectTemporaryHitpoints(hitPoints);

        //     Create a Time Stop effect.
        public static Effect EffectTimeStop()
            => Core.NWScript.EffectTimeStop();

        //     Create a True Seeing effect.
        public static Effect EffectTrueSeeing()
            => Core.NWScript.EffectTrueSeeing();

        //     Create a Turned effect. Turned effects are supernatural by default.
        public static Effect EffectTurned()
            => Core.NWScript.EffectTurned();

        //     Create a Turn Resistance Decrease effect. - nHitDice: a positive number representing
        //     the number of hit dice for the / decrease
        public static Effect EffectTurnResistanceDecrease(int hitDice)
            => Core.NWScript.EffectTurnResistanceDecrease(hitDice);

        //     Create a Turn Resistance Increase effect. - nHitDice: a positive number representing
        //     the number of hit dice for the increase
        public static Effect EffectTurnResistanceIncrease(int hitDice)
            => Core.NWScript.EffectTurnResistanceIncrease(hitDice);

        //     Create an Ultravision effect.
        public static Effect EffectUltravision()
            => Core.NWScript.EffectUltravision();

        //     * Create a Visual Effect that can be applied to an object. - nVisualEffectId
        //     - nMissEffect: if this is TRUE, a random vector near or past the target will
        //     be generated, on which to play the effect
        public static Effect EffectVisualEffect(VFX vfx, bool missEffect = false)
            => Core.NWScript.EffectVisualEffect((int)vfx, missEffect ? 1 : 0);

        //     End the currently running game, play sEndMovie then return all players to the
        //     game's main menu.
        public static void EndGame(string endMovie)
            => Core.NWScript.EndGame(endMovie);

        //     Activate oItem.
        public static Event EventActivateItem(NWItem oItem, Location targetLoc, NWObject? target = null)
            => Core.NWScript.EventActivateItem(oItem, targetLoc, target ?? NWObject.OBJECT_INVALID);

        //     Creates a conversation event. Note: This only creates the event. The event wont
        //     actually trigger until SignalEvent() is called using this created conversation
        //     event as an argument. For example: SignalEvent(oCreature, EventConversation());
        //     Once the event has been signaled. The script associated with the OnConversation
        //     event will run on the creature oCreature. To specify the OnConversation script
        //     that should run, view the Creature Properties on the creature and click on the
        //     Scripts Tab. Then specify a script for the OnConversation event.
        public static Event EventConversation()
            => Core.NWScript.EventConversation();

        //     Create an event which triggers the "SpellCastAt" script Note: This only creates
        //     the event. The event wont actually trigger until SignalEvent() is called using
        //     this created SpellCastAt event as an argument. For example: SignalEvent(oCreature,
        //     EventSpellCastAt(oCaster, SPELL_MAGIC_MISSILE, TRUE)); This function doesn't
        //     cast the spell specified, it only creates an event so that when the event is
        //     signaled on an object, the object will use its OnSpellCastAt script to react
        //     to the spell being cast. To specify the OnSpellCastAt script that should run,
        //     view the Object's Properties and click on the Scripts Tab. Then specify a script
        //     for the OnSpellCastAt event. From inside the OnSpellCastAt script call: GetLastSpellCaster()
        //     to get the object that cast the spell (oCaster). GetLastSpell() to get the type
        //     of spell cast (nSpell) GetLastSpellHarmful() to determine if the spell cast at
        //     the object was harmful.
        public static Event EventSpellCastAt(NWCreature caster, Spell spell, bool harmful = true)
            => Core.NWScript.EventSpellCastAt(caster, (int)spell, harmful ? 1 : 0);

        //     Create an event of the type nUserDefinedEventNumber Note: This only creates the
        //     event. The event wont actually trigger until SignalEvent() is called using this
        //     created UserDefined event as an argument. For example: SignalEvent(oObject, EventUserDefined(9999));
        //     Once the event has been signaled. The script associated with the OnUserDefined
        //     event will run on the object oObject. To specify the OnUserDefined script that
        //     should run, view the object's Properties and click on the Scripts Tab. Then specify
        //     a script for the OnUserDefined event. From inside the OnUserDefined script call:
        //     GetUserDefinedEventNumber() to retrieve the value of nUserDefinedEventNumber
        //     that was used when the event was signaled.
        public static Event EventUserDefined(int userDefinedEventNumber)
            => Core.NWScript.EventUserDefined(userDefinedEventNumber);

        //     Make oTarget run sScript and then return execution to the calling script. If
        //     sScript does not specify a compiled script, nothing happens.
        public static void ExecuteScript(string script, NWObject target)
            => Core.NWScript.ExecuteScript(script, target);

        //     Execute a script chunk. The script chunk runs immediately, same as ExecuteScript().
        //     The script is jitted in place and currently not cached: Each invocation will
        //     recompile the script chunk. Note that the script chunk will run as if a separate
        //     script. This is not eval(). By default, the script chunk is wrapped into void
        //     main() {}. Pass in bWrapIntoMain = FALSE to override. Returns "" on success,
        //     or the compilation error.
        public static string ExecuteScriptChunk(string scriptChunk, NWObject obj, bool wrapIntoMain = true)
            => Core.NWScript.ExecuteScriptChunk(scriptChunk, obj, wrapIntoMain ? 1 : 0);

        //     Expose/Hide the entire map of oArea for oPlayer. - oArea: The area that the map
        //     will be exposed/hidden for. - oPlayer: The player the map will be exposed/hidden
        //     for. - bExplored: TRUE/FALSE. Whether the map should be completely explored or
        //     hidden.
        public static void ExploreAreaForPlayer(NWArea area, NWPlayer player, bool explored = true)
            => Core.NWScript.ExploreAreaForPlayer(area, player, explored ? 1 : 0);

        //     Force all the characters of the players who are currently in the game to be exported
        //     to their respective directories i.e. LocalVault/ServerVault/ etc.
        public static void ExportAllCharacters()
            => Core.NWScript.ExportAllCharacters();

        //     Force the character of the player specified to be exported to its respective
        //     directory i.e. LocalVault/ServerVault/ etc.
        public static void ExportSingleCharacter(NWPlayer player)
            => Core.NWScript.ExportSingleCharacter(player);

        //     Set the subtype of eEffect to Extraordinary and return eEffect. (Effects default
        //     to magical if the subtype is not set) Extraordinary effects are removed by resting,
        //     but not by dispel magic
        public static Effect ExtraordinaryEffect(Effect effect)
            => Core.NWScript.ExtraordinaryEffect(effect);

        //     math operations Maths operation: absolute value of fValue
        public static float fabs(float value)
            => Core.NWScript.fabs(value);

        //     Fades the screen for the given creature/player from black to regular screen -
        //     oCreature: creature controlled by player that should fade from black
        public static void FadeFromBlack(NWCreature creature, float speed = 0.01f)
            => Core.NWScript.FadeFromBlack(creature, speed);

        //     Fades the screen for the given creature/player from regular screen to black -
        //     oCreature: creature controlled by player that should fade to black
        public static void FadeToBlack(NWCreature creature, float speed = 0.01f)
            => Core.NWScript.FadeToBlack(creature, speed);

        //     Convert fFeet into a number of meters.
        public static float FeetToMeters(float feet)
            => Core.NWScript.FeetToMeters(feet);

        //     Find the position of sSubstring inside sString - nStart: The character position
        //     to start searching at (from the left end of the string). * Return value on error:
        //     -1
        public static int FindSubString(string stringToSearch, string subString, int start = 0)
            => Core.NWScript.FindSubString(stringToSearch, subString, start);

        //     Display floaty text above the specified creature. The text will also appear in
        //     the chat buffer of each player that receives the floaty text. - sStringToDisplay:
        //     String - oCreatureToFloatAbove - bBroadcastToFaction: If this is TRUE then only
        //     creatures in the same faction as oCreatureToFloatAbove will see the floaty text,
        //     and only if they are within range (30 metres).
        public static void FloatingTextStringOnCreature(string stringToDisplay, NWCreature creatureToFloatAbove, bool broadcastToFaction = true)
            => Core.NWScript.FloatingTextStringOnCreature(stringToDisplay, creatureToFloatAbove, broadcastToFaction ? 1 : 0);

        //     Display floaty text above the specified creature. The text will also appear in
        //     the chat buffer of each player that receives the floaty text. - nStrRefToDisplay:
        //     String ref (therefore text is translated) - oCreatureToFloatAbove - bBroadcastToFaction:
        //     If this is TRUE then only creatures in the same faction as oCreatureToFloatAbove
        //     will see the floaty text, and only if they are within range (30 metres).
        public static void FloatingTextStrRefOnCreature(int strRefToDisplay, NWCreature creatureToFloatAbove, bool broadcastToFaction = true)
            => Core.NWScript.FloatingTextStrRefOnCreature(strRefToDisplay, creatureToFloatAbove, broadcastToFaction ? 1 : 0);

        //     Convert fFloat into the nearest integer.
        public static int FloatToInt(float f)
            => Core.NWScript.FloatToInt(f);

        //     Convert fFloat into a string. - nWidth should be a value from 0 to 18 inclusive.
        //     - nDecimals should be a value from 0 to 9 inclusive.
        public static string FloatToString(float f, int width = 18, int decimals = 9)
            => Core.NWScript.FloatToString(f, width, decimals);

        //     Forces the given object to receive a new UUID, discarding the current value.
        public static void ForceRefreshObjectUUID(NWObject obj)
            => Core.NWScript.ForceRefreshObjectUUID(obj);

        //     Instantly gives this creature the benefits of a rest (restored hitpoints, spells,
        //     feats, etc..)
        public static void ForceRest(NWCreature creature)
            => Core.NWScript.ForceRest(creature);

        //     Do a Fortitude Save check for the given DC - oCreature - nDC: Difficulty check
        //     - nSaveType: SAVING_THROW_TYPE_* - oSaveVersus Returns: 0 if the saving throw
        //     roll failed Returns: 1 if the saving throw roll succeeded Returns: 2 if the target
        //     was immune to the save type specified Note: If used within an Area of Effect
        //     Object Script (On Enter, OnExit, OnHeartbeat), you MUST pass GetAreaOfEffectCreator()
        //     into oSaveVersus!!
        public enum SavingThrowResult { Failed = 0, Succeeded = 1, Immune = 2 };
        public static SavingThrowResult FortitudeSave(NWCreature creature, int dc, SavingThrowType savingThrowType = SavingThrowType.All, NWObject? obj = null)
            => (SavingThrowResult)Core.NWScript.FortitudeSave(creature, dc, (int)savingThrowType, obj ?? NWObject.OBJECT_INVALID);

        //     Gets a value from a 2DA file on the server and returns it as a string avoid using
        //     this function in loops - s2DA: the name of the 2da file, 16 chars max - sColumn:
        //     the name of the column in the 2da - nRow: the row in the 2da * returns an empty
        //     string if file, row, or column not found
        public static string Get2DAString(string s2DA, string column, int row)
            => Core.NWScript.Get2DAString(s2DA, column, row);

        //     Gets the ability bonus limit. - The default value is 12.
        public static int GetAbilityBonusLimit()
            => Core.NWScript.GetAbilityBonusLimit();

        //     Returns the ability modifier for the specified ability Get oCreature's ability
        //     modifier for nAbility. - nAbility: ABILITY_* - oCreature
        public static int GetAbilityModifier(Ability ability, NWCreature? creature = null)
            => Core.NWScript.GetAbilityModifier((int)ability, creature ?? NWObject.OBJECT_SELF);

        //     Gets the ability penalty limit. - The default value is 30.
        public static int GetAbilityPenaltyLimit()
            => Core.NWScript.GetAbilityPenaltyLimit();

        //     Get the ability score of type nAbility for a creature (otherwise 0) - oCreature:
        //     the creature whose ability score we wish to find out - nAbilityType: ABILITY_*
        //     - nBaseAbilityScore: if set to true will return the base ability score without
        //     bonuses (e.g. ability bonuses granted from equipped items). Return value on error:
        //     0
        public static int GetAbilityScore(NWCreature creature, Ability ability, int baseAbilityScore = 0)
            => Core.NWScript.GetAbilityScore(creature, (int)ability, baseAbilityScore);

        //     If oObject is a creature, this will return that creature's armour class If oObject
        //     is an item, door or placeable, this will return zero. - nForFutureUse: this parameter
        //     is not currently used * Return value if oObject is not a creature, item, door
        //     or placeable: -1
        public static int GetAC(NWObject obj, int forFutureUse = 0)
            => Core.NWScript.GetAC(obj, forFutureUse);

        //     Gets the status of ACTION_MODE_* modes on a creature.
        public static int GetActionMode(NWCreature creature, ActionMode mode)
            => Core.NWScript.GetActionMode(creature, (int)mode);

        //     Get oCreature's age. * Returns 0 if oCreature is invalid.
        public static int GetAge(NWCreature creature)
            => Core.NWScript.GetAge(creature);

        //     Gets the current AI Level that the creature is running at. Returns one of the
        //     following: AI_LEVEL_INVALID, AI_LEVEL_VERY_LOW, AI_LEVEL_LOW, AI_LEVEL_NORMAL,
        //     AI_LEVEL_HIGH, AI_LEVEL_VERY_HIGH
        public static AILevel GetAILevel(NWCreature? creature = null)
            => (AILevel)Core.NWScript.GetAILevel(creature ?? NWObject.OBJECT_SELF);

        //     Return an ALIGNMENT_* constant to represent oCreature's good/evil alignment *
        //     Return value if oCreature is not a valid creature: -1
        public static Alignment GetAlignmentGoodEvil(NWCreature creature)
            => (Alignment)Core.NWScript.GetAlignmentGoodEvil(creature);

        //     Return an ALIGNMENT_* constant to represent oCreature's law/chaos alignment *
        //     Return value if oCreature is not a valid creature: -1
        public static Alignment GetAlignmentLawChaos(NWCreature creature)
            => (Alignment)Core.NWScript.GetAlignmentLawChaos(creature);

        //     Get oCreature's animal companion creature type (ANIMAL_COMPANION_CREATURE_TYPE_*).
        //     * Returns ANIMAL_COMPANION_CREATURE_TYPE_NONE if oCreature is invalid or does
        //     not currently have an animal companion.
        public static AnimalCompanionCreatureType GetAnimalCompanionCreatureType(NWCreature creature)
            => (AnimalCompanionCreatureType)Core.NWScript.GetAnimalCompanionCreatureType(creature);

        //     Get oCreature's animal companion's name. * Returns "" if oCreature is invalid,
        //     does not currently have an animal companion or if the animal companion's name
        //     is blank.
        public static string GetAnimalCompanionName(NWCreature target)
            => Core.NWScript.GetAnimalCompanionName(target);

        //     returns the appearance type of the specified creature. * returns a constant APPEARANCE_TYPE_*
        //     for valid creatures * returns APPEARANCE_TYPE_INVALID for non creatures/invalid
        //     creatures
        public static AppearanceType GetAppearanceType(NWCreature creature)
            => (AppearanceType)Core.NWScript.GetAppearanceType(creature);

        //     Returns the current arcane spell failure factor of a creature
        public static int GetArcaneSpellFailure(NWCreature creature)
            => Core.NWScript.GetArcaneSpellFailure(creature);
        //
        // Summary:
        //     Get the area that oTarget is currently in * Return value on error: OBJECT_INVALID
        public static NWArea GetArea(NWObject oTarget)
            => new NWArea(Core.NWScript.GetArea(oTarget));

        //     Get the area's object ID from lLocation.
        public static NWArea GetAreaFromLocation(Location location)
            => new NWArea(Core.NWScript.GetAreaFromLocation(location));

        //     This returns the creator of oAreaOfEffectObject. * Returns OBJECT_INVALID if
        //     oAreaOfEffectObject is not a valid Area of Effect object.
        public static NWObject GetAreaOfEffectCreator(NWObject? areaOfEffectObject = null)
            => new NWObject(Core.NWScript.GetAreaOfEffectCreator(areaOfEffectObject ?? NWObject.OBJECT_SELF));

        //     Gets the size of the area. - nAreaDimension: The area dimension that you wish
        //     to determine. AREA_HEIGHT AREA_WIDTH - oArea: The area that you wish to get the
        //     size of. Returns: The number of tiles that the area is wide/high, or zero on
        //     an error. If no valid area (or object) is specified, it uses the area of the
        //     caller. If an object other than an area is specified, will use the area that
        //     the object is currently in.
        public static int GetAreaSize(AreaDimension areaDimension, NWObjectBase areaOrObject)
            => Core.NWScript.GetAreaSize((int)areaDimension, areaOrObject);

        //     Get the associate of type nAssociateType belonging to oMaster. - nAssociateType:
        //     ASSOCIATE_TYPE_* - nMaster - nTh: Which associate of the specified type to return
        //     * Returns OBJECT_INVALID if no such associate exists.
        public static NWCreature GetAssociate(AssociateType associateType, NWCreature? master = null, int nth = 1)
            => new NWCreature(Core.NWScript.GetAssociate((int)associateType, master ?? NWObject.OBJECT_SELF, nth));

        //     Returns the associate type of the specified creature. - Returns ASSOCIATE_TYPE_NONE
        //     if the creature is not the associate of anyone.
        public static AssociateType GetAssociateType(NWCreature associate)
            => (AssociateType)Core.NWScript.GetAssociateType(associate);

        //     Gets the attack bonus limit. - The default value is 20.
        public static int GetAttackBonusLimit()
            => Core.NWScript.GetAttackBonusLimit();

        //     Get the attack target of oCreature. This only works when oCreature is in combat.
        public static NWObject GetAttackTarget(NWCreature creature)
            => new NWObject(Core.NWScript.GetAttackTarget(creature));

        //     Get the target that the caller attempted to attack - this should be used in conjunction
        //     with GetAttackTarget(). This value is set every time an attack is made, and is
        //     reset at the end of combat. * Returns OBJECT_INVALID if the caller is not a valid
        //     creature.
        public static uint GetAttemptedAttackTarget()
            => Core.NWScript.GetAttemptedAttackTarget();

        //     Get the target at which the caller attempted to cast a spell. This value is set
        //     every time a spell is cast and is reset at the end of combat. * Returns OBJECT_INVALID
        //     if the caller is not a valid creature.
        public static uint GetAttemptedSpellTarget()
            => Core.NWScript.GetAttemptedSpellTarget();

        //     Returns the base attach bonus for the given creature.
        public static int GetBaseAttackBonus(NWCreature creature)
            => Core.NWScript.GetBaseAttackBonus(creature);

        //     Get the base item type (BASE_ITEM_*) of oItem. * Returns BASE_ITEM_INVALID if
        //     oItem is an invalid item.
        public static BaseItem GetBaseItemType(NWItem item)
            => (BaseItem)Core.NWScript.GetBaseItemType(item);

        //     Get the last blocking door encountered by the caller of this function. * Returns
        //     OBJECT_INVALID if the caller is not a valid creature.
        public static NWObject GetBlockingDoor()
            => new NWObject(Core.NWScript.GetBlockingDoor());

        //     Get the current calendar day.
        public static int GetCalendarDay()
            => Core.NWScript.GetCalendarDay();

        //     Get the current calendar month.
        public static int GetCalendarMonth()
            => Core.NWScript.GetCalendarMonth();

        //     Get the current calendar year.
        public static int GetCalendarYear()
            => Core.NWScript.GetCalendarYear();

        //     This will read a float from the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static float GetCampaignFloat(string campaignName, string varName, NWPlayer? player = null)
            => Core.NWScript.GetCampaignFloat(campaignName, varName, player ?? NWObject.OBJECT_INVALID);

        //     This will read an int from the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static int GetCampaignInt(string campaignName, string varName, NWPlayer? player = null)
            => Core.NWScript.GetCampaignInt(campaignName, varName, player ?? NWObject.OBJECT_INVALID);

        //     This will read a location from the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static Location GetCampaignLocation(string campaignName, string varName, NWPlayer? player = null)
            => Core.NWScript.GetCampaignLocation(campaignName, varName, player ?? NWObject.OBJECT_INVALID);

        //     This will read a string from the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static string GetCampaignString(string campaignName, string varName, NWPlayer? player = null)
            => Core.NWScript.GetCampaignString(campaignName, varName, player ?? NWObject.OBJECT_INVALID);

        //     This will read a vector from the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static Vector3 GetCampaignVector(string campaignName, string varName, NWPlayer? player = null)
            => Core.NWScript.GetCampaignVector(campaignName, varName, player ?? NWObject.OBJECT_INVALID);

        //     Get the level at which this creature cast it's last spell (or spell-like ability)
        //     * Return value on error, or if oCreature has not yet cast a spell: 0;
        public static int GetCasterLevel(NWCreature creature)
            => Core.NWScript.GetCasterLevel(creature);

        //     Get oCreature's challenge rating. * Returns 0.0 if oCreature is invalid.
        public static float GetChallengeRating(NWCreature creature)
            => Core.NWScript.GetChallengeRating(creature);

        //     A creature can have up to three classes. This function determines the creature's
        //     class (CLASS_TYPE_*) based on nClassPosition. - nClassPosition: 1, 2 or 3 - oCreature
        //     * Returns CLASS_TYPE_INVALID if the oCreature does not have a class in nClassPosition
        //     (i.e. a single-class creature will only have a value in nClassLocation=1) or
        //     if oCreature is not a valid creature.
        public enum ClassPosition { First = 1, Second = 2, Third = 3 };
        public static int GetClassByPosition(ClassPosition classPosition, NWCreature? creature = null)
            => Core.NWScript.GetClassByPosition((int)classPosition, creature ?? NWObject.OBJECT_SELF);

        //     Use this in a trigger's OnClick event script to get the object that last clicked
        //     on it. This is identical to GetEnteringObject. GetClickingObject() should not
        //     be called from a placeable's OnClick event, instead use GetPlaceableLastClickedBy();
        public static NWPlayer GetClickingObject()
            => new NWPlayer(Core.NWScript.GetClickingObject());

        //     Get the Color of oObject from the color channel specified. - oObject: the object
        //     from which you are obtaining the color. Can be a creature that has color information
        //     (i.e. the playable races). - nColorChannel: The color channel that you want to
        //     get the color value of. COLOR_CHANNEL_SKIN COLOR_CHANNEL_HAIR COLOR_CHANNEL_TATTOO_1
        //     COLOR_CHANNEL_TATTOO_2 * Returns -1 on error.
        public static int GetColor(NWObject obj, ColorChannel colorChannel)
            => Core.NWScript.GetColor(obj, (int)colorChannel);

        //     Determine whether oTarget's action stack can be modified.
        public static bool GetCommandable(NWObject? target = null)
            => Core.NWScript.GetCommandable(target ?? NWObject.OBJECT_SELF) == 1;

        //     returns the model number being used for the body part and creature specified
        //     The model number returned is for the body part when the creature is not wearing
        //     armor (i.e. whether or not the creature is wearing armor does not affect the
        //     return value). Note: Only works on part based creatures, which is typically restricted
        //     to the playable races (unless some new part based custom content has been added
        //     to the module). returns CREATURE_PART_INVALID if used on a non-creature object,
        //     or if the creature does not use a part based model. - nPart (CREATURE_PART_*)
        //     CREATURE_PART_RIGHT_FOOT CREATURE_PART_LEFT_FOOT CREATURE_PART_RIGHT_SHIN CREATURE_PART_LEFT_SHIN
        //     CREATURE_PART_RIGHT_THIGH CREATURE_PART_LEFT_THIGH CREATURE_PART_PELVIS CREATURE_PART_TORSO
        //     CREATURE_PART_BELT CREATURE_PART_NECK CREATURE_PART_RIGHT_FOREARM CREATURE_PART_LEFT_FOREARM
        //     CREATURE_PART_RIGHT_BICEP CREATURE_PART_LEFT_BICEP CREATURE_PART_RIGHT_SHOULDER
        //     CREATURE_PART_LEFT_SHOULDER CREATURE_PART_RIGHT_HAND CREATURE_PART_LEFT_HAND
        //     CREATURE_PART_HEAD
        public static int GetCreatureBodyPart(CreaturePart part, NWCreature? creature = null)
            => Core.NWScript.GetCreatureBodyPart((int)part, creature ?? NWObject.OBJECT_SELF);

        //     Returns TRUE if the creature is set to auto-explore the map as it walks around
        //     (on by default). Returns FALSE if creature is not actually a creature.
        public static bool GetCreatureExploresMinimap(NWCreature creature)
            => Core.NWScript.GetCreatureExploresMinimap(creature) == 1;

        //     Determine whether oCreature has tTalent.
        public static bool GetCreatureHasTalent(Talent talent, NWCreature? creature = null)
            => Core.NWScript.GetCreatureHasTalent(talent, creature ?? NWObject.OBJECT_SELF) == 1;

        //     Get the size (CREATURE_SIZE_*) of oCreature.
        public static CreatureSize GetCreatureSize(NWCreature creature)
            => (CreatureSize)Core.NWScript.GetCreatureSize(creature);

        //     Returns the default package selected for this creature to level up with - returns
        //     PACKAGE_INVALID if error occurs
        public static Package GetCreatureStartingPackage(NWCreature creature)
            => (Package)Core.NWScript.GetCreatureStartingPackage(creature);

        //     returns the Tail type of the creature specified. CREATURE_TAIL_TYPE_NONE CREATURE_TAIL_TYPE_LIZARD
        //     CREATURE_TAIL_TYPE_BONE CREATURE_TAIL_TYPE_DEVIL returns CREATURE_TAIL_TYPE_NONE
        //     if used on a non-creature object, if the creature has no Tail, or if the creature
        //     can not have its Tail type changed in the toolset.
        public static CreatureTailType GetCreatureTailType(NWCreature? creature = null)
            => (CreatureTailType)Core.NWScript.GetCreatureTailType(creature ?? NWObject.OBJECT_SELF);

        //     Get the best talent (i.e. closest to nCRMax without going over) of oCreature,
        //     within nCategory. - nCategory: TALENT_CATEGORY_* - nCRMax: Challenge Rating of
        //     the talent - oCreature
        public static Talent GetCreatureTalentBest(TalentCategory category, int crMax, NWCreature? creature = null)
            => Core.NWScript.GetCreatureTalentBest((int)category, crMax, creature ?? NWObject.OBJECT_SELF);

        //     Get a random talent of oCreature, within nCategory. - nCategory: TALENT_CATEGORY_*
        //     - oCreature
        public static Talent GetCreatureTalentRandom(TalentCategory category, NWCreature? creature = null)
            => Core.NWScript.GetCreatureTalentRandom((int)category, creature ?? NWObject.OBJECT_SELF);

        //     returns the Wing type of the creature specified. CREATURE_WING_TYPE_NONE CREATURE_WING_TYPE_DEMON
        //     CREATURE_WING_TYPE_ANGEL CREATURE_WING_TYPE_BAT CREATURE_WING_TYPE_DRAGON CREATURE_WING_TYPE_BUTTERFLY
        //     CREATURE_WING_TYPE_BIRD returns CREATURE_WING_TYPE_NONE if used on a non-creature
        //     object, if the creature has no wings, or if the creature can not have its wing
        //     type changed in the toolset.
        public static CreatureWingType GetCreatureWingType(NWCreature? creature = null)
            => (CreatureWingType)Core.NWScript.GetCreatureWingType(creature ?? NWObject.OBJECT_SELF);

        //     Get the current action (ACTION_*) that oObject is executing.
        public static Action GetCurrentAction(NWObject? obj = null)
            => (Action)Core.NWScript.GetCurrentAction(obj ?? NWObject.OBJECT_SELF);

        //     Get the current hitpoints of oObject * Return value on error: 0
        public static int GetCurrentHitPoints(NWObject? obj = null)
            => Core.NWScript.GetCurrentHitPoints(obj ?? NWObject.OBJECT_SELF);

        //     Returns the current movement rate factor of the cutscene 'camera man'. NOTE:
        //     This will be a value between 0.1, 2.0 (10%-200%)
        public static float GetCutsceneCameraMoveRate(NWCreature creature)
            => Core.NWScript.GetCutsceneCameraMoveRate(creature);
        //
        // Summary:
        //     Gets the current cutscene state of the player specified by oCreature. Returns
        //     TRUE if the player is in cutscene mode. Returns FALSE if the player is not in
        //     cutscene mode, or on an error (such as specifying a non creature object).
        public static bool GetCutsceneMode(NWCreature? creature = null)
            => Core.NWScript.GetCutsceneMode(creature ?? NWObject.OBJECT_SELF) == 1;
        //
        // Summary:
        //     Gets the damage bonus limit. - The default value is 100.
        public static int GetDamageBonusLimit()
            => Core.NWScript.GetDamageBonusLimit();

        //     Get the amount of damage of type nDamageType that has been dealt to the caller.
        //     - nDamageType: DAMAGE_TYPE_*
        public static int GetDamageDealtByType(DamageType damageType)
            => Core.NWScript.GetDamageDealtByType((int)damageType);

        //     Returns the defensive casting mode of the specified creature. - oCreature * Returns
        //     a constant DEFENSIVE_CASTING_MODE_*
        public static DefensiveCastingMode GetDefensiveCastingMode(NWCreature creature)
            => (DefensiveCastingMode)Core.NWScript.GetDefensiveCastingMode(creature);

        //     Get the name of oCreature's deity. * Returns "" if oCreature is invalid (or if
        //     the deity name is blank for oCreature).
        public static string GetDeity(NWCreature creature)
            => Core.NWScript.GetDeity(creature);

        //     Get the description of oObject. - oObject: the object from which you are obtaining
        //     the description. Can be a creature, item, placeable, door, trigger or module
        //     object. - bOriginalDescription: if set to true any new description specified
        //     via a SetDescription scripting command is ignored and the original object's description
        //     is returned instead. - bIdentified: If oObject is an item, setting this to TRUE
        //     will return the identified description, setting this to FALSE will return the
        //     unidentified description. This flag has no effect on objects other than items.
        public static string GetDescription(NWObject obj, bool originalDescription = false, bool identifiedDescription = true)
            => Core.NWScript.GetDescription(obj, originalDescription ? 1 : 0, identifiedDescription ? 1 : 0);

        //     Returns the detection mode of the specified creature. - oCreature * Returns a
        //     constant DETECT_MODE_*
        public static DetectMode GetDetectMode(NWCreature creature)
            => (DetectMode)Core.NWScript.GetDetectMode(creature);

        //     Gets the length of the specified wavefile, in seconds Only works for sounds used
        //     for dialog.
        public static float GetDialogSoundLength(int strRef)
            => Core.NWScript.GetDialogSoundLength(strRef);

        //     Get the distance in metres between oObjectA and oObjectB. * Return value if either
        //     object is invalid: 0.0f
        public static float GetDistanceBetween(NWObject objA, NWObject objB)
            => Core.NWScript.GetDistanceBetween(objA, objB);

        //     Get the distance between lLocationA and lLocationB.
        public static float GetDistanceBetweenLocations(Location locA, Location locB)
            => Core.NWScript.GetDistanceBetweenLocations(locA, locB);

        //     Get the distance from the caller to oObject in metres. * Return value on error:
        //     -1.0f
        public static float GetDistanceToObject(NWObject obj)
            => Core.NWScript.GetDistanceToObject(obj);

        //     Returns oCreature's domain in nClass (DOMAIN_* constants) nDomainIndex - 1 or
        //     2 Unless custom content is used, only Clerics have domains Returns -1 on error
        public enum DomainIndex { First = 1, Second = 2 }
        public static Domain GetDomain(NWCreature creature, DomainIndex domainIndex = DomainIndex.First, ClassType classType = ClassType.Cleric)
            => (Domain)Core.NWScript.GetDomain(creature, (int)domainIndex, (int)classType);

        //     returns TRUE if the item CAN be dropped Droppable items will appear on a creature's
        //     remains when the creature is killed.
        public static bool GetDroppableFlag(NWItem item)
            => Core.NWScript.GetDroppableFlag(item) == 1;

        //     Returns the caster level of the creature who created the effect. - If not created
        //     by a creature, returns 0. - If created by a spell-like ability, returns 0.
        public static int GetEffectCasterLevel(Effect effect)
            => Core.NWScript.GetEffectCasterLevel(effect);

        //     Get the object that created eEffect. * Returns OBJECT_INVALID if eEffect is not
        //     a valid effect.
        public static NWObject GetEffectCreator(Effect effect)
            => new NWObject(Core.NWScript.GetEffectCreator(effect));

        //     Returns the total duration of the effect in seconds. - Returns 0 if the duration
        //     type of the effect is not DURATION_TYPE_TEMPORARY.
        public static int GetEffectDuration(Effect effect)
            => Core.NWScript.GetEffectDuration(effect);

        //     Returns the remaining duration of the effect in seconds. - Returns 0 if the duration
        //     type of the effect is not DURATION_TYPE_TEMPORARY.
        public static int GetEffectDurationRemaining(Effect effect)
            => Core.NWScript.GetEffectDurationRemaining(effect);

        //     Get the duration type (DURATION_TYPE_*) of eEffect. * Return value if eEffect
        //     is not valid: -1
        public static DurationType GetEffectDurationType(Effect effect)
            => (DurationType)Core.NWScript.GetEffectDurationType(effect);

        //     Get the spell (SPELL_*) that applied eSpellEffect. * Returns -1 if eSpellEffect
        //     was applied outside a spell script.
        public static Spell GetEffectSpellId(Effect spellEffect)
            => (Spell)Core.NWScript.GetEffectSpellId(spellEffect);

        //     Get the subtype (SUBTYPE_*) of eEffect. * Return value on error: 0
        public static DurationSubType GetEffectSubType(Effect effect)
            => (DurationSubType)Core.NWScript.GetEffectSubType(effect);

        //     Returns the string tag set for the provided effect. - If no tag has been set,
        //     returns an empty string.
        public static string GetEffectTag(Effect effect)
            => Core.NWScript.GetEffectTag(effect);

        //     Get the effect type (EFFECT_TYPE_*) of eEffect. * Return value if eEffect is
        //     invalid: EFFECT_INVALIDEFFECT
        public static EffectType GetEffectType(Effect effect)
            => (EffectType)Core.NWScript.GetEffectType(effect);

        //     Determine whether oEncounter is active.
        public static bool GetEncounterActive(NWObject? encounter = null)
            => Core.NWScript.GetEncounterActive(encounter ?? NWObject.OBJECT_SELF) == 1;

        //     Get the difficulty level of oEncounter.
        public static EncounterDifficulty GetEncounterDifficulty(NWObject? encounter = null)
            => (EncounterDifficulty)Core.NWScript.GetEncounterDifficulty(encounter ?? NWObject.OBJECT_SELF);

        //     Get the number of times that oEncounter has spawned so far
        public static int GetEncounterSpawnsCurrent(NWObject? encounter = null)
            => Core.NWScript.GetEncounterSpawnsCurrent(encounter ?? NWObject.OBJECT_SELF);

        //     Get the maximum number of times that oEncounter will spawn.
        public static int GetEncounterSpawnsMax(NWObject? encounter = null)
            => Core.NWScript.GetEncounterSpawnsMax(encounter ?? NWObject.OBJECT_SELF);
        //
        // Summary:
        //     The value returned by this function depends on the object type of the caller:
        //     1) If the caller is a door it returns the object that last triggered it. 2) If
        //     the caller is a trigger, area of effect, module, area or encounter it returns
        //     the object that last entered it. * Return value on error: OBJECT_INVALID When
        //     used for doors, this should only be called from the OnAreaTransitionClick event.
        //     Otherwise, it should only be called in OnEnter scripts.
        public static NWObject GetEnteringObject()
            => new NWObject(Core.NWScript.GetEnteringObject());
        //
        // Summary:
        //     Returns the event script for the given object and handler. Will return "" if
        //     unset, the object is invalid, or the object cannot have the requested handler.
        public static string GetEventScript(NWObject obj, EventScript handler)
            => Core.NWScript.GetEventScript(obj, (int)handler);

        //     Get the object that last left the caller. This function works on triggers, areas
        //     of effect, modules, areas and encounters. * Return value on error: OBJECT_INVALID
        //     Should only be called in OnExit scripts.
        public static NWObject GetExitingObject()
            => new NWObject(Core.NWScript.GetExitingObject());

        //     Get the direction in which oTarget is facing, expressed as a float between 0.0f
        //     and 360.0f * Return value on error: -1.0f
        public static float GetFacing(NWObject target)
            => Core.NWScript.GetFacing(target);

        //     Get the orientation value from lLocation.
        public static float GetFacingFromLocation(Location location)
            => Core.NWScript.GetFacingFromLocation(location);

        //     Get an integer between 0 and 100 (inclusive) that represents the average good/evil
        //     alignment of oFactionMember's faction. * Return value on error: -1
        public static int GetFactionAverageGoodEvilAlignment(NWObject factionMember)
            => Core.NWScript.GetFactionAverageGoodEvilAlignment(factionMember);

        //     Get an integer between 0 and 100 (inclusive) that represents the average law/chaos
        //     alignment of oFactionMember's faction. * Return value on error: -1
        public static int GetFactionAverageLawChaosAlignment(NWObject factionMember)
            => Core.NWScript.GetFactionAverageLawChaosAlignment(factionMember);

        //     Get the average level of the members of the faction. * Return value on error:
        //     -1
        public static int GetFactionAverageLevel(NWObject factionMember)
            => Core.NWScript.GetFactionAverageLevel(factionMember);

        //     Get an integer between 0 and 100 (inclusive) that represents how oSourceFactionMember's
        //     faction feels about oTarget. * Return value on error: -1
        public static int GetFactionAverageReputation(NWObject sourceFactionMember, NWObject target)
            => Core.NWScript.GetFactionAverageReputation(sourceFactionMember, target);

        //     Get the average XP of the members of the faction. * Return value on error: -1
        public static int GetFactionAverageXP(NWObject factionMember)
            => Core.NWScript.GetFactionAverageXP(factionMember);

        //     Get the object faction member with the highest armour class. * Returns OBJECT_INVALID
        //     if oFactionMember's faction is invalid.
        public static NWObject GetFactionBestAC(NWObject? factionMember = null, bool mustBeVisible = true)
            => new NWObject(Core.NWScript.GetFactionBestAC(factionMember ?? NWObject.OBJECT_SELF, mustBeVisible ? 1 : 0));

        //     * Returns TRUE if the Faction Ids of the two objects are the same
        public static int GetFactionEqual(NWObject firstObject, NWObject? secondObject = null)
            => Core.NWScript.GetFactionEqual(firstObject, secondObject ?? NWObject.OBJECT_SELF);

        //     Get the amount of gold held by oFactionMember's faction. * Returns -1 if oFactionMember's
        //     faction is invalid.
        public static int GetFactionGold(NWObject factionMember)
            => Core.NWScript.GetFactionGold(factionMember);

        //     Get the player leader of the faction of which oMemberOfFaction is a member. *
        //     Returns OBJECT_INVALID if oMemberOfFaction is not a valid creature, or oMemberOfFaction
        //     is a member of a NPC faction.
        public static NWObject GetFactionLeader(NWObject memberOfFaction)
            => new NWObject(Core.NWScript.GetFactionLeader(memberOfFaction));

        //     Get the member of oFactionMember's faction that has taken the fewest hit points
        //     of damage. * Returns OBJECT_INVALID if oFactionMember's faction is invalid.
        public static NWObject GetFactionLeastDamagedMember(NWObject? factionMember = null, bool mustBeVisible = true)
            => new NWObject(Core.NWScript.GetFactionLeastDamagedMember(factionMember ?? NWObject.OBJECT_SELF, mustBeVisible ? 1 : 0));

        //     Get the member of oFactionMember's faction that has taken the most hit points
        //     of damage. * Returns OBJECT_INVALID if oFactionMember's faction is invalid.
        public static NWObject GetFactionMostDamagedMember(NWObject? factionMember = null, bool mustBeVisible = true)
            => new NWObject(Core.NWScript.GetFactionMostDamagedMember(factionMember ?? NWObject.OBJECT_SELF, mustBeVisible ? 1 : 0));

        //     Get the most frequent class in the faction - this can be compared with the constants
        //     CLASS_TYPE_*. * Return value on error: -1
        public static ClassType GetFactionMostFrequentClass(NWObject factionMember)
            => (ClassType)Core.NWScript.GetFactionMostFrequentClass(factionMember);

        //     Get the strongest member of oFactionMember's faction. * Returns OBJECT_INVALID
        //     if oFactionMember's faction is invalid.
        public static NWObject GetFactionStrongestMember(NWObject? factionMember = null, bool mustBeVisible = true)
            => new NWObject(Core.NWScript.GetFactionStrongestMember(factionMember ?? NWObject.OBJECT_SELF, mustBeVisible ? 1 : 0));

        //     Get the weakest member of oFactionMember's faction. * Returns OBJECT_INVALID
        //     if oFactionMember's faction is invalid.
        public static NWObject GetFactionWeakestMember(NWObject? factionMember = null, bool mustBeVisible = true)
            => new NWObject(Core.NWScript.GetFactionWeakestMember(factionMember ?? NWObject.OBJECT_SELF, mustBeVisible ? 1 : 0));

        //     Get the object faction member with the lowest armour class. * Returns OBJECT_INVALID
        //     if oFactionMember's faction is invalid.
        public static NWObject GetFactionWorstAC(NWObject? factionMember = null, bool mustBeVisible = true)
            => new NWObject(Core.NWScript.GetFactionWorstAC(factionMember ?? NWObject.OBJECT_SELF, mustBeVisible ? 1 : 0));

        //     Get oCreature's familiar creature type (FAMILIAR_CREATURE_TYPE_*). * Returns
        //     FAMILIAR_CREATURE_TYPE_NONE if oCreature is invalid or does not currently have
        //     a familiar.
        public static FamiliarCreatureType GetFamiliarCreatureType(NWCreature creature)
            => (FamiliarCreatureType)Core.NWScript.GetFamiliarCreatureType(creature);

        //     Get oCreature's familiar's name. * Returns "" if oCreature is invalid, does not
        //     currently have a familiar or if the familiar's name is blank.
        public static string GetFamiliarName(NWCreature creature)
            => Core.NWScript.GetFamiliarName(creature);

        //     Returns the first area in the module.
        public static NWArea GetFirstArea()
            => new NWArea(Core.NWScript.GetFirstArea());

        //     Get the first in-game effect on oCreature.
        public static Effect GetFirstEffect(NWCreature creature)
            => Core.NWScript.GetFirstEffect(creature);

        //     Get the first member of oMemberOfFaction's faction (start to cycle through oMemberOfFaction's
        //     faction). * Returns OBJECT_INVALID if oMemberOfFaction's faction is invalid.
        public static NWObject GetFirstFactionMember(NWObject? factionMember, bool pcOnly = true)
            => new NWObject(Core.NWScript.GetFirstFactionMember(factionMember ?? NWObject.OBJECT_SELF, pcOnly ? 1 : 0));

        //     Get the first object within oPersistentObject. - oPersistentObject - nResidentObjectType:
        //     OBJECT_TYPE_* - nPersistentZone: PERSISTENT_ZONE_ACTIVE. [This could also take
        //     the value PERSISTENT_ZONE_FOLLOW, but this is no longer used.] * Returns OBJECT_INVALID
        //     if no object is found.
        public static NWObject GetFirstInPersistentObject(NWObject? persistentObject = null, ObjectType residentObjectType = ObjectType.Creature, PersistentZone persistentZone = PersistentZone.Active)
            => new NWObject(Core.NWScript.GetFirstInPersistentObject(persistentObject ?? NWObject.OBJECT_SELF, (int)residentObjectType, (int)persistentZone));

        //     Get the first item in oTarget's inventory (start to cycle through oTarget's inventory).
        //     * Returns OBJECT_INVALID if the caller is not a creature, item, placeable or
        //     store, or if no item is found.
        public static NWItem GetFirstItemInInventory(NWObject? target = null)
            => new NWItem(Core.NWScript.GetFirstItemInInventory(target ?? NWObject.OBJECT_SELF));

        //     Gets the first item property on an item
        public static ItemProperty GetFirstItemProperty(NWItem item)
            => Core.NWScript.GetFirstItemProperty(item);

        //     Get the first object in oArea. If no valid area is specified, it will use the
        //     caller's area. * Return value on error: OBJECT_INVALID
        public static NWObject GetFirstObjectInArea(NWArea? area = null)
            => new NWObject(Core.NWScript.GetFirstObjectInArea(area ?? NWObject.OBJECT_INVALID));

        //     Get the first object in nShape - nShape: SHAPE_* - fSize: -> If nShape == SHAPE_SPHERE,
        //     this is the radius of the sphere -> If nShape == SHAPE_SPELLCYLINDER, this is
        //     the length of the cylinder Spell Cylinder's always have a radius of 1.5m. ->
        //     If nShape == SHAPE_CONE, this is the widest radius of the cone -> If nShape ==
        //     SHAPE_SPELLCONE, this is the length of the cone in the direction of lTarget.
        //     Spell cones are always 60 degrees with the origin at OBJECT_SELF. -> If nShape
        //     == SHAPE_CUBE, this is half the length of one of the sides of the cube - lTarget:
        //     This is the centre of the effect, usually GetSpellTargetLocation(), or the end
        //     of a cylinder or cone. - bLineOfSight: This controls whether to do a line-of-sight
        //     check on the object returned. Line of sight check is done from origin to target
        //     object at a height 1m above the ground (This can be used to ensure that spell
        //     effects do not go through walls.) - nObjectFilter: This allows you to filter
        //     out undesired object types, using bitwise "or". For example, to return only creatures
        //     and doors, the value for this parameter would be OBJECT_TYPE_CREATURE | OBJECT_TYPE_DOOR
        //     - vOrigin: This is only used for cylinders and cones, and specifies the origin
        //     of the effect(normally the spell-caster's position). Return value on error: OBJECT_INVALID
        public static NWObject GetFirstObjectInShape(Shape shape, float fSize, Location targetLocation, bool lineOfSight = false, ObjectType objectFilter = ObjectType.Creature, Vector3 vOrigin = default)
            => new NWObject(Core.NWScript.GetFirstObjectInShape((int)shape, fSize, targetLocation, lineOfSight ? 1 : 0, (int)objectFilter, vOrigin));
        //
        // Summary:
        //     Get the first PC in the player list. This resets the position in the player list
        //     for GetNextPC().
        public static NWObject GetFirstPC()
            => new NWObject(Core.NWScript.GetFirstPC());

        //     Gets the fog amount in the area specified. nFogType = nFogType specifies whether
        //     the Sun, or Moon fog type is returned. Valid values for nFogType are FOG_TYPE_SUN
        //     or FOG_TYPE_MOON. If no valid area (or object) is specified, it uses the area
        //     of caller. If an object other than an area is specified, will use the area that
        //     the object is currently in.
        public static int GetFogAmount(FogType fogType, NWArea? area = null)
            => Core.NWScript.GetFogAmount((int)fogType, area ?? NWObject.OBJECT_INVALID);

        //     Gets the fog color in the area specified. nFogType specifies whether the Sun,
        //     or Moon fog type is returned. Valid values for nFogType are FOG_TYPE_SUN or FOG_TYPE_MOON.
        //     If no valid area (or object) is specified, it uses the area of caller. If an
        //     object other than an area is specified, will use the area that the object is
        //     currently in.
        public static FogColor GetFogColor(FogType fogType, NWArea? area = null)
            => (FogColor)Core.NWScript.GetFogColor((int)fogType, area ?? NWObject.OBJECT_INVALID);
        //
        // Summary:
        //     returns the footstep type of the creature specified. The footstep type determines
        //     what the creature's footsteps sound like when ever they take a step. returns
        //     FOOTSTEP_TYPE_INVALID if used on a non-creature object, or if used on creature
        //     that has no footstep sounds by default (e.g. Will-O'-Wisp).
        public static FootstepType GetFootstepType(NWCreature? creature = null)
            => (FootstepType)Core.NWScript.GetFootstepType(creature ?? NWObject.OBJECT_SELF);
        //
        // Summary:
        //     Get oTarget's base fortitude saving throw value (this will only work for creatures,
        //     doors, and placeables). * Returns 0 if oTarget is invalid.
        public static int GetFortitudeSavingThrow(NWObject target)
            => Core.NWScript.GetFortitudeSavingThrow(target);

        //     Get the game difficulty (GAME_DIFFICULTY_*).
        public static GameDifficulty GetGameDifficulty()
            => (GameDifficulty)Core.NWScript.GetGameDifficulty();

        //     Get the gender of oCreature.
        public static Gender GetGender(NWCreature creature)
            => (Gender)Core.NWScript.GetGender(creature);

        //     Get the creature that is going to attack oTarget. Note: This value is cleared
        //     out at the end of every combat round and should not be used in any case except
        //     when getting a "going to be attacked" shout from the master creature (and this
        //     creature is a henchman) * Returns OBJECT_INVALID if oTarget is not a valid creature.
        public static NWCreature GetGoingToBeAttackedBy(NWObject target)
            => new NWCreature(Core.NWScript.GetGoingToBeAttackedBy(target));

        //     Get the amount of gold possessed by oTarget.
        public static int GetGold(NWObject? target = null)
            => Core.NWScript.GetGold(target ?? NWObject.OBJECT_SELF);
        //
        // Summary:
        //     Get the gold piece value of oItem. * Returns 0 if oItem is not a valid item.
        public static int GetGoldPieceValue(NWItem item)
            => Core.NWScript.GetGoldPieceValue(item);

        //     Get an integer between 0 and 100 (inclusive) to represent oCreature's Good/Evil
        //     alignment (100=good, 0=evil) * Return value if oCreature is not a valid creature:
        //     -1
        public static int GetGoodEvilValue(NWCreature creature)
            => Core.NWScript.GetGoodEvilValue(creature);

        //     Returns the z-offset at which the walkmesh is at the given location. Returns
        //     -6.0 for invalid locations.
        public static float GetGroundHeight(Location loc)
            => Core.NWScript.GetGroundHeight(loc);

        //     returns the Hardness of a Door or Placeable object. - oObject: a door or placeable
        //     object. returns -1 on an error or if used on an object that is neither a door
        //     nor a placeable object.
        public static int GetHardness(NWObject? obj = null)
            => Core.NWScript.GetHardness(obj ?? NWObject.OBJECT_SELF);

        //     Determine whether oCreature has nFeat, and nFeat is useable. - nFeat: FEAT_*
        //     - oCreature
        public static bool GetHasFeat(Feat feat, NWCreature? creature = null)
            => Core.NWScript.GetHasFeat((int)feat, creature ?? NWObject.OBJECT_INVALID) == 1;

        //     - nFeat: FEAT_* - oObject * Returns TRUE if oObject has effects on it originating
        //     from nFeat.
        public static bool GetHasFeatEffect(Feat feat, NWObject? obj = null)
            => Core.NWScript.GetHasFeatEffect((int)feat, obj ?? NWObject.OBJECT_SELF) == 1;

        //     Determine whether oObject has an inventory. * Returns TRUE for creatures and
        //     stores, and checks to see if an item or placeable object is a container. * Returns
        //     FALSE for all other object types.
        public static bool GetHasInventory(NWObject obj)
            => Core.NWScript.GetHasInventory(obj) == 1;

        //     Determine whether oCreature has nSkill, and nSkill is useable. - nSkill: SKILL_*
        //     - oCreature
        public static bool GetHasSkill(Skill skill, NWCreature? creature = null)
            => Core.NWScript.GetHasSkill((int)skill, creature ?? NWObject.OBJECT_SELF) == 1;

        //     Determines the number of times that oCreature has nSpell memorised. - nSpell:
        //     SPELL_* - oCreature
        public static bool GetHasSpell(Spell spell, NWCreature? creature = null)
            => Core.NWScript.GetHasSpell((int)spell, creature ?? NWObject.OBJECT_SELF) == 1;

        //     Determines whether oObject has any effects applied by nSpell - nSpell: SPELL_*
        //     - oObject * The spell id on effects is only valid if the effect is created when
        //     the spell script runs. If it is created in a delayed command then the spell id
        //     on the effect will be invalid.
        public static bool GetHasSpellEffect(Spell spell, NWObject? obj = null)
            => Core.NWScript.GetHasSpellEffect((int)spell, obj ?? NWObject.OBJECT_SELF) == 1;

        //     Get the henchman belonging to oMaster. * Return OBJECT_INVALID if oMaster does
        //     not have a henchman. -nNth: Which henchman to return.
        public static NWCreature GetHenchman(NWCreature? master = null, int nth = 1)
            => new NWCreature(Core.NWScript.GetHenchman(master ?? NWObject.OBJECT_SELF, nth));

        //     Returns whether the provided item is hidden when equipped.
        public static bool GetHiddenWhenEquipped(NWItem item)
            => Core.NWScript.GetHiddenWhenEquipped(item) == 1;

        //     Get the number of hitdice for oCreature. * Return value if oCreature is not a
        //     valid creature: 0
        public static int GetHitDice(NWCreature creature)
            => Core.NWScript.GetHitDice(creature);

        //     Determined whether oItem has been identified.
        public static bool GetIdentified(NWItem item)
            => Core.NWScript.GetIdentified(item) == 1;

        //     Get the ID of tTalent. This could be a SPELL_*, FEAT_* or SKILL_*.
        public static int GetIdFromTalent(Talent talent)
            => Core.NWScript.GetIdFromTalent(talent);

        //     Get the immortal flag on a creature
        public static bool GetImmortal(NWCreature? target = null)
            => Core.NWScript.GetImmortal(target ?? NWObject.OBJECT_SELF) == 1;

        //     returns TRUE if the item is flagged as infinite. - oItem: an item. The infinite
        //     property affects the buying/selling behavior of the item in a store. An infinite
        //     item will still be available to purchase from a store after a player buys the
        //     item (non-infinite items will disappear from the store when purchased).
        public static bool GetInfiniteFlag(NWItem item)
            => Core.NWScript.GetInfiniteFlag(item) == 1;

        //     get the item that caused the caller's OnInventoryDisturbed script to fire. *
        //     Returns OBJECT_INVALID if the caller is not a valid object.
        public static NWItem GetInventoryDisturbItem()
            => new NWItem(Core.NWScript.GetInventoryDisturbItem());

        //     Get the type of disturbance (INVENTORY_DISTURB_*) that caused the caller's OnInventoryDisturbed
        //     script to fire. This will only work for creatures and placeables.
        public static InventoryDisturbType GetInventoryDisturbType()
            => (InventoryDisturbType)Core.NWScript.GetInventoryDisturbType();

        //     Returns AREA_ABOVEGROUND if the area oArea is above ground, AREA_UNDERGROUND
        //     otherwise. Returns AREA_INVALID, on an error.
        public static AreaTypeAboveground GetIsAreaAboveGround(NWArea area)
            => (AreaTypeAboveground)Core.NWScript.GetIsAreaAboveGround(area);

        //     This will return TRUE if the area is flagged as either interior or underground.
        public static bool GetIsAreaInterior(NWArea? area = null)
            => Core.NWScript.GetIsAreaInterior(area ?? NWObject.OBJECT_SELF) == 1;

        //     Returns AREA_NATURAL if the area oArea is natural, AREA_ARTIFICIAL otherwise.
        //     Returns AREA_INVALID, on an error.
        public static AreaTypeNatural GetIsAreaNatural(NWArea area)
            => (AreaTypeNatural)Core.NWScript.GetIsAreaNatural(area);

        //     Is this creature able to be disarmed? (checks disarm flag on creature, and if
        //     the creature actually has a weapon equipped in their right hand that is droppable)
        public static bool GetIsCreatureDisarmable(NWCreature creature)
            => Core.NWScript.GetIsCreatureDisarmable(creature) == 1;

        //     * Returns TRUE if it is currently dawn.
        public static bool GetIsDawn()
            => Core.NWScript.GetIsDawn() == 1;
        //
        // Summary:
        //     * Returns TRUE if it is currently day.
        public static bool GetIsDay()
            => Core.NWScript.GetIsDay() == 1;

        //     * Returns TRUE if oCreature is a dead NPC, dead PC or a dying PC.
        public static bool GetIsDead(NWCreature creature)
            => Core.NWScript.GetIsDead(creature) == 1;
        //
        // Summary:
        //     * Returns TRUE if oCreature is the Dungeon Master. Note: This will return FALSE
        //     if oCreature is a DM Possessed creature. To determine if oCreature is a DM Possessed
        //     creature, use GetIsDMPossessed()
        public static bool GetIsDM(NWPlayer player)
            => Core.NWScript.GetIsDM(player) == 1;

        //     Returns TRUE if the creature oCreature is currently possessed by a DM character.
        //     Returns FALSE otherwise. Note: GetIsDMPossessed() will return FALSE if oCreature
        //     is the DM character. To determine if oCreature is a DM character use GetIsDM()
        public static bool GetIsDMPossessed(NWCreature creature)
            => Core.NWScript.GetIsDMPossessed(creature) == 1;

        //     - oTargetDoor - nDoorAction: DOOR_ACTION_* * Returns TRUE if nDoorAction can
        //     be performed on oTargetDoor.
        public static bool GetIsDoorActionPossible(NWObject door, DoorAction action)
            => Core.NWScript.GetIsDoorActionPossible(door, (int)action) == 1;

        //     * Returns TRUE if it is currently dusk.
        public static bool GetIsDusk()
            => Core.NWScript.GetIsDusk() == 1;

        //     * Returns TRUE if eEffect is a valid effect. The effect must have been applied
        //     to * an object or else it will return FALSE
        public static bool GetIsEffectValid(Effect effect)
            => Core.NWScript.GetIsEffectValid(effect) == 1;

        //     * Returns TRUE if oCreature was spawned from an encounter.
        public static bool GetIsEncounterCreature(NWCreature? creature = null)
            => Core.NWScript.GetIsEncounterCreature(creature ?? NWObject.OBJECT_SELF) == 1;

        //     * Returns TRUE if oSource considers oTarget as an enemy.
        public static bool GetIsEnemy(NWObject target, NWObject? source = null)
            => Core.NWScript.GetIsEnemy(target, source ?? NWObject.OBJECT_SELF) == 1;

        //     * Returns TRUE if oSource considers oTarget as a friend.
        public static bool GetIsFriend(NWObject target, NWObject? source = null)
            => Core.NWScript.GetIsFriend(target, source ?? NWObject.OBJECT_SELF) == 1;

        //     - oCreature - nImmunityType: IMMUNITY_TYPE_* - oVersus: if this is specified,
        //     then we also check for the race and alignment of oVersus * Returns TRUE if oCreature
        //     has immunity of type nImmunity versus oVersus.
        public static bool GetIsImmune(NWCreature creature, ImmunityType immunityType, NWCreature? versus = null)
            => Core.NWScript.GetIsImmune(creature, (int)immunityType, versus ?? NWObject.OBJECT_INVALID) == 1;

        //     * Returns TRUE if oCreature is in combat.
        public static bool GetIsInCombat(NWCreature? creature = null)
            => Core.NWScript.GetIsInCombat(creature ?? NWObject.OBJECT_SELF) == 1;

        //     Is this creature in the given subarea? (trigger, area of effect object, etc..)
        //     This function will tell you if the creature has triggered an onEnter event, not
        //     if it is physically within the space of the subarea
        public static bool GetIsInSubArea(NWCreature creature, NWObject? subArea = null)
            => Core.NWScript.GetIsInSubArea(creature, subArea ?? NWObject.OBJECT_SELF) == 1;

        //     if the item property is valid this will return true
        public static bool GetIsItemPropertyValid(ItemProperty itemProperty)
            => Core.NWScript.GetIsItemPropertyValid(itemProperty) == 1;

        //     * Returns TRUE if oObject is listening for something
        public static bool GetIsListening(NWObject obj)
            => Core.NWScript.GetIsListening(obj) == 1;

        //     * Returns TRUE if oSource considers oTarget as neutral.
        public static bool GetIsNeutral(NWObject target, NWObject? source = null)
            => Core.NWScript.GetIsNeutral(target, source ?? NWObject.OBJECT_SELF) == 1;

        //     * Returns TRUE if it is currently night.
        public static bool GetIsNight()
            => Core.NWScript.GetIsNight() == 1;

        //     * Returns TRUE if oObject is a valid object.
        public static bool GetIsObjectValid(NWObject obj)
            => Core.NWScript.GetIsObjectValid(obj) == 1;

        //     * Returns TRUE if oObject (which is a placeable or a door) is currently open.
        public static bool GetIsOpen(NWObject obj)
            => Core.NWScript.GetIsOpen(obj) == 1;

        //     * Returns TRUE if oCreature is a Player Controlled character.
        public static bool GetIsPC(NWCreature creature)
            => Core.NWScript.GetIsPC(creature) == 1;

        //     - oPlaceable - nPlaceableAction: PLACEABLE_ACTION_* * Returns TRUE if nPlacebleAction
        //     is valid for oPlaceable.
        public static bool GetIsPlaceableObjectActionPossible(NWPlaceable placeable, PlaceableAction placeableAction)
            => Core.NWScript.GetIsPlaceableObjectActionPossible(placeable, (int)placeableAction) == 1;

        //     * Returns TRUE if oCreature is of a playable racial type.
        public static bool GetIsPlayableRacialType(NWCreature creature)
            => Core.NWScript.GetIsPlayableRacialType(creature) == 1;

        //     Get if oPlayer is currently connected over a relay (instead of directly). Returns
        //     FALSE for any other object, including OBJECT_INVALID.
        public static bool GetIsPlayerConnectionRelayed(NWPlayer player)
            => Core.NWScript.GetIsPlayerConnectionRelayed(player) == 1;

        //     This will return TRUE if the creature running the script is a familiar currently
        //     possessed by his master. returns FALSE if not or if the creature object is invalid
        public static bool GetIsPossessedFamiliar(NWCreature creature)
            => Core.NWScript.GetIsPossessedFamiliar(creature) == 1;

        //     Determine whether oSource has a friendly reaction towards oTarget, depending
        //     on the reputation, PVP setting and (if both oSource and oTarget are PCs), oSource's
        //     Like/Dislike setting for oTarget. Note: If you just want to know how two objects
        //     feel about each other in terms of faction and personal reputation, use GetIsFriend()
        //     instead. * Returns TRUE if oSource has a friendly reaction towards oTarget
        public static bool GetIsReactionTypeFriendly(NWObject target, NWObject? source = null)
            => Core.NWScript.GetIsReactionTypeFriendly(target, source ?? NWObject.OBJECT_SELF) == 1;

        //     Determine whether oSource has a Hostile reaction towards oTarget, depending on
        //     the reputation, PVP setting and (if both oSource and oTarget are PCs), oSource's
        //     Like/Dislike setting for oTarget. Note: If you just want to know how two objects
        //     feel about each other in terms of faction and personal reputation, use GetIsEnemy()
        //     instead. * Returns TRUE if oSource has a hostile reaction towards oTarget
        public static bool GetIsReactionTypeHostile(NWObject target, NWObject? source = null)
            => Core.NWScript.GetIsReactionTypeHostile(target, source ?? NWObject.OBJECT_SELF) == 1;

        //     Determine whether oSource has a neutral reaction towards oTarget, depending on
        //     the reputation, PVP setting and (if both oSource and oTarget are PCs), oSource's
        //     Like/Dislike setting for oTarget. Note: If you just want to know how two objects
        //     feel about each other in terms of faction and personal reputation, use GetIsNeutral()
        //     instead. * Returns TRUE if oSource has a neutral reaction towards oTarget
        public static bool GetIsReactionTypeNeutral(NWObject target, NWObject? source = null)
            => Core.NWScript.GetIsReactionTypeNeutral(target, source ?? NWObject.OBJECT_SELF) == 1;

        //     * Returns TRUE if oCreature is resting.
        public static int GetIsResting(NWCreature? creature = null)
            => Core.NWScript.GetIsResting(creature ?? NWObject.OBJECT_SELF);

        //     *********************** END OF ITEM PROPERTY FUNCTIONS **************************
        //     Returns true if 1d20 roll + skill rank is greater than or equal to difficulty
        //     - oTarget: the creature using the skill - nSkill: the skill being used - nDifficulty:
        //     Difficulty class of skill
        public static bool GetIsSkillSuccessful(NWObject target, Skill skill, int difficulty)
            => Core.NWScript.GetIsSkillSuccessful(target, (int)skill, difficulty) == 1;

        //     * Returns TRUE if tTalent is valid.
        public static bool GetIsTalentValid(Talent talent)
            => Core.NWScript.GetIsTalentValid(talent) == 1;

        //     Note: Only placeables, doors and triggers can be trapped. * Returns TRUE if oObject
        //     is trapped.
        public static bool GetIsTrapped(NWObject obj)
            => Core.NWScript.GetIsTrapped(obj) == 1;

        //     * Returns TRUE if the weapon equipped is capable of damaging oVersus.
        public static bool GetIsWeaponEffective(NWObject? versus = null, bool offHand = false)
            => Core.NWScript.GetIsWeaponEffective(versus ?? NWObject.OBJECT_INVALID, offHand ? 1 : 0) == 1;

        //     Use this in an OnItemActivated module script to get the item that was activated.
        public static NWItem GetItemActivated()
            => new NWItem(Core.NWScript.GetItemActivated());

        //     Use this in an OnItemActivated module script to get the item's target.
        public static NWObject GetItemActivatedTarget()
            => new NWObject(Core.NWScript.GetItemActivatedTarget());

        //     Use this in an OnItemActivated module script to get the location of the item's
        //     target.
        public static Location GetItemActivatedTargetLocation()
            => Core.NWScript.GetItemActivatedTargetLocation();

        //     Use this in an OnItemActivated module script to get the creature that activated
        //     the item.
        public static NWCreature GetItemActivator()
            => new NWCreature(Core.NWScript.GetItemActivator());

        //     Get the Armour Class of oItem. * Return 0 if the oItem is not a valid item, or
        //     if oItem has no armour value.
        public static int GetItemACValue(NWItem item)
            => Core.NWScript.GetItemACValue(item);

        //     Queries the current value of the appearance settings on an item. The parameters
        //     are identical to those of CopyItemAndModify().
        public static int GetItemAppearance(NWItem item, ItemAppearanceType type, ItemAppearanceIndex index)
            => Core.NWScript.GetItemAppearance(item, (int)type, (int)index);

        //     Returns charges left on an item - oItem: item to query
        public static int GetItemCharges(NWItem item)
            => Core.NWScript.GetItemCharges(item);

        //     Returns TRUE if the item is cursed and cannot be dropped
        public static bool GetItemCursedFlag(NWItem item)
            => Core.NWScript.GetItemCursedFlag(item) == 1;

        //     Determines whether oItem has nProperty. - oItem - nProperty: ITEM_PROPERTY_*
        //     * Returns FALSE if oItem is not a valid item, or if oItem does not have nProperty.
        public static bool GetItemHasItemProperty(NWItem item, ItemPropertyType property)
            => Core.NWScript.GetItemHasItemProperty(item, (int)property) == 1;

        //     Get the object which is in oCreature's specified inventory slot - nInventorySlot:
        //     INVENTORY_SLOT_* - oCreature * Returns OBJECT_INVALID if oCreature is not a valid
        //     creature or there is no item in nInventorySlot.
        public static NWItem GetItemInSlot(InventorySlot inventorySlot, NWCreature? creature = null)
            => new NWItem(Core.NWScript.GetItemInSlot((int)inventorySlot, creature ?? NWObject.OBJECT_SELF));

        //     Get the object possessed by oCreature with the tag sItemTag * Return value on
        //     error: OBJECT_INVALID
        public static NWItem GetItemPossessedBy(NWCreature creature, string itemTag)
            => new NWItem(Core.NWScript.GetItemPossessedBy(creature, itemTag));

        //     Get the possessor of oItem * Return value on error: OBJECT_INVALID
        public static NWObject GetItemPossessor(NWItem item)
            => new NWObject(Core.NWScript.GetItemPossessor(item));

        //     Returns the Cost Table number of the item property. See the 2DA files for value
        //     definitions.
        public static int GetItemPropertyCostTable(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyCostTable(itemProp);

        //     Returns the Cost Table value (index of the cost table) of the item property.
        //     See the 2DA files for value definitions.
        public static int GetItemPropertyCostTableValue(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyCostTableValue(itemProp);

        //     Returns the total duration of the item property in seconds. - Returns 0 if the
        //     duration type of the item property is not DURATION_TYPE_TEMPORARY.
        public static int GetItemPropertyDuration(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyDuration(itemProp);

        //     Returns the remaining duration of the item property in seconds. - Returns 0 if
        //     the duration type of the item property is not DURATION_TYPE_TEMPORARY.
        public static int GetItemPropertyDurationRemaining(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyDurationRemaining(itemProp);

        //     will return the duration type of the item property
        public static DurationType GetItemPropertyDurationType(ItemProperty itemProp)
            => (DurationType)Core.NWScript.GetItemPropertyDurationType(itemProp);

        //     Returns the Param1 number of the item property. See the 2DA files for value definitions.
        public static int GetItemPropertyParam1(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyParam1(itemProp);

        //     Returns the Param1 value of the item property. See the 2DA files for value definitions.
        public static int GetItemPropertyParam1Value(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyParam1Value(itemProp);

        //     Returns the SubType number of the item property. See the 2DA files for value
        //     definitions.
        public static int GetItemPropertySubType(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertySubType(itemProp);

        //     Returns the string tag set for the provided item property. - If no tag has been
        //     set, returns an empty string.
        public static string GetItemPropertyTag(ItemProperty itemProp)
            => Core.NWScript.GetItemPropertyTag(itemProp);

        //     will return the item property type (ie. holy avenger)
        public static ItemPropertyType GetItemPropertyType(ItemProperty itemProp)
            => (ItemPropertyType)Core.NWScript.GetItemPropertyType(itemProp);

        //     Returns stack size of an item - oItem: item to query
        public static int GetItemStackSize(NWItem item)
            => Core.NWScript.GetItemStackSize(item);

        //     Get the experience assigned in the journal editor for szPlotID.
        public static int GetJournalQuestExperience(string plotID)
            => Core.NWScript.GetJournalQuestExperience(plotID);

        //     Get the feedback message that will be displayed when trying to unlock the object
        //     oObject. - oObject: a door or placeable. Returns an empty string "" on an error
        //     or if the game's default feedback message is being used
        public static string GetKeyRequiredFeedback(NWObject obj)
            => Core.NWScript.GetKeyRequiredFeedback(obj);

        //     Get the last command (ASSOCIATE_COMMAND_*) issued to oAssociate.
        public static AssociateCommand GetLastAssociateCommand(NWCreature? associate = null)
            => (AssociateCommand)Core.NWScript.GetLastAssociateCommand(associate ?? NWObject.OBJECT_SELF);

        //     Get the last attacker of oAttackee. This should only be used ONLY in the OnAttacked
        //     events for creatures, placeables and doors. * Return value on error: OBJECT_INVALID
        public static NWCreature GetLastAttacker(NWObject? attackee)
            => new NWCreature(Core.NWScript.GetLastAttacker(attackee ?? NWObject.OBJECT_SELF));

        //     Get the attack mode (COMBAT_MODE_*) of oCreature's last attack. This only works
        //     when oCreature is in combat.
        public static CombatMode GetLastAttackMode(NWCreature? creature = null)
            => (CombatMode)Core.NWScript.GetLastAttackMode(creature ?? NWObject.OBJECT_SELF);

        //     Get the attack type (SPECIAL_ATTACK_*) of oCreature's last attack. This only
        //     works when oCreature is in combat.
        public static SpecialAttack GetLastAttackType(NWCreature? creature = null)
            => (SpecialAttack)Core.NWScript.GetLastAttackType(creature ?? NWObject.OBJECT_SELF);

        //     Use this in an OnClosed script to get the object that closed the door or placeable.
        //     * Returns OBJECT_INVALID if the caller is not a valid door or placeable.
        public static NWObject GetLastClosedBy()
            => new NWObject(Core.NWScript.GetLastClosedBy());

        //     Get the last object that damaged oObject * Returns OBJECT_INVALID if the passed
        //     in object is not a valid object.
        public static NWObject GetLastDamager(NWObject? obj = null)
            => new NWObject(Core.NWScript.GetLastDamager(obj ?? NWObject.OBJECT_SELF));

        //     Get the last object that disarmed the trap on the caller. * Returns OBJECT_INVALID
        //     if the caller is not a valid placeable, trigger or door.
        public static NWObject GetLastDisarmed()
            => new NWObject(Core.NWScript.GetLastDisarmed());

        //     Get the last object that disturbed the inventory of the caller. * Returns OBJECT_INVALID
        //     if the caller is not a valid creature or placeable.
        public static NWObject GetLastDisturbed()
            => new NWObject(Core.NWScript.GetLastDisturbed());

        //     Get the last object that was sent as a GetLastAttacker(), GetLastDamager(), GetLastSpellCaster()
        //     (for a hostile spell), or GetLastDisturbed() (when a creature is pickpocketed).
        //     Note: Return values may only ever be: 1) A Creature 2) Plot Characters will never
        //     have this value set 3) Area of Effect Objects will return the AOE creator if
        //     they are registered as this value, otherwise they will return INVALID_OBJECT_ID
        //     4) Traps will not return the creature that set the trap. 5) This value will never
        //     be overwritten by another non-creature object. 6) This value will never be a
        //     dead/destroyed creature
        public static NWCreature GetLastHostileActor(NWObject? victim = null)
            => new NWCreature(Core.NWScript.GetLastHostileActor(victim ?? NWObject.OBJECT_SELF));

        //     Get the object that killed the caller.
        public static NWObject GetLastKiller()
            => new NWObject(Core.NWScript.GetLastKiller());

        //     Get the last object that locked the caller. * Returns OBJECT_INVALID if the caller
        //     is not a valid door or placeable.
        public static NWObject GetLastLocked()
            => new NWObject(Core.NWScript.GetLastLocked());

        //     Get the last creature that opened the caller. * Returns OBJECT_INVALID if the
        //     caller is not a valid door, placeable or store.
        public static NWCreature GetLastOpenedBy()
            => new NWCreature(Core.NWScript.GetLastOpenedBy());

        //     Get the last PC that has rested in the module.
        public static NWPlayer GetLastPCRested()
            => new NWPlayer(Core.NWScript.GetLastPCRested());

        //     Gets the last player character to cancel from a cutscene.
        public static NWPlayer GetLastPCToCancelCutscene()
            => new NWPlayer(Core.NWScript.GetLastPCToCancelCutscene());
        //
        // Summary:
        //     Use this in an OnPerception script to get the object that was perceived. * Returns
        //     OBJECT_INVALID if the caller is not a valid creature.
        public static NWObject GetLastPerceived()
            => new NWObject(Core.NWScript.GetLastPerceived());
        //
        // Summary:
        //     Use this in an OnPerception script to determine whether the object that was perceived
        //     was heard.
        public static bool GetLastPerceptionHeard()
            => Core.NWScript.GetLastPerceptionHeard() == 1;

        //     Use this in an OnPerception script to determine whether the object that was perceived
        //     has become inaudible.
        public static bool GetLastPerceptionInaudible()
            => Core.NWScript.GetLastPerceptionInaudible() == 1;

        //     Use this in an OnPerception script to determine whether the object that was perceived
        //     was seen.
        public static bool GetLastPerceptionSeen()
            => Core.NWScript.GetLastPerceptionSeen() == 1;

        //     Use this in an OnPerception script to determine whether the object that was perceived
        //     has vanished.
        public static bool GetLastPerceptionVanished()
            => Core.NWScript.GetLastPerceptionVanished() == 1;

        //     Use this in an OnPlayerDeath module script to get the last player that died.
        public static NWPlayer GetLastPlayerDied()
            => new NWPlayer(Core.NWScript.GetLastPlayerDied());

        //     Use this in an OnPlayerDying module script to get the last player who is dying.
        public static NWPlayer GetLastPlayerDying()
            => new NWPlayer(Core.NWScript.GetLastPlayerDying());

        //     Use this in an OnRespawnButtonPressed module script to get the object id of the
        //     player who last pressed the respawn button.
        public static NWPlayer GetLastRespawnButtonPresser()
            => new NWPlayer(Core.NWScript.GetLastRespawnButtonPresser());

        //     Determine the type (REST_EVENTTYPE_REST_*) of the last rest event (as returned
        //     from the OnPCRested module event).
        public static RestEventType GetLastRestEventType()
            => (RestEventType)Core.NWScript.GetLastRestEventType();
        //
        // Summary:
        //     Use this in a conversation script to get the person with whom you are conversing.
        //     * Returns OBJECT_INVALID if the caller is not a valid creature.
        public static NWObject GetLastSpeaker()
            => new NWObject(Core.NWScript.GetLastSpeaker());

        //     This is for use in a "Spell Cast" script, it gets the ID of the spell that was
        //     cast.
        public static Spell GetLastSpell()
            => (Spell)Core.NWScript.GetLastSpell();

        //     Returns the class that the spellcaster cast the spell as. - Returns CLASS_TYPE_INVALID
        //     if the caster has no valid class (placeables, etc...)
        public static ClassType GetLastSpellCastClass()
            => (ClassType)Core.NWScript.GetLastSpellCastClass();

        //     This is for use in a "Spell Cast" script, it gets who cast the spell. The spell
        //     could have been cast by a creature, placeable or door. * Returns OBJECT_INVALID
        //     if the caller is not a creature, placeable or door.
        public static NWObject GetLastSpellCaster()
            => new NWObject(Core.NWScript.GetLastSpellCaster());

        //     Use this in a SpellCast script to determine whether the spell was considered
        //     harmful. * Returns TRUE if the last spell cast was harmful.
        public static bool GetLastSpellHarmful()
            => Core.NWScript.GetLastSpellHarmful() == 1;

        //     Get the last trap detected by oTarget. * Return value on error: OBJECT_INVALID
        public static NWObject GetLastTrapDetected(NWObject? target = null)
            => new NWObject(Core.NWScript.GetLastTrapDetected(target ?? NWObject.OBJECT_SELF));
        //
        // Summary:
        //     Get the last object that unlocked the caller. * Returns OBJECT_INVALID if the
        //     caller is not a valid door or placeable.
        public static NWObject GetLastUnlocked()
            => new NWObject(Core.NWScript.GetLastUnlocked());

        //     Get the last object that used the placeable object that is calling this function.
        //     * Returns OBJECT_INVALID if it is called by something other than a placeable
        //     or a door.
        public static NWObject GetLastUsedBy()
            => new NWObject(Core.NWScript.GetLastUsedBy());

        //     Get the last weapon that oCreature used in an attack. * Returns OBJECT_INVALID
        //     if oCreature did not attack, or has no weapon equipped.
        public static NWItem GetLastWeaponUsed(NWCreature creature)
            => new NWItem(Core.NWScript.GetLastWeaponUsed(creature));

        //     Get an integer between 0 and 100 (inclusive) to represent oCreature's Law/Chaos
        //     alignment (100=law, 0=chaos) * Return value if oCreature is not a valid creature:
        //     -1
        public static int GetLawChaosValue(NWCreature creature)
            => Core.NWScript.GetLawChaosValue(creature);

        //     Determine the levels that oCreature holds in nClassType. - nClassType: CLASS_TYPE_*
        //     - oCreature
        public static int GetLevelByClass(ClassType classType, NWCreature? creature = null)
            => Core.NWScript.GetLevelByClass((int)classType, creature ?? NWObject.OBJECT_SELF);

        //     A creature can have up to three classes. This function determines the creature's
        //     class level based on nClass Position. - nClassPosition: 1, 2 or 3 - oCreature
        //     * Returns 0 if oCreature does not have a class in nClassPosition (i.e. a single-class
        //     creature will only have a value in nClassLocation=1) or if oCreature is not a
        //     valid creature.
        public static int GetLevelByPosition(ClassPosition classPosition, NWCreature? creature = null)
            => Core.NWScript.GetLevelByPosition((int)classPosition, creature ?? NWObject.OBJECT_SELF);

        //     In an onConversation script this gets the number of the string pattern matched
        //     (the one that triggered the script). * Returns -1 if no string matched
        public static int GetListenPatternNumber()
            => Core.NWScript.GetListenPatternNumber();

        //     Get oObject's local float variable sVarName * Return value on error: 0.0f
        public static float GetLocalFloat(NWObject obj, string varName)
            => Core.NWScript.GetLocalFloat(obj, varName);

        //     Get oObject's local integer variable sVarName * Return value on error: 0
        public static int GetLocalInt(NWObject obj, string varName)
            => Core.NWScript.GetLocalInt(obj, varName);
        //
        // Summary:
        //     Get oObject's local location variable sVarname
        public static Location GetLocalLocation(NWObject obj, string varName)
            => Core.NWScript.GetLocalLocation(obj, varName);

        //     Get oObject's local object variable sVarName * Return value on error: OBJECT_INVALID
        public static NWObjectBase GetLocalObject(NWObjectBase obj, string varName)
            => new NWObjectBase(Core.NWScript.GetLocalObject(obj, varName));

        //     Get oObject's local string variable sVarName * Return value on error: ""
        public static string GetLocalString(NWObject obj, string varName)
            => Core.NWScript.GetLocalString(obj, varName);

        //     Get the location of oObject.
        public static Location GetLocation(NWObject obj)
            => Core.NWScript.GetLocation(obj);

        //     Get the locked state of oTarget, which can be a door or a placeable object.
        public static bool GetLocked(NWObject target)
            => Core.NWScript.GetLocked(target) == 1;

        //     * Returns TRUE if a specific key is required to open the lock on oObject.
        public static bool GetLockKeyRequired(NWObject obj)
            => Core.NWScript.GetLockKeyRequired(obj) == 1;

        //     Get the tag of the key that will open the lock on oObject.
        public static string GetLockKeyTag(NWObject obj)
            => Core.NWScript.GetLockKeyTag(obj);

        //     * Returns TRUE if the lock on oObject is lockable.
        public static bool GetLockLockable(NWObject obj)
            => Core.NWScript.GetLockLockable(obj) == 1;

        //     Get the DC for locking oObject.
        public static int GetLockLockDC(NWObject obj)
            => Core.NWScript.GetLockLockDC(obj);

        //     Get the DC for unlocking oObject.
        public static int GetLockUnlockDC(NWObject obj)
            => Core.NWScript.GetLockUnlockDC(obj);
        //
        // Summary:
        //     Returns the lootable state of a creature.
        public static bool GetLootable(NWCreature creature)
            => Core.NWScript.GetLootable(creature) == 1;

        //     Get the master of oAssociate.
        public static NWCreature GetMaster(NWCreature? associate = null)
            => new NWCreature(Core.NWScript.GetMaster(associate ?? NWObject.OBJECT_SELF));

        //     Get the appropriate matched string (this should only be used in OnConversation
        //     scripts). * Returns the appropriate matched string, otherwise returns ""
        public static string GetMatchedSubstring(int index)
            => Core.NWScript.GetMatchedSubstring(index);

        //     Get the number of string parameters available. * Returns -1 if no string matched
        //     (this could be because of a dialogue event)
        public static int GetMatchedSubstringsCount()
            => Core.NWScript.GetMatchedSubstringsCount();

        //     Gets the maximum number of henchmen
        public static int GetMaxHenchmen()
            => Core.NWScript.GetMaxHenchmen();

        //     Get the maximum hitpoints of oObject * Return value on error: 0
        public static int GetMaxHitPoints(NWObject? obj = null)
            => Core.NWScript.GetMaxHitPoints(obj ?? NWObject.OBJECT_SELF);
        //
        // Summary:
        //     Get the metamagic type (METAMAGIC_*) of the last spell cast by the caller * Return
        //     value if the caster is not a valid object: -1
        public static Metamagic GetMetaMagicFeat()
            => (Metamagic)Core.NWScript.GetMetaMagicFeat();

        //     Get the module. * Return value on error: OBJECT_INVALID
        public static NWModule GetModule()
            => new NWModule(Core.NWScript.GetModule());

        //     Use this in an OnItemAcquired script to get the item that was acquired. * Returns
        //     OBJECT_INVALID if the module is not valid.
        public static NWItem GetModuleItemAcquired()
            => new NWItem(Core.NWScript.GetModuleItemAcquired());

        //     Gets the object that acquired the module item. May be a creature, item, or placeable
        public static NWObject GetModuleItemAcquiredBy()
            => new NWObject(Core.NWScript.GetModuleItemAcquiredBy());
        //
        // Summary:
        //     Use this in an OnItemAcquired script to get the creatre that previously possessed
        //     the item. * Returns OBJECT_INVALID if the item was picked up from the ground.
        public static NWObject GetModuleItemAcquiredFrom()
            => new NWObject(Core.NWScript.GetModuleItemAcquiredFrom());

        //     in an onItemAcquired script, returns the size of the stack of the item that was
        //     just acquired. * returns the stack size of the item acquired
        public static int GetModuleItemAcquiredStackSize()
            => Core.NWScript.GetModuleItemAcquiredStackSize();

        //     Use this in an OnItemLost script to get the item that was lost/dropped. * Returns
        //     OBJECT_INVALID if the module is not valid.
        public static NWItem GetModuleItemLost()
            => new NWItem(Core.NWScript.GetModuleItemLost());

        //     Use this in an OnItemLost script to get the creature that lost the item. * Returns
        //     OBJECT_INVALID if the module is not valid.
        public static NWObject GetModuleItemLostBy()
            => new NWObject(Core.NWScript.GetModuleItemLostBy());

        //     Get the module's name in the language of the server that's running it. * If there
        //     is no entry for the language of the server, it will return an empty string
        public static string GetModuleName()
            => Core.NWScript.GetModuleName();
        //
        // Summary:
        //     Get the XP scale being used for the module.
        public static int GetModuleXPScale()
            => Core.NWScript.GetModuleXPScale();

        //     Get oCreature's movement rate. * Returns 0 if oCreature is invalid.
        public static int GetMovementRate(NWCreature creature)
            => Core.NWScript.GetMovementRate(creature);

        //     Set the name of oObject. - oObject: the object for which you are changing the
        //     name (area, creature, placeable, item, or door). - sNewName: the new name that
        //     the object will use. Note: SetName() does not work on player objects. Setting
        //     an object's name to "" will make the object revert to using the name it had originally
        //     before any SetName() calls were made on the object.
        public static string GetName(NWObject obj, bool originalName = false)
            => Core.NWScript.GetName(obj, originalName ? 1 : 0);

        //     Get the creature nearest to oTarget, subject to all the criteria specified. -
        //     nFirstCriteriaType: CREATURE_TYPE_* - nFirstCriteriaValue: -> CLASS_TYPE_* if
        //     nFirstCriteriaType was CREATURE_TYPE_CLASS -> SPELL_* if nFirstCriteriaType was
        //     CREATURE_TYPE_DOES_NOT_HAVE_SPELL_EFFECT or CREATURE_TYPE_HAS_SPELL_EFFECT ->
        //     TRUE or FALSE if nFirstCriteriaType was CREATURE_TYPE_IS_ALIVE -> PERCEPTION_*
        //     if nFirstCriteriaType was CREATURE_TYPE_PERCEPTION -> PLAYER_CHAR_IS_PC or PLAYER_CHAR_NOT_PC
        //     if nFirstCriteriaType was CREATURE_TYPE_PLAYER_CHAR -> RACIAL_TYPE_* if nFirstCriteriaType
        //     was CREATURE_TYPE_RACIAL_TYPE -> REPUTATION_TYPE_* if nFirstCriteriaType was
        //     CREATURE_TYPE_REPUTATION For example, to get the nearest PC, use: (CREATURE_TYPE_PLAYER_CHAR,
        //     PLAYER_CHAR_IS_PC) - oTarget: We're trying to find the creature of the specified
        //     type that is nearest to oTarget - nNth: We don't have to find the first nearest:
        //     we can find the Nth nearest... - nSecondCriteriaType: This is used in the same
        //     way as nFirstCriteriaType to further specify the type of creature that we are
        //     looking for. - nSecondCriteriaValue: This is used in the same way as nFirstCriteriaValue
        //     to further specify the type of creature that we are looking for. - nThirdCriteriaType:
        //     This is used in the same way as nFirstCriteriaType to further specify the type
        //     of creature that we are looking for. - nThirdCriteriaValue: This is used in the
        //     same way as nFirstCriteriaValue to further specify the type of creature that
        //     we are looking for. * Return value on error: OBJECT_INVALID
        public static NWCreature GetNearestCreature(CreatureType creatureType, int typeParameter, NWObject? target = null, int nth = 1, CreatureType secondCreatureType = CreatureType.None, int secondTypeParameter = -1, CreatureType thirdCreatureType = CreatureType.None, int thirdTypeParameter = -1)
            => new NWCreature(Core.NWScript.GetNearestCreature((int)creatureType, typeParameter, target ?? NWObject.OBJECT_SELF, nth, (int)secondCreatureType, secondTypeParameter, (int)thirdCreatureType, thirdTypeParameter));
        //
        // Summary:
        //     Get the creature nearest to lLocation, subject to all the criteria specified.
        //     - nFirstCriteriaType: CREATURE_TYPE_* - nFirstCriteriaValue: -> CLASS_TYPE_*
        //     if nFirstCriteriaType was CREATURE_TYPE_CLASS -> SPELL_* if nFirstCriteriaType
        //     was CREATURE_TYPE_DOES_NOT_HAVE_SPELL_EFFECT or CREATURE_TYPE_HAS_SPELL_EFFECT
        //     -> TRUE or FALSE if nFirstCriteriaType was CREATURE_TYPE_IS_ALIVE -> PERCEPTION_*
        //     if nFirstCriteriaType was CREATURE_TYPE_PERCEPTION -> PLAYER_CHAR_IS_PC or PLAYER_CHAR_NOT_PC
        //     if nFirstCriteriaType was CREATURE_TYPE_PLAYER_CHAR -> RACIAL_TYPE_* if nFirstCriteriaType
        //     was CREATURE_TYPE_RACIAL_TYPE -> REPUTATION_TYPE_* if nFirstCriteriaType was
        //     CREATURE_TYPE_REPUTATION For example, to get the nearest PC, use (CREATURE_TYPE_PLAYER_CHAR,
        //     PLAYER_CHAR_IS_PC) - lLocation: We're trying to find the creature of the specified
        //     type that is nearest to lLocation - nNth: We don't have to find the first nearest:
        //     we can find the Nth nearest.... - nSecondCriteriaType: This is used in the same
        //     way as nFirstCriteriaType to further specify the type of creature that we are
        //     looking for. - nSecondCriteriaValue: This is used in the same way as nFirstCriteriaValue
        //     to further specify the type of creature that we are looking for. - nThirdCriteriaType:
        //     This is used in the same way as nFirstCriteriaType to further specify the type
        //     of creature that we are looking for. - nThirdCriteriaValue: This is used in the
        //     same way as nFirstCriteriaValue to further specify the type of creature that
        //     we are looking for. * Return value on error: OBJECT_INVALID
        public static NWCreature GetNearestCreatureToLocation(CreatureType creatureType, int typeParameter, Location location, int nth = 1, CreatureType secondCreatureType = CreatureType.None, int secondTypeParameter = -1, CreatureType thirdCreatureType = CreatureType.None, int thirdTypeParameter = -1)
            => new NWCreature(Core.NWScript.GetNearestCreatureToLocation((int)creatureType, typeParameter, location, nth, (int)secondCreatureType, secondTypeParameter, (int)thirdCreatureType, thirdTypeParameter));

        //     Get the Nth object nearest to oTarget that is of the specified type. - nObjectType:
        //     OBJECT_TYPE_* - oTarget - nNth * Return value on error: OBJECT_INVALID
        public static NWObject GetNearestObject(ObjectType objectType = ObjectType.All, NWObject? target = null, int nth = 1)
            => new NWObject(Core.NWScript.GetNearestObject((int)objectType, target ?? NWObject.OBJECT_SELF, nth));

        //     Get the nth Object nearest to oTarget that has sTag as its tag. * Return value
        //     on error: OBJECT_INVALID
        public static NWObject GetNearestObjectByTag(string tag, NWObject? target = null, int nth = 1)
            => new NWObject(Core.NWScript.GetNearestObjectByTag(tag, target ?? NWObject.OBJECT_SELF, nth));

        //     Get the nNth object nearest to lLocation that is of the specified type. - nObjectType:
        //     OBJECT_TYPE_* - lLocation - nNth * Return value on error: OBJECT_INVALID
        public static NWObject GetNearestObjectToLocation(ObjectType objectType, Location location, int nth = 1)
            => new NWObject(Core.NWScript.GetNearestObjectToLocation((int)objectType, location, nth));

        //     Get the trap nearest to oTarget. Note : "trap objects" are actually any trigger,
        //     placeable or door that is trapped in oTarget's area. - oTarget - nTrapDetected:
        //     if this is TRUE, the trap returned has to have been detected by oTarget.
        public static NWObject GetNearestTrapToObject(NWObject? target = null, bool trapDetected = true)
            => new NWObject(Core.NWScript.GetNearestTrapToObject(target ?? NWObject.OBJECT_SELF, trapDetected ? 1 : 0));

        //     Returns the next area in the module (after GetFirstArea), or OBJECT_INVALID if
        //     no more areas are loaded.
        public static NWArea GetNextArea()
            => new NWArea(Core.NWScript.GetNextArea());

        //     Get the next in-game effect on oCreature.
        public static Effect GetNextEffect(NWCreature creature)
            => Core.NWScript.GetNextEffect(creature);

        //     Get the next member of oMemberOfFaction's faction (continue to cycle through
        //     oMemberOfFaction's faction). * Returns OBJECT_INVALID if oMemberOfFaction's faction
        //     is invalid.
        public static NWCreature GetNextFactionMember(NWCreature memberOfFaction, bool pcOnly = true)
            => new NWCreature(Core.NWScript.GetNextFactionMember(memberOfFaction, pcOnly ? 1 : 0));

        //     Get the next object within oPersistentObject. - oPersistentObject - nResidentObjectType:
        //     OBJECT_TYPE_* - nPersistentZone: PERSISTENT_ZONE_ACTIVE. [This could also take
        //     the value PERSISTENT_ZONE_FOLLOW, but this is no longer used.] * Returns OBJECT_INVALID
        //     if no object is found.
        public static NWObject GetNextInPersistentObject(NWObject? persistentObject = null, ObjectType residentObjectType = ObjectType.Creature, PersistentZone persistentZone = PersistentZone.Active)
            => new NWObject(Core.NWScript.GetNextInPersistentObject(persistentObject ?? NWObject.OBJECT_SELF, (int)residentObjectType, (int)persistentZone));

        //     Get the next item in oTarget's inventory (continue to cycle through oTarget's
        //     inventory). * Returns OBJECT_INVALID if the caller is not a creature, item, placeable
        //     or store, or if no item is found.
        public static NWItem GetNextItemInInventory(NWObject? target = null)
            => new NWItem(Core.NWScript.GetNextItemInInventory(target ?? NWObject.OBJECT_SELF));

        //     Will keep retrieving the next and the next item property on an Item, will return
        //     an invalid item property when the list is empty.
        public static ItemProperty GetNextItemProperty(NWItem item)
            => Core.NWScript.GetNextItemProperty(item);

        //     Get the next object in oArea. If no valid area is specified, it will use the
        //     caller's area. * Return value on error: OBJECT_INVALID
        public static NWObject GetNextObjectInArea(NWArea? area = null)
            => new NWObject(Core.NWScript.GetNextObjectInArea(area ?? NWObject.OBJECT_INVALID));

        //     Get the next object in nShape - nShape: SHAPE_* - fSize: -> If nShape == SHAPE_SPHERE,
        //     this is the radius of the sphere -> If nShape == SHAPE_SPELLCYLINDER, this is
        //     the length of the cylinder. Spell Cylinder's always have a radius of 1.5m. ->
        //     If nShape == SHAPE_CONE, this is the widest radius of the cone -> If nShape ==
        //     SHAPE_SPELLCONE, this is the length of the cone in the direction of lTarget.
        //     Spell cones are always 60 degrees with the origin at OBJECT_SELF. -> If nShape
        //     == SHAPE_CUBE, this is half the length of one of the sides of the cube - lTarget:
        //     This is the centre of the effect, usually GetSpellTargetLocation(), or the end
        //     of a cylinder or cone. - bLineOfSight: This controls whether to do a line-of-sight
        //     check on the object returned. (This can be used to ensure that spell effects
        //     do not go through walls.) Line of sight check is done from origin to target object
        //     at a height 1m above the ground - nObjectFilter: This allows you to filter out
        //     undesired object types, using bitwise "or". For example, to return only creatures
        //     and doors, the value for this parameter would be OBJECT_TYPE_CREATURE | OBJECT_TYPE_DOOR
        //     - vOrigin: This is only used for cylinders and cones, and specifies the origin
        //     of the effect (normally the spell-caster's position). Return value on error:
        //     OBJECT_INVALID
        public static NWObject GetNextObjectInShape(Shape shape, float size, Location location, bool lineOfSight = false, ObjectType objectFilter = ObjectType.Creature, Vector3 origin = default)
            => new NWObject(Core.NWScript.GetNextObjectInShape((int)shape, size, location, lineOfSight ? 1 : 0, (int)objectFilter, origin));

        //     Get the next PC in the player list. This picks up where the last GetFirstPC()
        //     or GetNextPC() left off.
        public static NWPlayer GetNextPC()
            => new NWPlayer(Core.NWScript.GetNextPC());

        //     Get the number of stacked items that oItem comprises.
        public static int GetNumStackedItems(NWItem item)
            => Core.NWScript.GetNumStackedItems(item);

        //     Get the nNth object with the specified tag. - sTag - nNth: the nth object with
        //     this tag may be requested * Returns OBJECT_INVALID if the object cannot be found.
        //     Note: The module cannot be retrieved by GetObjectByTag(), use GetModule() instead.
        public static NWObject GetObjectByTag(string tag, int nth = 0)
            => new NWObject(Core.NWScript.GetObjectByTag(tag, nth));

        //     Looks up a object on the server by its UUID. Returns OBJECT_INVALID if the UUID
        //     is not on the server.
        public static NWObject GetObjectByUUID(string UUID)
            => new NWObject(Core.NWScript.GetObjectByUUID(UUID));

        //     Determine whether oSource hears oTarget. NOTE: This *only* works on creatures,
        //     as visibility lists are not maintained for non-creature objects.
        public static bool GetObjectHeard(NWObject target, NWObject? source = null)
            => Core.NWScript.GetObjectHeard(target, source ?? NWObject.OBJECT_SELF) == 1;
        //
        // Summary:
        //     Determine whether oSource sees oTarget. NOTE: This *only* works on creatures,
        //     as visibility lists are not maintained for non-creature objects.
        public static int GetObjectSeen(NWObject target, NWObject? source = null)
            => Core.NWScript.GetObjectSeen(target, source ?? NWObject.OBJECT_SELF);

        //     Get the object type (OBJECT_TYPE_*) of oTarget * Return value if oTarget is not
        //     a valid object: -1
        public static ObjectType GetObjectType(NWObject target)
            => (ObjectType)Core.NWScript.GetObjectType(target);

        //     Returns the given objects' UUID. This UUID is persisted across save boundaries,
        //     like Save/RestoreCampaignObject and save games. Thus, reidentification is only
        //     guaranteed in scenarios where players cannot introduce new objects (i.e. servervault
        //     servers). UUIDs are guaranteed to be unique in any single running game. If a
        //     loaded object would collide with a UUID already present in the game, the object
        //     receives no UUID and a warning is emitted to the log. Requesting a UUID for the
        //     new object will generate a random one. This UUID is useful to, for example: -
        //     Safely identify servervault characters - Track serialisable objects (like items
        //     or creatures) as they are saved to the campaign DB - i.e. persistent storage
        //     chests or dropped items. - Track objects across multiple game instances (in trusted
        //     scenarios). Currently, the following objects can carry UUIDs: Items, Creatures,
        //     Placeables, Triggers, Doors, Waypoints, Stores, Encounters, Areas. Will return
        //     "" (empty string) when the given object cannot carry a UUID.
        public static string GetObjectUUID(NWObject obj)
            => Core.NWScript.GetObjectUUID(obj);

        //     Gets a visual transform on the given object. - oObject can be any valid Creature,
        //     Placeable, Item or Door. - nTransform is one of OBJECT_VISUAL_TRANSFORM_* Returns
        //     the current (or default) value.
        public static float GetObjectVisualTransform(NWObject obj, ObjectVisualTransform transform)
            => Core.NWScript.GetObjectVisualTransform(obj, (int)transform);

        //     Get the last player chat(text) message that was sent. Should only be called from
        //     a module's OnPlayerChat event script. * Returns empty string "" on error. Note:
        //     Private tells do not trigger a OnPlayerChat event.
        public static string GetPCChatMessage()
            => Core.NWScript.GetPCChatMessage();
        //
        // Summary:
        //     Get the PC that sent the last player chat(text) message. Should only be called
        //     from a module's OnPlayerChat event script. * Returns OBJECT_INVALID on error.
        //     Note: Private tells do not trigger a OnPlayerChat event.
        public static NWPlayer GetPCChatSpeaker()
            => new NWPlayer(Core.NWScript.GetPCChatSpeaker());

        //     Get the volume of the last player chat(text) message that was sent. Returns one
        //     of the following TALKVOLUME_* constants based on the volume setting that the
        //     player used to send the chat message. TALKVOLUME_TALK TALKVOLUME_WHISPER TALKVOLUME_SHOUT
        //     TALKVOLUME_SILENT_SHOUT (used for DM chat channel) TALKVOLUME_PARTY Should only
        //     be called from a module's OnPlayerChat event script. * Returns -1 on error. Note:
        //     Private tells do not trigger a OnPlayerChat event.
        public static TalkVolume GetPCChatVolume()
            => (TalkVolume)Core.NWScript.GetPCChatVolume();

        //     Get the IP address from which oPlayer has connected.
        public static string GetPCIPAddress(NWPlayer player)
            => Core.NWScript.GetPCIPAddress(player);

        //     Use this to get the item last equipped by a player character in OnPlayerEquipItem..
        public static NWItem GetPCItemLastEquipped()
            => new NWItem(Core.NWScript.GetPCItemLastEquipped());

        //     Use this to get the player character who last equipped an item in OnPlayerEquipItem..
        public static NWPlayer GetPCItemLastEquippedBy()
            => new NWPlayer(Core.NWScript.GetPCItemLastEquippedBy());

        //     Use this to get the item last unequipped by a player character in OnPlayerEquipItem..
        public static NWItem GetPCItemLastUnequipped()
            => new NWItem(Core.NWScript.GetPCItemLastUnequipped());

        //     Use this to get the player character who last unequipped an item in OnPlayerUnEquipItem..
        public static NWPlayer GetPCItemLastUnequippedBy()
            => new NWPlayer(Core.NWScript.GetPCItemLastUnequippedBy());

        //     Get the last PC that levelled up.
        public static NWPlayer GetPCLevellingUp()
            => new NWPlayer(Core.NWScript.GetPCLevellingUp());

        //     Get the name of oPlayer.
        public static string GetPCPlayerName(NWPlayer player)
            => Core.NWScript.GetPCPlayerName(player);

        //     Get the public part of the CD Key that oPlayer used when logging in. - nSinglePlayerCDKey:
        //     If set to TRUE, the player's public CD Key will be returned when the player is
        //     playing in single player mode (otherwise returns an empty string in single player
        //     mode).
        public static string GetPCPublicCDKey(NWPlayer player, bool singlePlayerCDKey = false)
            => Core.NWScript.GetPCPublicCDKey(player, singlePlayerCDKey ? 1 : 0);

        //     Get the PC that is involved in the conversation. * Returns OBJECT_INVALID on
        //     error.
        public static NWPlayer GetPCSpeaker()
            => new NWPlayer(Core.NWScript.GetPCSpeaker());

        //     Returns the creature's currently set PhenoType (body type).
        public static Phenotype GetPhenoType(NWCreature creature)
            => (Phenotype)Core.NWScript.GetPhenoType(creature);

        //     returns TRUE if the item CAN be pickpocketed
        public static bool GetPickpocketableFlag(NWItem item)
            => Core.NWScript.GetPickpocketableFlag(item) == 1;

        //     * Returns TRUE if the illumination for oPlaceable is on
        public static bool GetPlaceableIllumination(NWPlaceable? placeable = null)
            => Core.NWScript.GetPlaceableIllumination(placeable ?? NWObject.OBJECT_SELF) == 1;

        //     Get the last object that default clicked (left clicked) on the placeable object
        //     that is calling this function. Should only be called from a placeables OnClick
        //     event. * Returns OBJECT_INVALID if it is called by something other than a placeable.
        public static NWPlayer GetPlaceableLastClickedBy()
            => new NWPlayer(Core.NWScript.GetPlaceableLastClickedBy());

        //     Returns the build number of oPlayer (i.e. 8193). Returns 0 if the given object
        //     isn't a player or did not advertise their build info.
        public static int GetPlayerBuildVersionMajor(NWPlayer player)
            => Core.NWScript.GetPlayerBuildVersionMajor(player);

        //     Returns the patch revision of oPlayer (i.e. 8). Returns 0 if the given object
        //     isn't a player or did not advertise their build info.
        public static int GetPlayerBuildVersionMinor(NWPlayer player)
            => Core.NWScript.GetPlayerBuildVersionMinor(player);

        //     Determine whether oTarget is a plot object.
        public static bool GetPlotFlag(NWObject? target = null)
            => Core.NWScript.GetPlotFlag(target ?? NWObject.OBJECT_SELF) == 1;

        //     Get the PortraitId of oTarget. - oTarget: the object for which you are getting
        //     the portrait Id. Returns: The Portrait Id number being used for the object oTarget.
        //     The Portrait Id refers to the row number of the Portraits.2da that this portrait
        //     is from. If a custom portrait is being used, oTarget is a player object, or on
        //     an error returns PORTRAIT_INVALID. In these instances try using GetPortraitResRef()
        //     instead.
        public static int GetPortraitId(NWObject? target = null)
            => Core.NWScript.GetPortraitId(target ?? NWObject.OBJECT_SELF);
        //
        // Summary:
        //     Get the Portrait ResRef of oTarget. - oTarget: the object for which you are getting
        //     the portrait ResRef. Returns: The Portrait ResRef being used for the object oTarget.
        //     The Portrait ResRef will not include a trailing size letter.
        public static string GetPortraitResRef(NWObject? target = null)
            => Core.NWScript.GetPortraitResRef(target ?? NWObject.OBJECT_SELF);

        //     Get the position of oTarget * Return value on error: vector (0.0f, 0.0f, 0.0f)
        public static Vector3 GetPosition(NWObject target)
            => Core.NWScript.GetPosition(target);

        //     Get the position vector from lLocation.
        public static Vector3 GetPositionFromLocation(Location location)
            => Core.NWScript.GetPositionFromLocation(location);

        //     Get the racial type (RACIAL_TYPE_*) of oCreature * Return value if oCreature
        //     is not a valid creature: RACIAL_TYPE_INVALID
        public static RacialType GetRacialType(NWCreature creature)
            => (RacialType)Core.NWScript.GetRacialType(creature);

        //     Returns a UUID. This UUID will not be associated with any object. The generated
        //     UUID is currently a v4.
        public static string GetRandomUUID()
            => Core.NWScript.GetRandomUUID();

        //     Use this in spell scripts to get nDamage adjusted by oTarget's reflex and evasion
        //     saves. - nDamage - oTarget - nDC: Difficulty check - nSaveType: SAVING_THROW_TYPE_*
        //     - oSaveVersus
        public static int GetReflexAdjustedDamage(int damage, NWObject target, int dc, SavingThrowType saveType = SavingThrowType.All, NWObject? saveVersus = null)
            => Core.NWScript.GetReflexAdjustedDamage(damage, target, dc, (int)saveType, saveVersus ?? NWObject.OBJECT_INVALID);

        //     Get oTarget's base reflex saving throw value (this will only work for creatures,
        //     doors, and placeables). * Returns 0 if oTarget is invalid.
        public static int GetReflexSavingThrow(NWObject target)
            => Core.NWScript.GetReflexSavingThrow(target);

        //     Get an integer between 0 and 100 (inclusive) that represents how oSource feels
        //     about oTarget. -> 0-10 means oSource is hostile to oTarget -> 11-89 means oSource
        //     is neutral to oTarget -> 90-100 means oSource is friendly to oTarget * Returns
        //     -1 if oSource or oTarget does not identify a valid object
        public static int GetReputation(NWObject source, NWObject target)
            => Core.NWScript.GetReputation(source, target);

        //     returns the template used to create this object (if appropriate) * returns an
        //     empty string when no template found
        public static string GetResRef(NWObject obj)
            => Core.NWScript.GetResRef(obj);

        //     Gets the saving throw bonus limit. - The default value is 20.
        public static int GetSavingThrowBonusLimit()
            => Core.NWScript.GetSavingThrowBonusLimit();

        //     Get the creature that is currently sitting on the specified object. - oChair
        //     * Returns OBJECT_INVALID if oChair is not a valid placeable.
        public static NWCreature GetSittingCreature(NWPlaceable chair)
            => new NWCreature(Core.NWScript.GetSittingCreature(chair));

        //     Gets the skill bonus limit. - The default value is 50.
        public static int GetSkillBonusLimit()
            => Core.NWScript.GetSkillBonusLimit();
        //
        // Summary:
        //     Get the number of ranks that oTarget has in nSkill. - nSkill: SKILL_* - oTarget
        //     - nBaseSkillRank: if set to true returns the number of base skill ranks the target
        //     has (i.e. not including any bonuses from ability scores, feats, etc). * Returns
        //     -1 if oTarget doesn't have nSkill. * Returns 0 if nSkill is untrained.
        public static int GetSkillRank(Skill skill, NWObject? target = null, bool baseSkillRank = false)
            => Core.NWScript.GetSkillRank((int)skill, target ?? NWObject.OBJECT_SELF, baseSkillRank ? 1 : 0);

        //     Gets the skybox that is currently displayed in the specified area. Returns: SKYBOX_*
        //     constant If no valid area (or object) is specified, it uses the area of caller.
        //     If an object other than an area is specified, will use the area that the object
        //     is currently in.
        public static SkyBox GetSkyBox(NWArea? area = null)
            => (SkyBox)Core.NWScript.GetSkyBox(area ?? NWObject.OBJECT_INVALID);

        //     Returns oCreature's spell school specialization in nClass (SPELL_SCHOOL_* constants)
        //     Unless custom content is used, only Wizards have spell schools Returns -1 on
        //     error
        public static SpellSchool GetSpecialization(NWCreature creature, ClassType classType = ClassType.Wizard)
            => (SpellSchool)Core.NWScript.GetSpecialization(creature, (int)classType);

        //     Use this in a spell script to get the item used to cast the spell.
        public static NWItem GetSpellCastItem()
            => new NWItem(Core.NWScript.GetSpellCastItem());

        //     This is for use in a Spell script, it gets the ID of the spell that is being
        //     cast (SPELL_*).
        public static Spell GetSpellId()
            => (Spell)Core.NWScript.GetSpellId();

        //     Returns the spell resistance of the specified creature. - Returns 0 if the creature
        //     has no spell resistance or an invalid creature is passed in.
        public static int GetSpellResistance(NWCreature creature)
            => Core.NWScript.GetSpellResistance(creature);

        //     Get the DC to save against for a spell (10 + spell level + relevant ability bonus).
        //     This can be called by a creature or by an Area of Effect object.
        public static int GetSpellSaveDC()
            => Core.NWScript.GetSpellSaveDC();

        //     Get the location of the caller's last spell target.
        public static Location GetSpellTargetLocation()
            => Core.NWScript.GetSpellTargetLocation();

        //     Get the object at which the caller last cast a spell * Return value on error:
        //     OBJECT_INVALID
        public static NWObject GetSpellTargetObject()
            => new NWObject(Core.NWScript.GetSpellTargetObject());

        //     Find out how nStandardFaction feels about oCreature. - nStandardFaction: STANDARD_FACTION_*
        //     - oCreature Returns -1 on an error. Returns 0-100 based on the standing of oCreature
        //     within the faction nStandardFaction. 0-10 : Hostile. 11-89 : Neutral. 90-100
        //     : Friendly.
        public static int GetStandardFactionReputation(StandardFaction standardFaction, NWCreature? creature = null)
            => Core.NWScript.GetStandardFactionReputation((int)standardFaction, creature ?? NWObject.OBJECT_SELF);

        //     Get the starting location of the module.
        public static Location GetStartingLocation()
            => Core.NWScript.GetStartingLocation();

        //     Returns the stealth mode of the specified creature. - oCreature * Returns a constant
        //     STEALTH_MODE_*
        public static StealthMode GetStealthMode(NWCreature creature)
            => (StealthMode)Core.NWScript.GetStealthMode(creature);

        //     returns TRUE if the item is stolen
        public static bool GetStolenFlag(NWItem stolen)
            => Core.NWScript.GetStolenFlag(stolen) == 1;

        //     Returns the amount of gold a store currently has. -1 indicates it is not using
        //     gold. -2 indicates the store could not be located.
        public static int GetStoreGold(NWObject store)
            => Core.NWScript.GetStoreGold(store);

        //     Gets the amount a store charges for identifying an item. Default is 100. -1 means
        //     the store will not identify items. -2 indicates the store could not be located.
        public static int GetStoreIdentifyCost(NWObject store)
            => Core.NWScript.GetStoreIdentifyCost(store);

        //     Gets the maximum amount a store will pay for any item. -1 means price unlimited.
        //     -2 indicates the store could not be located.
        public static int GetStoreMaxBuyPrice(NWObject store)
            => Core.NWScript.GetStoreMaxBuyPrice(store);

        //     Get a string from the talk table using nStrRef.
        public static string GetStringByStrRef(int strRef, Gender gender = Gender.Male)
            => Core.NWScript.GetStringByStrRef(strRef, (int)gender);

        //     Get nCounter characters from the left end of sString * Return value on error:
        //     ""
        public static string GetStringLeft(string str, int count)
            => Core.NWScript.GetStringLeft(str, count);

        //     Get the length of sString * Return value on error: -1
        public static int GetStringLength(string str)
            => Core.NWScript.GetStringLength(str);

        //     Convert sString into lower case * Return value on error: ""
        public static string GetStringLowerCase(string str)
            => Core.NWScript.GetStringLowerCase(str);

        //     Get nCount characters from the right end of sString * Return value on error:
        //     ""
        public static string GetStringRight(string str, int count)
            => Core.NWScript.GetStringRight(str, count);

        //     Convert sString into upper case * Return value on error: ""
        public static string GetStringUpperCase(string str)
            => Core.NWScript.GetStringUpperCase(str);

        //     Get the duration (in seconds) of the sound attached to nStrRef * Returns 0.0f
        //     if no duration is stored or if no sound is attached
        public static float GetStrRefSoundDuration(int strRef)
            => Core.NWScript.GetStrRefSoundDuration(strRef);

        //     Get the name of oCreature's sub race. * Returns "" if oCreature is invalid (or
        //     if sub race is blank for oCreature).
        public static string GetSubRace(NWObject target)
            => Core.NWScript.GetSubRace(target);

        //     Get nCount characters from sString, starting at nStart * Return value on error:
        //     ""
        public static string GetSubString(string str, int start, int count)
            => Core.NWScript.GetSubString(str, start, count);

        //     Get the surface material at the given location. (This is equivalent to the walkmesh
        //     type). Returns 0 if the location is invalid or has no surface type.
        public static int GetSurfaceMaterial(Location at)
            => Core.NWScript.GetSurfaceMaterial(at);

        //     Get the Tag of oObject * Return value if oObject is not a valid object: ""
        public static string GetTag(NWObject obj)
            => Core.NWScript.GetTag(obj);

        //     Returns whether the given tile at x, y, for the given creature in the stated
        //     area is visible on the map. Note that creature needs to be a player- or player-possessed
        //     creature. Keep in mind that tile exploration also controls object visibility
        //     in areas and the fog of war for interior and underground areas. Return values:
        //     -1: Area or creature invalid. 0: Tile is not explored yet. 1: Tile is explored.
        public enum TileExplored { AreaInvalid = -1, NotExplored = 0, Explored = 1 }
        public static TileExplored GetTileExplored(NWCreature creature, NWArea area, int x, int y)
            => (TileExplored)Core.NWScript.GetTileExplored(creature, area, x, y);

        //     Get the color (TILE_MAIN_LIGHT_COLOR_*) for the main light 1 of the tile at lTile.
        //     - lTile: the vector part of this is the tile grid (x,y) coordinate of the tile.
        public static TileMainLightColor GetTileMainLight1Color(Location tile)
            => (TileMainLightColor)Core.NWScript.GetTileMainLight1Color(tile);

        //     Get the color (TILE_MAIN_LIGHT_COLOR_*) for the main light 2 of the tile at lTile.
        //     - lTile: the vector part of this is the tile grid (x,y) coordinate of the tile.
        public static TileMainLightColor GetTileMainLight2Color(Location tile)
            => (TileMainLightColor)Core.NWScript.GetTileMainLight2Color(tile);

        //     returns the resref (TILESET_RESREF_*) of the tileset used to create area oArea.
        //     TILESET_RESREF_BEHOLDER_CAVES TILESET_RESREF_CASTLE_INTERIOR TILESET_RESREF_CITY_EXTERIOR
        //     TILESET_RESREF_CITY_INTERIOR TILESET_RESREF_CRYPT TILESET_RESREF_DESERT TILESET_RESREF_DROW_INTERIOR
        //     TILESET_RESREF_DUNGEON TILESET_RESREF_FOREST TILESET_RESREF_FROZEN_WASTES TILESET_RESREF_ILLITHID_INTERIOR
        //     TILESET_RESREF_MICROSET TILESET_RESREF_MINES_AND_CAVERNS TILESET_RESREF_RUINS
        //     TILESET_RESREF_RURAL TILESET_RESREF_RURAL_WINTER TILESET_RESREF_SEWERS TILESET_RESREF_UNDERDARK
        //     * returns an empty string on an error.
        public static string GetTilesetResRef(NWArea area)
            => Core.NWScript.GetTilesetResRef(area);
        //
        // Summary:
        //     Get the color (TILE_SOURCE_LIGHT_COLOR_*) for the source light 1 of the tile
        //     at lTile. - lTile: the vector part of this is the tile grid (x,y) coordinate
        //     of the tile.
        public static TileSourceLightColor GetTileSourceLight1Color(Location tile)
            => (TileSourceLightColor)Core.NWScript.GetTileSourceLight1Color(tile);

        //     Get the color (TILE_SOURCE_LIGHT_COLOR_*) for the source light 2 of the tile
        //     at lTile. - lTile: the vector part of this is the tile grid (x,y) coordinate
        //     of the tile.
        public static TileSourceLightColor GetTileSourceLight2Color(Location tile)
            => (TileSourceLightColor)Core.NWScript.GetTileSourceLight2Color(tile);

        //     Get the current hour.
        public static int GetTimeHour()
            => Core.NWScript.GetTimeHour();

        //     Get the current millisecond
        public static int GetTimeMillisecond()
            => Core.NWScript.GetTimeMillisecond();

        //     Get the current minute
        public static int GetTimeMinute()
            => Core.NWScript.GetTimeMinute();

        //     Get the current second
        public static int GetTimeSecond()
            => Core.NWScript.GetTimeSecond();

        //     Get the total amount of damage that has been dealt to the caller.
        public static int GetTotalDamageDealt()
            => Core.NWScript.GetTotalDamageDealt();

        //     Get the destination object for the given object. All objects can hold a transition
        //     target, but only Doors and Triggers will be made clickable by the game engine
        //     (This may change in the future). You can set and query transition targets on
        //     other objects for your own scripted purposes. * Returns OBJECT_INVALID if oTransition
        //     does not hold a target.
        public static NWObject GetTransitionTarget(NWObject transition)
            => new NWObject(Core.NWScript.GetTransitionTarget(transition));
        //
        // Summary:
        //     - oTrapObject: a placeable, door or trigger * Returns TRUE if oTrapObject is
        //     active
        public static bool GetTrapActive(NWStationary trapObject)
            => Core.NWScript.GetTrapActive(trapObject) == 1;

        //     Get the trap base type (TRAP_BASE_TYPE_*) of oTrapObject. - oTrapObject: a placeable,
        //     door or trigger
        public static TrapBaseType GetTrapBaseType(NWTrappable trapObject)
            => (TrapBaseType)Core.NWScript.GetTrapBaseType(trapObject);

        //     Get the creator of oTrapObject, the creature that set the trap. - oTrapObject:
        //     a placeable, door or trigger * Returns OBJECT_INVALID if oTrapObject was created
        //     in the toolset.
        public static NWCreature GetTrapCreator(NWStationary trapObject)
            => new NWCreature(Core.NWScript.GetTrapCreator(trapObject));

        //     - oTrapObject: a placeable, door or trigger * Returns TRUE if oTrapObject is
        //     detectable.
        public static bool GetTrapDetectable(NWStationary trapObject)
            => Core.NWScript.GetTrapDetectable(trapObject) == 1;

        //     Get the DC for detecting oTrapObject. - oTrapObject: a placeable, door or trigger
        public static int GetTrapDetectDC(NWStationary trapObject)
            => Core.NWScript.GetTrapDetectDC(trapObject);

        //     - oTrapObject: a placeable, door or trigger - oCreature * Returns TRUE if oCreature
        //     has detected oTrapObject
        public static bool GetTrapDetectedBy(NWStationary trapObject, NWCreature creature)
            => Core.NWScript.GetTrapDetectedBy(trapObject, creature) == 1;

        //     - oTrapObject: a placeable, door or trigger * Returns TRUE if oTrapObject is
        //     disarmable.
        public static bool GetTrapDisarmable(NWStationary trapObject)
            => Core.NWScript.GetTrapDisarmable(trapObject) == 1;
        //
        // Summary:
        //     Get the DC for disarming oTrapObject. - oTrapObject: a placeable, door or trigger
        public static int GetTrapDisarmDC(NWStationary trapObject)
            => Core.NWScript.GetTrapDisarmDC(trapObject);

        //     - oTrapObject: a placeable, door or trigger * Returns TRUE if oTrapObject has
        //     been flagged as visible to all creatures.
        public static bool GetTrapFlagged(NWStationary trapObject)
            => Core.NWScript.GetTrapFlagged(trapObject) == 1;

        //     Get the tag of the key that will disarm oTrapObject. - oTrapObject: a placeable,
        //     door or trigger
        public static string GetTrapKeyTag(NWStationary trapObject)
            => Core.NWScript.GetTrapKeyTag(trapObject);

        //     - oTrapObject: a placeable, door or trigger * Returns TRUE if oTrapObject is
        //     one-shot (i.e. it does not reset itself after firing.
        public static bool GetTrapOneShot(NWStationary trapObject)
            => Core.NWScript.GetTrapOneShot(trapObject) == 1;

        //     - oTrapObject: a placeable, door or trigger * Returns TRUE if oTrapObject can
        //     be recovered.
        public static bool GetTrapRecoverable(NWStationary trapObject)
            => Core.NWScript.GetTrapRecoverable(trapObject) == 1;

        //     Get the number of Hitdice worth of Turn Resistance that oUndead may have. This
        //     will only work on undead creatures.
        public static int GetTurnResistanceHD(NWCreature? undead = null)
            => Core.NWScript.GetTurnResistanceHD(undead ?? NWObject.OBJECT_SELF);

        //     Get the type (TALENT_TYPE_*) of tTalent.
        public static TalentType GetTypeFromTalent(Talent talent)
            => (TalentType)Core.NWScript.GetTypeFromTalent(talent);

        //     returns TRUE if the placeable object is usable
        public static bool GetUseableFlag(NWObject? obj = null)
            => Core.NWScript.GetUseableFlag(obj ?? NWObject.OBJECT_SELF) == 1;

        //     This is for use in a user-defined script, it gets the event number.
        public static int GetUserDefinedEventNumber()
            => Core.NWScript.GetUserDefinedEventNumber();

        //     Get the first waypoint with the specified tag. * Returns OBJECT_INVALID if the
        //     waypoint cannot be found.
        public static NWObject GetWaypointByTag(string waypointTag)
            => new NWObject(Core.NWScript.GetWaypointByTag(waypointTag));

        //     * Returns TRUE if oItem is a ranged weapon.
        public static bool GetWeaponRanged(NWItem item)
            => Core.NWScript.GetWeaponRanged(item) == 1;

        //     Gets the current weather conditions for the area oArea. Returns: WEATHER_CLEAR,
        //     WEATHER_RAIN, WEATHER_SNOW, WEATHER_INVALID Note: If called on an Interior area,
        //     this will always return WEATHER_CLEAR.
        public static Weather GetWeather(NWArea area)
            => (Weather)Core.NWScript.GetWeather(area);

        //     Gets the weight of an item, or the total carried weight of a creature in tenths
        //     of pounds (as per the baseitems.2da). - oTarget: the item or creature for which
        //     the weight is needed
        public static int GetWeight(NWObject? target = null)
            => Core.NWScript.GetWeight(target ?? NWObject.OBJECT_SELF);

        //     Get oTarget's base will saving throw value (this will only work for creatures,
        //     doors, and placeables). * Returns 0 if oTarget is invalid.
        public static int GetWillSavingThrow(NWObject target)
            => Core.NWScript.GetWillSavingThrow(target);

        //     Get oCreature's experience.
        public static int GetXP(NWCreature creature)
            => Core.NWScript.GetXP(creature);

        //     Give nGP gold to oCreature.
        public static void GiveGoldToCreature(NWCreature creature, int gp)
            => Core.NWScript.GiveGoldToCreature(creature, gp);

        //     Gives nXpAmount to oCreature.
        public static void GiveXPToCreature(NWCreature creature, int amount)
            => Core.NWScript.GiveXPToCreature(creature, amount);
        //
        // Summary:
        //     Convert nHours into a number of seconds The result will depend on how many minutes
        //     there are per hour (game-time)
        public static float HoursToSeconds(int hours)
            => Core.NWScript.HoursToSeconds(hours);

        //     Increment the remaining uses per day for this creature by one. Total number of
        //     feats per day can not exceed the maximum. - oCreature: creature to modify - nFeat:
        //     constant FEAT_*
        public static void IncrementRemainingFeatUses(NWCreature creature, Feat feat)
            => Core.NWScript.IncrementRemainingFeatUses(creature, (int)feat);

        //     Insert sString into sDestination at nPosition * Return value on error: ""
        public static string InsertString(string destination, string str, int pos)
            => Core.NWScript.InsertString(destination, str, pos);

        //     Convert nInteger into a floating point number.
        public static float IntToFloat(int source)
            => Core.NWScript.IntToFloat(source);

        //     Convert nInteger to hex, returning the hex value as a string. * Return value
        //     has the format "0x????????" where each ? will be a hex digit (8 digits in total).
        public static string IntToHexString(int source)
            => Core.NWScript.IntToHexString(source);

        //     Convert nInteger into a string. * Return value on error: ""
        public static string IntToString(int source)
            => Core.NWScript.IntToString(source);

        //     Determine whether oObject is in conversation.
        public static bool IsInConversation(NWObject obj)
            => Core.NWScript.IsInConversation(obj) == 1;

        //     Returns Item property ability bonus. You need to specify an ability constant(IP_CONST_ABILITY_*)
        //     and the bonus. The bonus should be a positive integer between 1 and 12.
        public static ItemProperty ItemPropertyAbilityBonus(IPConstAbility ability, int bonus)
            => Core.NWScript.ItemPropertyAbilityBonus((int)ability, bonus);

        //     Returns Item property AC bonus. You need to specify the bonus. The bonus should
        //     be a positive integer between 1 and 20. The modifier type depends on the item
        //     it is being applied to.
        public static ItemProperty ItemPropertyACBonus(int bonus)
            => Core.NWScript.ItemPropertyACBonus(bonus);
        //
        // Summary:
        //     Returns Item property AC bonus vs. alignment group. An example of an alignment
        //     group is Chaotic, or Good. You need to specify the alignment group constant(IP_CONST_ALIGNMENTGROUP_*)
        //     and the AC bonus. The AC bonus should be an integer between 1 and 20. The modifier
        //     type depends on the item it is being applied to.
        public static ItemProperty ItemPropertyACBonusVsAlign(IPConstAlignmentGroup alignGroup, int acBonus)
            => Core.NWScript.ItemPropertyACBonusVsAlign((int)alignGroup, acBonus);

        //     Returns Item property AC bonus vs. Damage type (ie. piercing). You need to specify
        //     the damage type constant(IP_CONST_DAMAGETYPE_*) and the AC bonus. The AC bonus
        //     should be an integer between 1 and 20. The modifier type depends on the item
        //     it is being applied to. NOTE: Only the first 3 damage types may be used here,
        //     the 3 basic physical types.
        public static ItemProperty ItemPropertyACBonusVsDmgType(IPConstDamageType damageType, int acBonus)
            => Core.NWScript.ItemPropertyACBonusVsDmgType((int)damageType, acBonus);

        //     Returns Item property AC bonus vs. Racial group. You need to specify the racial
        //     group constant(IP_CONST_RACIALTYPE_*) and the AC bonus. The AC bonus should be
        //     an integer between 1 and 20. The modifier type depends on the item it is being
        //     applied to.
        public static ItemProperty ItemPropertyACBonusVsRace(IPConstRacialType race, int acBonus)
            => Core.NWScript.ItemPropertyACBonusVsRace((int)race, acBonus);

        //     Returns Item property AC bonus vs. Specific alignment. You need to specify the
        //     specific alignment constant(IP_CONST_ALIGNMENT_*) and the AC bonus. The AC bonus
        //     should be an integer between 1 and 20. The modifier type depends on the item
        //     it is being applied to.
        public static ItemProperty ItemPropertyACBonusVsSAlign(IPConstAlignment align, int acBonus)
            => Core.NWScript.ItemPropertyACBonusVsSAlign((int)align, acBonus);

        //     Returns a generic Additional Item property. You need to specify the Additional
        //     property. - nProperty: The item property to create (see iprp_addcost.2da). IP_CONST_ADDITIONAL_*
        //     Note: The additional property only affects the cost of the item if you modify
        //     the cost in the iprp_addcost.2da.
        public static ItemProperty ItemPropertyAdditional(IPConstAdditional additionalProperty)
            => Core.NWScript.ItemPropertyAdditional((int)additionalProperty);

        //     Creates an item property that offsets the effect on arcane spell failure that
        //     a particular item has. Parameters come from the ITEM_PROP_ASF_* group.
        public static ItemProperty ItemPropertyArcaneSpellFailure(IPConstArcaneSpellFailure asf)
            => Core.NWScript.ItemPropertyArcaneSpellFailure((int)asf);

        //     Returns Item property Attack bonus. You must specify an attack bonus. The bonus
        //     must be an integer between 1 and 20.
        public static ItemProperty ItemPropertyAttackBonus(int bonus)
            => Core.NWScript.ItemPropertyAttackBonus(bonus);

        //     Returns Item property Attack bonus vs. alignment group. You must specify the
        //     alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the attack bonus. The
        //     bonus must be an integer between 1 and 20.
        public static ItemProperty ItemPropertyAttackBonusVsAlign(IPConstAlignmentGroup alignGroup, int bonus)
            => Core.NWScript.ItemPropertyAttackBonusVsAlign((int)alignGroup, bonus);

        //     Returns Item property attack bonus vs. racial group. You must specify the racial
        //     group constant(IP_CONST_RACIALTYPE_*) and the attack bonus. The bonus must be
        //     an integer between 1 and 20.
        public static ItemProperty ItemPropertyAttackBonusVsRace(RacialType race, int bonus)
            => Core.NWScript.ItemPropertyAttackBonusVsRace((int)race, bonus);

        //     Returns Item property attack bonus vs. a specific alignment. You must specify
        //     the alignment you want the bonus to work against(IP_CONST_ALIGNMENT_*) and the
        //     attack bonus. The bonus must be an integer between 1 and 20.
        public static ItemProperty ItemPropertyAttackBonusVsSAlign(IPConstAlignment alignment, int bonus)
            => Core.NWScript.ItemPropertyAttackBonusVsSAlign((int)alignment, bonus);

        //     Returns Item property attack penalty. You must specify the attack penalty. The
        //     penalty must be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
        public static ItemProperty ItemPropertyAttackPenalty(int penalty)
            => Core.NWScript.ItemPropertyAttackPenalty(penalty);

        //     Returns Item property Bonus Feat. You need to specify the the feat constant(IP_CONST_FEAT_*).
        public static ItemProperty ItemPropertyBonusFeat(IPConstFeat feat)
            => Core.NWScript.ItemPropertyBonusFeat((int)feat);

        //     Returns Item property Bonus level spell (Bonus spell of level). You must specify
        //     the class constant(IP_CONST_CLASS_*) of the bonus spell(MUST BE a spell casting
        //     class) and the level of the bonus spell. The level of the bonus spell should
        //     be an integer between 0 and 9.
        public static ItemProperty ItemPropertyBonusLevelSpell(IPConstClass classType, int spellLevel)
            => Core.NWScript.ItemPropertyBonusLevelSpell((int)classType, spellLevel);

        //     Returns Item property saving throw bonus to the base type (ie. will, reflex,
        //     fortitude). You must specify the base type constant(IP_CONST_SAVEBASETYPE_*)
        //     to which the user gets the bonus and the bonus that he/she will get. The bonus
        //     must be an integer between 1 and 20.
        public static ItemProperty ItemPropertyBonusSavingThrow(IPConstSaveBaseType baseSaveType, int bonus)
            => Core.NWScript.ItemPropertyBonusSavingThrow((int)baseSaveType, bonus);

        //     Returns Item property saving throw bonus vs. a specific effect or damage type.
        //     You must specify the save type constant(IP_CONST_SAVEVS_*) that the bonus is
        //     applied to and the bonus that is be applied. The bonus must be an integer between
        //     1 and 20.
        public static ItemProperty ItemPropertyBonusSavingThrowVsX(IPConstSaveVs bonusType, int bonus)
            => Core.NWScript.ItemPropertyBonusSavingThrowVsX((int)bonusType, bonus);

        //     Returns Item property bonus spell resistance. You must specify the bonus spell
        //     resistance constant(IP_CONST_SPELLRESISTANCEBONUS_*).
        public static ItemProperty ItemPropertyBonusSpellResistance(IPConstSpellResistanceBonus bonus)
            => Core.NWScript.ItemPropertyBonusSpellResistance((int)bonus);
        //
        // Summary:
        //     Returns Item property Cast spell. You must specify the spell constant (IP_CONST_CASTSPELL_*)
        //     and the number of uses constant(IP_CONST_CASTSPELL_NUMUSES_*). NOTE: The number
        //     after the name of the spell in the constant is the level at which the spell will
        //     be cast. Sometimes there are multiple copies of the same spell but they each
        //     are cast at a different level. The higher the level, the more cost will be added
        //     to the item. NOTE: The list of spells that can be applied to an item will depend
        //     on the item type. For instance there are spells that can be applied to a wand
        //     that cannot be applied to a potion. Below is a list of the types and the spells
        //     that are allowed to be placed on them. If you try to put a cast spell effect
        //     on an item that is not allowed to have that effect it will not work. NOTE: Even
        //     if spells have multiple versions of different levels they are only listed below
        //     once. WANDS: Acid_Splash Activate_Item Aid Amplify Animate_Dead AuraOfGlory BalagarnsIronHorn
        //     Bane Banishment Barkskin Bestow_Curse Bigbys_Clenched_Fist Bigbys_Crushing_Hand
        //     Bigbys_Forceful_Hand Bigbys_Grasping_Hand Bigbys_Interposing_Hand Bless Bless_Weapon
        //     Blindness/Deafness Blood_Frenzy Bombardment Bulls_Strength Burning_Hands Call_Lightning
        //     Camoflage Cats_Grace Charm_Monster Charm_Person Charm_Person_or_Animal Clairaudience/Clairvoyance
        //     Clarity Color_Spray Confusion Continual_Flame Cure_Critical_Wounds Cure_Light_Wounds
        //     Cure_Minor_Wounds Cure_Moderate_Wounds Cure_Serious_Wounds Darkness Darkvision
        //     Daze Death_Ward Dirge Dismissal Dispel_Magic Displacement Divine_Favor Divine_Might
        //     Divine_Power Divine_Shield Dominate_Animal Dominate_Person Doom Dragon_Breath_Acid
        //     Dragon_Breath_Cold Dragon_Breath_Fear Dragon_Breath_Fire Dragon_Breath_Gas Dragon_Breath_Lightning
        //     Dragon_Breath_Paralyze Dragon_Breath_Sleep Dragon_Breath_Slow Dragon_Breath_Weaken
        //     Drown Eagle_Spledor Earthquake Electric_Jolt Elemental_Shield Endurance Endure_Elements
        //     Enervation Entangle Entropic_Shield Etherealness Expeditious_Retreat Fear Find_Traps
        //     Fireball Firebrand Flame_Arrow Flame_Lash Flame_Strike Flare Foxs_Cunning Freedom_of_Movement
        //     Ghostly_Visage Ghoul_Touch Grease Greater_Magic_Fang Greater_Magic_Weapon Grenade_Acid
        //     Grenade_Caltrops Grenade_Chicken Grenade_Choking Grenade_Fire Grenade_Holy Grenade_Tangle
        //     Grenade_Thunderstone Gust_of_wind Hammer_of_the_Gods Haste Hold_Animal Hold_Monster
        //     Hold_Person Ice_Storm Identify Improved_Invisibility Inferno Inflict_Critical_Wounds
        //     Inflict_Light_Wounds Inflict_Minor_Wounds Inflict_Moderate_Wounds Inflict_Serious_Wounds
        //     Invisibility Invisibility_Purge Invisibility_Sphere Isaacs_Greater_Missile_Storm
        //     Isaacs_Lesser_Missile_Storm Knock Lesser_Dispel Lesser_Restoration Lesser_Spell_Breach
        //     Light Lightning_Bolt Mage_Armor Magic_Circle_against_Alignment Magic_Fang Magic_Missile
        //     Manipulate_Portal_Stone Mass_Camoflage Melfs_Acid_Arrow Meteor_Swarm Mind_Blank
        //     Mind_Fog Negative_Energy_Burst Negative_Energy_Protection Negative_Energy_Ray
        //     Neutralize_Poison One_With_The_Land Owls_Insight Owls_Wisdom Phantasmal_Killer
        //     Planar_Ally Poison Polymorph_Self Prayer Protection_from_Alignment Protection_From_Elements
        //     Quillfire Ray_of_Enfeeblement Ray_of_Frost Remove_Blindness/Deafness Remove_Curse
        //     Remove_Disease Remove_Fear Remove_Paralysis Resist_Elements Resistance Restoration
        //     Sanctuary Scare Searing_Light See_Invisibility Shadow_Conjuration Shield Shield_of_Faith
        //     Silence Sleep Slow Sound_Burst Spike_Growth Stinking_Cloud Stoneskin Summon_Creature_I
        //     Summon_Creature_I Summon_Creature_II Summon_Creature_III Summon_Creature_IV Sunburst
        //     Tashas_Hideous_Laughter True_Strike Undeaths_Eternal_Foe Unique_Power Unique_Power_Self_Only
        //     Vampiric_Touch Virtue Wall_of_Fire Web Wounding_Whispers POTIONS: Activate_Item
        //     Aid Amplify AuraOfGlory Bane Barkskin Barkskin Barkskin Bless Bless_Weapon Bless_Weapon
        //     Blood_Frenzy Bulls_Strength Bulls_Strength Bulls_Strength Camoflage Cats_Grace
        //     Cats_Grace Cats_Grace Clairaudience/Clairvoyance Clairaudience/Clairvoyance Clairaudience/Clairvoyance
        //     Clarity Continual_Flame Cure_Critical_Wounds Cure_Critical_Wounds Cure_Critical_Wounds
        //     Cure_Light_Wounds Cure_Light_Wounds Cure_Minor_Wounds Cure_Moderate_Wounds Cure_Moderate_Wounds
        //     Cure_Moderate_Wounds Cure_Serious_Wounds Cure_Serious_Wounds Cure_Serious_Wounds
        //     Darkness Darkvision Darkvision Death_Ward Dispel_Magic Dispel_Magic Displacement
        //     Divine_Favor Divine_Might Divine_Power Divine_Shield Dragon_Breath_Acid Dragon_Breath_Cold
        //     Dragon_Breath_Fear Dragon_Breath_Fire Dragon_Breath_Gas Dragon_Breath_Lightning
        //     Dragon_Breath_Paralyze Dragon_Breath_Sleep Dragon_Breath_Slow Dragon_Breath_Weaken
        //     Eagle_Spledor Eagle_Spledor Eagle_Spledor Elemental_Shield Elemental_Shield Endurance
        //     Endurance Endurance Endure_Elements Entropic_Shield Ethereal_Visage Ethereal_Visage
        //     Etherealness Expeditious_Retreat Find_Traps Foxs_Cunning Foxs_Cunning Foxs_Cunning
        //     Freedom_of_Movement Ghostly_Visage Ghostly_Visage Ghostly_Visage Globe_of_Invulnerability
        //     Greater_Bulls_Strength Greater_Cats_Grace Greater_Dispelling Greater_Dispelling
        //     Greater_Eagles_Splendor Greater_Endurance Greater_Foxs_Cunning Greater_Magic_Weapon
        //     Greater_Owls_Wisdom Greater_Restoration Greater_Spell_Mantle Greater_Stoneskin
        //     Grenade_Acid Grenade_Caltrops Grenade_Chicken Grenade_Choking Grenade_Fire Grenade_Holy
        //     Grenade_Tangle Grenade_Thunderstone Haste Haste Heal Hold_Animal Hold_Monster
        //     Hold_Person Identify Invisibility Lesser_Dispel Lesser_Dispel Lesser_Mind_Blank
        //     Lesser_Restoration Lesser_Spell_Mantle Light Light Mage_Armor Manipulate_Portal_Stone
        //     Mass_Camoflage Mind_Blank Minor_Globe_of_Invulnerability Minor_Globe_of_Invulnerability
        //     Mordenkainens_Disjunction Negative_Energy_Protection Negative_Energy_Protection
        //     Negative_Energy_Protection Neutralize_Poison One_With_The_Land Owls_Insight Owls_Wisdom
        //     Owls_Wisdom Owls_Wisdom Polymorph_Self Prayer Premonition Protection_From_Elements
        //     Protection_From_Elements Protection_from_Spells Protection_from_Spells Raise_Dead
        //     Remove_Blindness/Deafness Remove_Curse Remove_Disease Remove_Fear Remove_Paralysis
        //     Resist_Elements Resist_Elements Resistance Resistance Restoration Resurrection
        //     Rogues_Cunning See_Invisibility Shadow_Shield Shapechange Shield Shield_of_Faith
        //     Special_Alcohol_Beer Special_Alcohol_Spirits Special_Alcohol_Wine Special_Herb_Belladonna
        //     Special_Herb_Garlic Spell_Mantle Spell_Resistance Spell_Resistance Stoneskin
        //     Tensers_Transformation True_Seeing True_Strike Unique_Power Unique_Power_Self_Only
        //     Virtue GENERAL USE (ie. everything else): Just about every spell is useable by
        //     all the general use items so instead we will only list the ones that are not
        //     allowed: Special_Alcohol_Beer Special_Alcohol_Spirits Special_Alcohol_Wine
        public static ItemProperty ItemPropertyCastSpell(IPConstCastSpell spell, IPConstCastSpellNumUses numUses)
            => Core.NWScript.ItemPropertyCastSpell((int)spell, (int)numUses);

        //     Returns Item property container reduced weight. This is used for special containers
        //     that reduce the weight of the objects inside them. You must specify the container
        //     weight reduction type constant(IP_CONST_CONTAINERWEIGHTRED_*).
        public static ItemProperty ItemPropertyContainerReducedWeight(IPConstContainerWeightReduction containerType)
            => Core.NWScript.ItemPropertyContainerReducedWeight((int)containerType);

        //     Returns Item property damage bonus. You must specify the damage type constant
        //     (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        //     NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        //     Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        public static ItemProperty ItemPropertyDamageBonus(IPConstDamageType damageType, IPConstDamageBonus damage)
            => Core.NWScript.ItemPropertyDamageBonus((int)damageType, (int)damage);

        //     Returns Item property damage bonus vs. Alignment groups. You must specify the
        //     alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the damage type constant
        //     (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        //     NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        //     Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        public static ItemProperty ItemPropertyDamageBonusVsAlign(IPConstAlignmentGroup alignGroup, IPConstDamageType damageType, IPConstDamageBonus damage)
            => Core.NWScript.ItemPropertyDamageBonusVsAlign((int)alignGroup, (int)damageType, (int)damage);

        //     Returns Item property damage bonus vs. specific race. You must specify the racial
        //     group constant(IP_CONST_RACIALTYPE_*) and the damage type constant (IP_CONST_DAMAGETYPE_*)
        //     and the amount of damage constant(IP_CONST_DAMAGEBONUS_*). NOTE: not all the
        //     damage types will work, use only the following: Acid, Bludgeoning, Cold, Electrical,
        //     Fire, Piercing, Slashing, Sonic.
        public static ItemProperty ItemPropertyDamageBonusVsRace(IPConstRacialType race, IPConstDamageType damageType, IPConstDamageBonus damage)
            => Core.NWScript.ItemPropertyDamageBonusVsRace((int)race, (int)damageType, (int)damage);

        //     Returns Item property damage bonus vs. specific alignment. You must specify the
        //     specific alignment constant(IP_CONST_ALIGNMENT_*) and the damage type constant
        //     (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).
        //     NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,
        //     Cold, Electrical, Fire, Piercing, Slashing, Sonic.
        public static ItemProperty ItemPropertyDamageBonusVsSAlign(IPConstAlignment align, IPConstDamageType damageType, IPConstDamageBonus damage)
            => Core.NWScript.ItemPropertyDamageBonusVsSAlign((int)align, (int)damageType, (int)damage);

        //     Returns Item property damage immunity. You must specify the damage type constant
        //     (IP_CONST_DAMAGETYPE_*) that you want to be immune to and the immune bonus percentage
        //     constant(IP_CONST_DAMAGEIMMUNITY_*). NOTE: not all the damage types will work,
        //     use only the following: Acid, Bludgeoning, Cold, Electrical, Fire, Piercing,
        //     Slashing, Sonic.
        public static ItemProperty ItemPropertyDamageImmunity(IPConstDamageType damageType, IPConstDamageImmunity immuneBonus)
            => Core.NWScript.ItemPropertyDamageImmunity((int)damageType, (int)immuneBonus);

        //     Returns Item property damage penalty. You must specify the damage penalty. The
        //     damage penalty should be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
        public static ItemProperty ItemPropertyDamagePenalty(int penalty)
            => Core.NWScript.ItemPropertyDamagePenalty(penalty);

        //     Returns Item property damage reduction. You must specify the enhancment level
        //     (IP_CONST_DAMAGEREDUCTION_*) that is required to get past the damage reduction
        //     and the amount of HP of damage constant(IP_CONST_DAMAGESOAK_*) will be soaked
        //     up if your weapon is not of high enough enhancement.
        public static ItemProperty ItemPropertyDamageReduction(IPConstDamageReduction enhancement, IPConstDamageSoak damageSoak)
            => Core.NWScript.ItemPropertyDamageReduction((int)enhancement, (int)damageSoak);

        //     Returns Item property damage resistance. You must specify the damage type constant(IP_CONST_DAMAGETYPE_*)
        //     and the amount of HP of damage constant (IP_CONST_DAMAGERESIST_*) that will be
        //     resisted against each round.
        public static ItemProperty ItemPropertyDamageResistance(IPConstDamageType damageType, IPConstDamageResist hpResist)
            => Core.NWScript.ItemPropertyDamageResistance((int)damageType, (int)hpResist);
        //
        // Summary:
        //     Returns Item property damage vulnerability. You must specify the damage type
        //     constant(IP_CONST_DAMAGETYPE_*) that you want the user to be extra vulnerable
        //     to and the percentage vulnerability constant(IP_CONST_DAMAGEVULNERABILITY_*).
        public static ItemProperty ItemPropertyDamageVulnerability(IPConstDamageType damageType, IPConstDamageVulnerability vulnerability)
            => Core.NWScript.ItemPropertyDamageVulnerability((int)damageType, (int)vulnerability);
        //
        // Summary:
        //     Return Item property Darkvision.
        public static ItemProperty ItemPropertyDarkvision()
            => Core.NWScript.ItemPropertyDarkvision();

        //     Return Item property decrease ability score. You must specify the ability constant(IP_CONST_ABILITY_*)
        //     and the modifier constant. The modifier must be a POSITIVE integer between 1
        //     and 10 (ie. 1 = -1).
        public static ItemProperty ItemPropertyDecreaseAbility(IPConstAbility ability, int modifier)
            => Core.NWScript.ItemPropertyDecreaseAbility((int)ability, modifier);

        //     Returns Item property decrease Armor Class. You must specify the armor modifier
        //     type constant(IP_CONST_ACMODIFIERTYPE_*) and the armor class penalty. The penalty
        //     must be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
        public static ItemProperty ItemPropertyDecreaseAC(IPConstACModifierType modifierType, int penalty)
            => Core.NWScript.ItemPropertyDecreaseAC((int)modifierType, penalty);

        //     Returns Item property decrease skill. You must specify the constant for the skill
        //     to be decreased(SKILL_*) and the amount of the penalty. The penalty must be a
        //     POSITIVE integer between 1 and 10 (ie. 1 = -1).
        public static ItemProperty ItemPropertyDecreaseSkill(Skill skill, int penalty)
            => Core.NWScript.ItemPropertyDecreaseSkill((int)skill, penalty);

        //     Returns Item property Enhancement bonus. You need to specify the enhancement
        //     bonus. The Enhancement bonus should be an integer between 1 and 20.
        public static ItemProperty ItemPropertyEnhancementBonus(int enhancementBonus)
            => Core.NWScript.ItemPropertyEnhancementBonus(enhancementBonus);

        //     Returns Item property Enhancement bonus vs. an Alignment group. You need to specify
        //     the alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the enhancement bonus.
        //     The Enhancement bonus should be an integer between 1 and 20.
        public static ItemProperty ItemPropertyEnhancementBonusVsAlign(IPConstAlignmentGroup alignGroup, int bonus)
            => Core.NWScript.ItemPropertyEnhancementBonusVsAlign((int)alignGroup, bonus);

        //     Returns Item property Enhancement bonus vs. Racial group. You need to specify
        //     the racial group constant(IP_CONST_RACIALTYPE_*) and the enhancement bonus. The
        //     enhancement bonus should be an integer between 1 and 20.
        public static ItemProperty ItemPropertyEnhancementBonusVsRace(IPConstRacialType race, int bonus)
            => Core.NWScript.ItemPropertyEnhancementBonusVsRace((int)race, bonus);

        //     Returns Item property Enhancement bonus vs. a specific alignment. You need to
        //     specify the alignment constant(IP_CONST_ALIGNMENT_*) and the enhancement bonus.
        //     The enhancement bonus should be an integer between 1 and 20.
        public static ItemProperty ItemPropertyEnhancementBonusVsSAlign(IPConstAlignment align, int bonus)
            => Core.NWScript.ItemPropertyEnhancementBonusVsSAlign((int)align, bonus);

        //     Returns Item property Enhancment penalty. You need to specify the enhancement
        //     penalty. The enhancement penalty should be a POSITIVE integer between 1 and 5
        //     (ie. 1 = -1).
        public static ItemProperty ItemPropertyEnhancementPenalty(int penalty)
            => Core.NWScript.ItemPropertyEnhancementPenalty(penalty);
        public static ItemProperty ItemPropertyExtraMeleeDamageType(DamageType damageType)
            => Core.NWScript.ItemPropertyExtraMeleeDamageType((int)damageType);
        public static ItemProperty ItemPropertyExtraRangeDamageType(int damageType)
            => Core.NWScript.ItemPropertyExtraRangeDamageType(damageType);

        //     Returns Item property free action.
        public static ItemProperty ItemPropertyFreeAction()
            => Core.NWScript.ItemPropertyFreeAction();
        //
        // Summary:
        //     Returns Item property haste.
        public static ItemProperty ItemPropertyHaste()
            => Core.NWScript.ItemPropertyHaste();
        //
        // Summary:
        //     Returns Item property healers kit. You must specify the level of the kit. The
        //     modifier must be an integer between 1 and 12.
        public static ItemProperty ItemPropertyHealersKit(int modifier)
            => Core.NWScript.ItemPropertyHealersKit(modifier);

        //     Returns Item property Holy Avenger.
        public static ItemProperty ItemPropertyHolyAvenger()
            => Core.NWScript.ItemPropertyHolyAvenger();

        //     Returns Item property immunity to miscellaneous effects. You must specify the
        //     effect to which the user is immune, it is a constant(IP_CONST_IMMUNITYMISC_*).
        public static ItemProperty ItemPropertyImmunityMisc(ImmunityType immunityType)
            => Core.NWScript.ItemPropertyImmunityMisc((int)immunityType);
        //
        // Summary:
        //     Returns Item property immunity to spell level. You must specify the level of
        //     which that and below the user will be immune. The level must be an integer between
        //     1 and 9. By putting in a 3 it will mean the user is immune to all 3rd level and
        //     lower spells.
        public static ItemProperty ItemPropertyImmunityToSpellLevel(int level)
            => Core.NWScript.ItemPropertyImmunityToSpellLevel(level);

        //     Returns Item property improved evasion.
        public static ItemProperty ItemPropertyImprovedEvasion()
            => Core.NWScript.ItemPropertyImprovedEvasion();

        //     Returns Item property keen. This means a critical threat range of 19-20 on a
        //     weapon will be increased to 17-20 etc.
        public static ItemProperty ItemPropertyKeen()
            => Core.NWScript.ItemPropertyKeen();

        //     Returns Item property light. You must specify the intesity constant of the light(IP_CONST_LIGHTBRIGHTNESS_*)
        //     and the color constant of the light (IP_CONST_LIGHTCOLOR_*).
        public static ItemProperty ItemPropertyLight(IPConstLightBrightness brightness, IPConstLightColor color)
            => Core.NWScript.ItemPropertyLight((int)brightness, (int)color);

        //     Returns Item property limit use by alignment group. You must specify the alignment
        //     group(s) that you want to be able to use this item(IP_CONST_ALIGNMENTGROUP_*).
        public static ItemProperty ItemPropertyLimitUseByAlign(IPConstAlignmentGroup alignGroup)
            => Core.NWScript.ItemPropertyLimitUseByAlign((int)alignGroup);

        //     Returns Item property limit use by class. You must specify the class(es) who
        //     are able to use this item(IP_CONST_CLASS_*).
        public static ItemProperty ItemPropertyLimitUseByClass(IPConstClass classType)
            => Core.NWScript.ItemPropertyLimitUseByClass((int)classType);

        //     Returns Item property limit use by race. You must specify the race(s) who are
        //     allowed to use this item(IP_CONST_RACIALTYPE_*).
        public static ItemProperty ItemPropertyLimitUseByRace(IPConstRacialType race)
            => Core.NWScript.ItemPropertyLimitUseByRace((int)race);

        //     Returns Item property limit use by specific alignment. You must specify the alignment(s)
        //     of those allowed to use the item(IP_CONST_ALIGNMENT_*).
        public static ItemProperty ItemPropertyLimitUseBySAlign(IPConstAlignment alignment)
            => Core.NWScript.ItemPropertyLimitUseBySAlign((int)alignment);

        //     Returns Item property Massive Critical. You must specify the extra damage constant(IP_CONST_DAMAGEBONUS_*)
        //     of the criticals.
        public static ItemProperty ItemPropertyMassiveCritical(IPConstDamageBonus damage)
            => Core.NWScript.ItemPropertyMassiveCritical((int)damage);

        //     Returns Item property Material. You need to specify the Material Type. - nMasterialType:
        //     The Material Type should be a positive integer between 0 and 77 (see iprp_matcost.2da).
        //     Note: The Material Type property will only affect the cost of the item if you
        //     modify the cost in the iprp_matcost.2da.
        public static ItemProperty ItemPropertyMaterial(int materialType)
            => Core.NWScript.ItemPropertyMaterial(materialType);

        //     Returns Item property Max range strength modification (ie. mighty). You must
        //     specify the maximum modifier for strength that is allowed on a ranged weapon.
        //     The modifier must be a positive integer between 1 and 20.
        public static ItemProperty ItemPropertyMaxRangeStrengthMod(int modifier)
            => Core.NWScript.ItemPropertyMaxRangeStrengthMod(modifier);

        //     Returns Item property monster damage. You must specify the amount of damage the
        //     monster's attack will do(IP_CONST_MONSTERDAMAGE_*). NOTE: These can only be applied
        //     to monster NATURAL weapons (ie. bite, claw, gore, and slam). IT WILL NOT WORK
        //     ON NORMAL WEAPONS.
        public static ItemProperty ItemPropertyMonsterDamage(int damage)
            => Core.NWScript.ItemPropertyMonsterDamage(damage);

        //     Returns Item property no damage. This means the weapon will do no damage in combat.
        public static ItemProperty ItemPropertyNoDamage()
            => Core.NWScript.ItemPropertyNoDamage();

        //     Creates an item property that (when applied to a weapon item) causes a spell
        //     to be cast when a successful strike is made, or (when applied to armor) is struck
        //     by an opponent. - nSpell uses the IP_CONST_ONHIT_CASTSPELL_* constants
        public static ItemProperty ItemPropertyOnHitCastSpell(IPConstOnHitCastSpell spell, int level)
            => Core.NWScript.ItemPropertyOnHitCastSpell((int)spell, level);

        //     Returns Item property on hit -> do effect property. You must specify the on hit
        //     property constant(IP_CONST_ONHIT_*) and the save DC constant(IP_CONST_ONHIT_SAVEDC_*).
        //     Some of the item properties require a special parameter as well. If the property
        //     does not require one you may leave out the last one. The list of the ones with
        //     3 parameters and what they are are as follows: ABILITYDRAIN :nSpecial is the
        //     ability it is to drain. constant(IP_CONST_ABILITY_*) BLINDNESS :nSpecial is the
        //     duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     CONFUSION :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     DAZE :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     DEAFNESS :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     DISEASE :nSpecial is the type of desease that will effect the victim. constant(DISEASE_*)
        //     DOOM :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     FEAR :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     HOLD :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     ITEMPOISON :nSpecial is the type of poison that will effect the victim. constant(IP_CONST_POISON_*)
        //     SILENCE :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     SLAYRACE :nSpecial is the race that will be slain. constant(IP_CONST_RACIALTYPE_*)
        //     SLAYALIGNMENTGROUP:nSpecial is the alignment group that will be slain(ie. chaotic).
        //     constant(IP_CONST_ALIGNMENTGROUP_*) SLAYALIGNMENT :nSpecial is the specific alignment
        //     that will be slain. constant(IP_CONST_ALIGNMENT_*) SLEEP :nSpecial is the duration/percentage
        //     of effecting victim. constant(IP_CONST_ONHIT_DURATION_*) SLOW :nSpecial is the
        //     duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        //     STUN :nSpecial is the duration/percentage of effecting victim. constant(IP_CONST_ONHIT_DURATION_*)
        public static ItemProperty ItemPropertyOnHitProps(IPConstOnHit property, IPConstOnHitSaveDC saveDC, int special = 0)
            => Core.NWScript.ItemPropertyOnHitProps((int)property, (int)saveDC, special);
        //
        // Summary:
        //     Returns Item property Monster on hit apply effect property. You must specify
        //     the property that you want applied on hit. There are some properties that require
        //     an additional special parameter to be specified. The others that don't require
        //     any additional parameter you may just put in the one. The special cases are as
        //     follows: ABILITYDRAIN:nSpecial is the ability to drain. constant(IP_CONST_ABILITY_*)
        //     DISEASE :nSpecial is the disease that you want applied. constant(DISEASE_*) LEVELDRAIN
        //     :nSpecial is the number of levels that you want drained. integer between 1 and
        //     5. POISON :nSpecial is the type of poison that will effect the victim. constant(IP_CONST_POISON_*)
        //     WOUNDING :nSpecial is the amount of wounding. integer between 1 and 5. NOTE:
        //     Any that do not appear in the above list do not require the second parameter.
        //     NOTE: These can only be applied to monster NATURAL weapons (ie. bite, claw, gore,
        //     and slam). IT WILL NOT WORK ON NORMAL WEAPONS.
        public static ItemProperty ItemPropertyOnMonsterHitProperties(IPConstOnMonsterHit property, int special = 0)
            => Core.NWScript.ItemPropertyOnMonsterHitProperties((int)property, special);

        //     Returns Item property Quality. You need to specify the Quality. - nQuality: The
        //     Quality of the item property to create (see iprp_qualcost.2da). IP_CONST_QUALITY_*
        //     Note: The quality property will only affect the cost of the item if you modify
        //     the cost in the iprp_qualcost.2da.
        public static ItemProperty ItemPropertyQuality(IPConstQuality quality)
            => Core.NWScript.ItemPropertyQuality((int)quality);

        //     Returns Item property reduced saving to base type. You must specify the base
        //     type to which the penalty applies (ie. will, reflex, or fortitude) and the penalty
        //     to be applied. The constant for the base type starts with (IP_CONST_SAVEBASETYPE_*).
        //     The penalty must be a POSITIVE integer between 1 and 20 (ie. 1 = -1).
        public static ItemProperty ItemPropertyReducedSavingThrow(IPConstSaveBaseType bonusType, int penalty)
            => Core.NWScript.ItemPropertyReducedSavingThrow((int)bonusType, penalty);

        //     Returns Item property reduced saving throw vs. an effect or damage type. You
        //     must specify the constant to which the penalty applies(IP_CONST_SAVEVS_*) and
        //     the penalty to be applied. The penalty must be a POSITIVE integer between 1 and
        //     20 (ie. 1 = -1).
        public static ItemProperty ItemPropertyReducedSavingThrowVsX(IPConstSaveVs baseSaveType, int penalty)
            => Core.NWScript.ItemPropertyReducedSavingThrowVsX((int)baseSaveType, penalty);

        //     Returns Item property regeneration. You must specify the regeneration amount.
        //     The amount must be an integer between 1 and 20.
        public static ItemProperty ItemPropertyRegeneration(int regenAmount)
            => Core.NWScript.ItemPropertyRegeneration(regenAmount);

        //     Returns Item property skill bonus. You must specify the skill to which the user
        //     will get a bonus(SKILL_*) and the amount of the bonus. The bonus amount must
        //     be an integer between 1 and 50.
        public static ItemProperty ItemPropertySkillBonus(Skill skill, int bonus)
            => Core.NWScript.ItemPropertySkillBonus((int)skill, bonus);

        //     Returns Item property special walk. If no parameters are specified it will automatically
        //     use the zombie walk. This will apply the special walk animation to the user.
        public static ItemProperty ItemPropertySpecialWalk(int walkType = 0)
            => Core.NWScript.ItemPropertySpecialWalk(walkType);
        //
        // Summary:
        //     Returns Item property spell immunity vs. spell school. You must specify the school
        //     to which the user will be immune(IP_CONST_SPELLSCHOOL_*).
        public static ItemProperty ItemPropertySpellImmunitySchool(IPConstSpellSchool school)
            => Core.NWScript.ItemPropertySpellImmunitySchool((int)school);

        //     Returns Item property spell immunity vs. specific spell. You must specify the
        //     spell to which the user will be immune(IP_CONST_IMMUNITYSPELL_*).
        public static ItemProperty ItemPropertySpellImmunitySpecific(IPConstImmunitySpell spell)
            => Core.NWScript.ItemPropertySpellImmunitySpecific((int)spell);

        //     Returns Item property Thieves tools. You must specify the modifier you wish the
        //     tools to have. The modifier must be an integer between 1 and 12.
        public static ItemProperty ItemPropertyThievesTools(int modifier)
            => Core.NWScript.ItemPropertyThievesTools(modifier);

        //     Returns Item property Trap. You must specify the trap level constant (IP_CONST_TRAPSTRENGTH_*)
        //     and the trap type constant(IP_CONST_TRAPTYPE_*).
        public static ItemProperty ItemPropertyTrap(IPConstTrapStrength trapLevel, IPConstTrapType trapType)
            => Core.NWScript.ItemPropertyTrap((int)trapLevel, (int)trapType);

        //     Returns Item property true seeing.
        public static ItemProperty ItemPropertyTrueSeeing()
            => Core.NWScript.ItemPropertyTrueSeeing();

        //     Returns Item property turn resistance. You must specify the resistance bonus.
        //     The bonus must be an integer between 1 and 50.
        public static ItemProperty ItemPropertyTurnResistance(int modifier)
            => Core.NWScript.ItemPropertyTurnResistance(modifier);

        //     Returns Item property unlimited ammo. If you leave the parameter field blank
        //     it will be just a normal bolt, arrow, or bullet. However you may specify that
        //     you want the ammunition to do special damage (ie. +1d6 Fire, or +1 enhancement
        //     bonus). For this parmeter you use the constants beginning with: (IP_CONST_UNLIMITEDAMMO_*).
        public static ItemProperty ItemPropertyUnlimitedAmmo(IPConstUnlimitedAmmo ammoDamage = IPConstUnlimitedAmmo.Basic)
            => Core.NWScript.ItemPropertyUnlimitedAmmo((int)ammoDamage);

        //     Returns Item property vampiric regeneration. You must specify the amount of regeneration.
        //     The regen amount must be an integer between 1 and 20.
        public static ItemProperty ItemPropertyVampiricRegeneration(int regenAmount)
            => Core.NWScript.ItemPropertyVampiricRegeneration(regenAmount);

        //     Creates a visual effect (ITEM_VISUAL_*) that may be applied to melee weapons
        //     only.
        public static ItemProperty ItemPropertyVisualEffect(ItemVisual effect)
            => Core.NWScript.ItemPropertyVisualEffect((int)effect);

        //     Returns Item property weight increase. You must specify the weight increase constant(IP_CONST_WEIGHTINCREASE_*).
        public static ItemProperty ItemPropertyWeightIncrease(IPConstWeightIncrease weight)
            => Core.NWScript.ItemPropertyWeightIncrease((int)weight);

        //     Returns Item property weight reduction. You need to specify the weight reduction
        //     constant(IP_CONST_REDUCEDWEIGHT_*).
        public static ItemProperty ItemPropertyWeightReduction(IPConstReducedWeight reduction)
            => Core.NWScript.ItemPropertyWeightReduction((int)reduction);
        //
        // Summary:
        //     Jump to lDestination. The action is added to the TOP of the action queue.
        public static void JumpToLocation(Location destination)
            => Core.NWScript.JumpToLocation(destination);

        //     Jump to oToJumpTo (the action is added to the top of the action queue).
        public static void JumpToObject(NWObject toJumpTo, bool walkStraightLineToPoint = true)
            => Core.NWScript.JumpToObject(toJumpTo, walkStraightLineToPoint ? 1 : 0);

        //     Levels up a creature using default settings. If successfull it returns the level
        //     the creature now is, or 0 if it fails. If you want to give them a different level
        //     (ie: Give a Fighter a level of Wizard) you can specify that in the nClass. However,
        //     if you specify a class to which the creature no package specified, they will
        //     use the default package for that class for their levelup choices. (ie: no Barbarian
        //     Savage/Wizard Divination combinations) If you turn on bReadyAllSpells, all memorized
        //     spells will be ready to cast without resting. if nPackage is PACKAGE_INVALID
        //     then it will use the starting package assigned to that class or just the class
        //     package
        public static int LevelUpHenchman(NWCreature creature, ClassType classType = ClassType.Invalid, bool readyAllSpells = true, Package package = Package.Invalid)
            => Core.NWScript.LevelUpHenchman(creature, (int)classType, readyAllSpells ? 1 : 0, (int)package);

        //     Returns whether or not there is a direct line of sight between the two objects.
        //     (Not blocked by any geometry). PLEASE NOTE: This is an expensive function and
        //     may degrade performance if used frequently.
        public static int LineOfSightObject(NWObject source, NWObject target)
            => Core.NWScript.LineOfSightObject(source, target);

        //     Returns whether or not there is a direct line of sight between the two vectors.
        //     (Not blocked by any geometry). This function must be run on a valid object in
        //     the area it will not work on the module or area. PLEASE NOTE: This is an expensive
        //     function and may degrade performance if used frequently.
        public static int LineOfSightVector(Vector3 source, Vector3 target)
            => Core.NWScript.LineOfSightVector(source, target);

        //     Create a location.
        public static Location Location(NWArea area, Vector3 position, float orientation)
            => Core.NWScript.Location(area, position, orientation);

        //     Locks the player's camera direction to its current direction, or unlocks the
        //     player's camera direction to enable it to move freely again. Stops the player
        //     from being able to rotate the camera direction. - oPlayer: A player object. -
        //     bLocked: TRUE/FALSE.
        public static void LockCameraDirection(NWPlayer player, bool locked = true)
            => Core.NWScript.LockCameraDirection(player, locked ? 1 : 0);

        //     Locks the player's camera distance to its current distance setting, or unlocks
        //     the player's camera distance. Stops the player from being able to zoom in/out
        //     the camera. - oPlayer: A player object. - bLocked: TRUE/FALSE.
        public static void LockCameraDistance(NWPlayer player, bool locked = true)
            => Core.NWScript.LockCameraDistance(player, locked ? 1 : 0);

        //     Locks the player's camera pitch to its current pitch setting, or unlocks the
        //     player's camera pitch. Stops the player from tilting their camera angle. - oPlayer:
        //     A player object. - bLocked: TRUE/FALSE.
        public static void LockCameraPitch(NWPlayer player, bool locked = true)
            => Core.NWScript.LockCameraPitch(player, locked ? 1 : 0);
        public static float log(float value)
            => Core.NWScript.log(value);

        //     Set the subtype of eEffect to Magical and return eEffect. (Effects default to
        //     magical if the subtype is not set) Magical effects are removed by resting, and
        //     by dispel magic
        public static Effect MagicalEffect(Effect effect)
            => Core.NWScript.MagicalEffect(effect);
        //
        // Summary:
        //     Change the background day track for oArea to nTrack. - oArea - nTrack
        public static void MusicBackgroundChangeDay(NWArea area, Track track)
            => Core.NWScript.MusicBackgroundChangeDay(area, (int)track);

        //     Change the background night track for oArea to nTrack. - oArea - nTrack
        public static void MusicBackgroundChangeNight(NWArea area, Track track)
            => Core.NWScript.MusicBackgroundChangeNight(area, (int)track);

        //     Get the Battle Track for oArea.
        public static Track MusicBackgroundGetBattleTrack(NWArea area)
            => (Track)Core.NWScript.MusicBackgroundGetBattleTrack(area);

        //     Get the Day Track for oArea.
        public static Track MusicBackgroundGetDayTrack(NWArea area)
            => (Track)Core.NWScript.MusicBackgroundGetDayTrack(area);

        //     Get the Night Track for oArea.
        public static Track MusicBackgroundGetNightTrack(NWArea area)
            => (Track)Core.NWScript.MusicBackgroundGetNightTrack(area);

        //     Play the background music for oArea.
        public static void MusicBackgroundPlay(NWArea area)
            => Core.NWScript.MusicBackgroundPlay(area);

        //     Set the delay for the background music for oArea. - oArea - nDelay: delay in
        //     milliseconds
        public static void MusicBackgroundSetDelay(NWArea area, int delay)
            => Core.NWScript.MusicBackgroundSetDelay(area, delay);

        //     Stop the background music for oArea.
        public static void MusicBackgroundStop(NWArea area)
            => Core.NWScript.MusicBackgroundStop(area);

        //     Change the battle track for oArea. - oArea - nTrack
        public static void MusicBattleChange(NWArea area, Track track)
            => Core.NWScript.MusicBattleChange(area, (int)track);

        //     Play the battle music for oArea.
        public static void MusicBattlePlay(NWArea area)
            => Core.NWScript.MusicBattlePlay(area);

        //     Stop the battle music for oArea.
        public static void MusicBattleStop(NWArea area)
            => Core.NWScript.MusicBattleStop(area);

        //     Changes the current Day/Night cycle for this player to daylight - oPlayer: which
        //     player to change the lighting for - fTransitionTime: how long the transition
        //     should take
        public static void NightToDay(NWPlayer player, float transitionTime = 0.0f)
            => Core.NWScript.NightToDay(player, transitionTime);

        //     Convert oObject into a hexadecimal string.
        public static string ObjectToString(NWObject obj)
            => Core.NWScript.ObjectToString(obj);

        //     Open's this creature's inventory panel for this player - oCreature: creature
        //     to view - oPlayer: the owner of this creature will see the panel pop up * DM's
        //     can view any creature's inventory * Players can view their own inventory, or
        //     that of their henchman, familiar or animal companion
        public static void OpenInventory(NWCreature creature, NWPlayer player)
            => Core.NWScript.OpenInventory(creature, player);

        //     Open oStore for oPC. - nBonusMarkUp is added to the stores default mark up percentage
        //     on items sold (-100 to 100) - nBonusMarkDown is added to the stores default mark
        //     down percentage on items bought (-100 to 100)
        public static void OpenStore(NWObject store, NWPlayer pc, int bonusMarkUp = 0, int bonusMarkDown = 0)
            => Core.NWScript.OpenStore(store, pc, bonusMarkUp, bonusMarkDown);

        //     Play nAnimation immediately. - nAnimation: ANIMATION_* - fSpeed - fSeconds
        public static void PlayAnimation(Animation animation, float speed = 1.0f, float seconds = 0)
            => Core.NWScript.PlayAnimation((int)animation, speed, seconds);

        //     Play sSoundName - sSoundName: TBD - SS This will play a mono sound from the location
        //     of the object running the command.
        public static void PlaySound(string soundName)
            => Core.NWScript.PlaySound(soundName);

        //     This will play a sound that is associated with a stringRef, it will be a mono
        //     sound from the location of the object running the command. if nRunAsAction is
        //     off then the sound is forced to play intantly.
        public static void PlaySoundByStrRef(int strRef, bool runAsAction = true)
            => Core.NWScript.PlaySoundByStrRef(strRef, runAsAction ? 1 : 0);

        //     Play a voice chat. - nVoiceChatID: VOICE_CHAT_* - oTarget
        public static void PlayVoiceChat(VoiceChat voiceChatID, NWObject? target = null)
            => Core.NWScript.PlayVoiceChat((int)voiceChatID, target ?? NWObject.OBJECT_SELF);

        //     Spawn in the Death GUI. The default (as defined by BioWare) can be spawned in
        //     by PopUpGUIPanel, but if you want to turn off the "Respawn" or "Wait for Help"
        //     buttons, this is the function to use. - oPC - bRespawnButtonEnabled: if this
        //     is TRUE, the "Respawn" button will be enabled on the Death GUI. - bWaitForHelpButtonEnabled:
        //     if this is TRUE, the "Wait For Help" button will be enabled on the Death GUI
        //     (Note: This button will not appear in single player games). - nHelpStringReference
        //     - sHelpString
        public static void PopUpDeathGUIPanel(NWPlayer pc, bool respawnButtonEnabled = true, bool waitForHelpButtonEnabled = true, int helpStringReference = 0, string helpString = "")
            => Core.NWScript.PopUpDeathGUIPanel(pc, respawnButtonEnabled ? 1 : 0, waitForHelpButtonEnabled ? 1 : 0, helpStringReference, helpString);

        //     Spawn a GUI panel for the client that controls oPC. - oPC - nGUIPanel: GUI_PANEL_*
        //     * Nothing happens if oPC is not a player character or if an invalid value is
        //     used for nGUIPanel.
        public static void PopUpGUIPanel(NWPlayer pc, GUIPanel panel)
            => Core.NWScript.PopUpGUIPanel(pc, (int)panel);

        //     Displays sMsg on oPC's screen. The message is displayed on top of whatever is
        //     on the screen, including UI elements nX, nY - coordinates of the first character
        //     to be displayed. The value is in terms of character 'slot' relative to the nAnchor
        //     anchor point. If the number is negative, it is applied from the bottom/right.
        //     nAnchor - SCREEN_ANCHOR_* constant fLife - Duration in seconds until the string
        //     disappears. nRGBA, nRGBA2 - Colors of the string in 0xRRGGBBAA format. String
        //     starts at nRGBA, but as it nears end of life, it will slowly blend into nRGBA2.
        //     nID - Optional ID of a string. If not 0, subsequent calls to PostString will
        //     remove the old string with the same ID, even if it's lifetime has not elapsed.
        //     Only positive values are allowed. sFont - If specified, use this custom font
        //     instead of default console font.
        public static void PostString(NWPlayer pc, string msg, int x = 0, int y = 0, ScreenAnchor anchor = ScreenAnchor.TopLeft, float life = 10.0f, int RGBA = 2147418367, int nRGBA2 = 2147418367, int id = 0, string font = "")
            => Core.NWScript.PostString(pc, msg, x, y, (int)anchor, life, RGBA, nRGBA2, id, font);
        public static float pow(float value, float exponent)
            => Core.NWScript.pow(value, exponent);

        //     Output a formatted float to the log file. - nWidth should be a value from 0 to
        //     18 inclusive. - nDecimals should be a value from 0 to 9 inclusive.
        public static void PrintFloat(float f, int width = 18, int decimals = 9)
            => Core.NWScript.PrintFloat(f, width, decimals);

        //     Output nInteger to the log file.
        public static void PrintInteger(int source)
            => Core.NWScript.PrintInteger(source);

        //     Output oObject's ID to the log file.
        public static void PrintObject(NWObject obj)
            => Core.NWScript.PrintObject(obj);

        //     Output sString to the log file.
        public static void PrintString(string str)
            => Core.NWScript.PrintString(str);

        //     Output vVector to the logfile. - vVector - bPrepend: if this is TRUE, the message
        //     will be prefixed with "PRINTVECTOR:"
        public static void PrintVector(Vector3 vector, bool prepend)
            => Core.NWScript.PrintVector(vector, prepend ? 1 : 0);

        //     Get an integer between 0 and nMaxInteger-1. Return value on error: 0
        public static int Random(int maxInteger)
            => Core.NWScript.Random(maxInteger);

        //     Generate a random name. nNameType: The type of random name to be generated (NAME_*)
        public static string RandomName(Name nameType = Name.FirstGenericMale)
            => Core.NWScript.RandomName((int)nameType);

        //     All clients in oArea will recompute the static lighting. This can be used to
        //     update the lighting after changing any tile lights or if placeables with lights
        //     have been added/deleted.
        public static void RecomputeStaticLighting(NWArea area)
            => Core.NWScript.RecomputeStaticLighting(area);

        //     Does a Reflex Save check for the given DC - oCreature - nDC: Difficulty check
        //     - nSaveType: SAVING_THROW_TYPE_* - oSaveVersus Returns: 0 if the saving throw
        //     roll failed Returns: 1 if the saving throw roll succeeded Returns: 2 if the target
        //     was immune to the save type specified Note: If used within an Area of Effect
        //     Object Script (On Enter, OnExit, OnHeartbeat), you MUST pass GetAreaOfEffectCreator()
        //     into oSaveVersus!!
        public static SavingThrowResult ReflexSave(NWCreature creature, int dc, SavingThrowType saveType = SavingThrowType.All, NWObject? saveVersus = null)
            => (SavingThrowResult)Core.NWScript.ReflexSave(creature, dc, (int)saveType, saveVersus ?? NWObject.OBJECT_INVALID);

        //     Remove eEffect from oCreature. * No return value
        public static void RemoveEffect(NWCreature creature, Effect effect)
            => Core.NWScript.RemoveEffect(creature, effect);

        //     Remove oPC from their current party. This will only work on a PC. - oPC: removes
        //     this player from whatever party they're currently in.
        public static void RemoveFromParty(NWPlayer pc)
            => Core.NWScript.RemoveFromParty(pc);

        //     Remove oHenchman from the service of oMaster, returning them to their original
        //     faction.
        public static void RemoveHenchman(NWCreature master, NWCreature? henchman = null)
            => Core.NWScript.RemoveHenchman(master, henchman ?? NWCreature.OBJECT_SELF);

        //     removes an item property from the specified item
        public static void RemoveItemProperty(NWItem item, ItemProperty itemProp)
            => Core.NWScript.RemoveItemProperty(item, itemProp);

        //     Remove a journal quest entry from oCreature. - szPlotID: the plot identifier
        //     used in the toolset's Journal Editor - oCreature - bAllPartyMembers: If this
        //     is TRUE, the entry will be removed from the journal of everyone in the party
        //     - bAllPlayers: If this is TRUE, the entry will be removed from the journal of
        //     everyone in the world
        public static void RemoveJournalQuestEntry(string plotID, NWCreature creature, bool allPartyMembers = true, bool allPlayers = false)
            => Core.NWScript.RemoveJournalQuestEntry(plotID, creature, allPartyMembers ? 1 : 0, allPlayers ? 1 : 0);

        //     Removes oAssociate from the service of oMaster, returning them to their original
        //     faction.
        public static void RemoveSummonedAssociate(NWCreature master, NWCreature? associate = null)
            => Core.NWScript.RemoveSummonedAssociate(master, associate ?? NWObject.OBJECT_SELF);
        //
        // Summary:
        //     Do not call. This does nothing on this platform except to return an error.
        public static void Reserved899()
            => Core.NWScript.Reserved899();

        //     Resets material shader parameters on the given object: - Supply a material to
        //     only reset shader uniforms for meshes with that material. - Supply a parameter
        //     to only reset shader uniforms of that name. - Supply both to only reset shader
        //     uniforms of that name on meshes with that material.
        public static void ResetMaterialShaderUniforms(NWObject obj, string material = "", string param = "")
            => Core.NWScript.ResetMaterialShaderUniforms(obj, material, param);

        //     Do a Spell Resistance check between oCaster and oTarget, returning TRUE if the
        //     spell was resisted. * Return value if oCaster or oTarget is an invalid object:
        //     FALSE * Return value if spell cast is not a player spell: - 1 * Return value
        //     if spell resisted: 1 * Return value if spell resisted via magic immunity: 2 *
        //     Return value if spell resisted via spell absorption: 3
        public static ResistSpellResult ResistSpell(NWCreature caster, NWObject target)
            => (ResistSpellResult)Core.NWScript.ResistSpell(caster, target);
        //
        // Summary:
        //     Restores the number of base attacks back to it's original state.
        public static void RestoreBaseAttackBonus(NWCreature? creature = null)
            => Core.NWScript.RestoreBaseAttackBonus(creature ?? NWObject.OBJECT_SELF);

        //     Restores the camera mode and position to what they were last time StoreCameraFacing
        //     was called. RestoreCameraFacing can only be called once, and must correspond
        //     to a previous call to StoreCameraFacing.
        public static void RestoreCameraFacing()
            => Core.NWScript.RestoreCameraFacing();

        //     Use RetrieveCampaign with the given id to restore it. If you specify an owner,
        //     the object will try to be created in their repository If the owner can't handle
        //     the item (or if it's a creature) it will be created on the ground.
        public static NWObject RetrieveCampaignObject(string campaignName, string varName, Location location, NWObject? owner = null, NWPlayer? player = null)
            => new NWObject(Core.NWScript.RetrieveCampaignObject(campaignName, varName, location, owner ?? NWObject.OBJECT_INVALID, player ?? NWObject.OBJECT_INVALID));

        //     Convert nRounds into a number of seconds A round is always 6.0 seconds
        public static float RoundsToSeconds(int rounds)
            => Core.NWScript.RoundsToSeconds(rounds);

        //     Sends szMessage to all the Dungeon Masters currently on the server.
        public static void SendMessageToAllDMs(string message)
            => Core.NWScript.SendMessageToAllDMs(message);

        //     Send a server message (szMessage) to the oPlayer.
        public static void SendMessageToPC(NWPlayer player, string message)
            => Core.NWScript.SendMessageToPC(player, message);

        //     Send a server message (szMessage) to the oPlayer.
        public static void SendMessageToPCByStrRef(NWPlayer player, int strRef)
            => Core.NWScript.SendMessageToPCByStrRef(player, strRef);

        //     Sets the ability bonus limit. - The minimum value is 0.
        public static void SetAbilityBonusLimit(int newLimit)
            => Core.NWScript.SetAbilityBonusLimit(newLimit);

        //     Sets the ability penalty limit. - The minimum value is 0.
        public static void SetAbilityPenaltyLimit(int newLimit)
            => Core.NWScript.SetAbilityPenaltyLimit(newLimit);

        //     Sets the status of modes ACTION_MODE_* on a creature.
        public static void SetActionMode(NWCreature creature, ActionMode mode, bool status)
            => Core.NWScript.SetActionMode(creature, (int)mode, status ? 1 : 0);

        //     Sets the current AI Level of the creature to the value specified. Does not work
        //     on Players. The game by default will choose an appropriate AI level for creatures
        //     based on the circumstances that the creature is in. Explicitly setting an AI
        //     level will over ride the game AI settings. The new setting will last until SetAILevel
        //     is called again with the argument AI_LEVEL_DEFAULT. AI_LEVEL_DEFAULT - Default
        //     setting. The game will take over seting the appropriate AI level when required.
        //     AI_LEVEL_VERY_LOW - Very Low priority, very stupid, but low CPU usage for AI.
        //     Typically used when no players are in the area. AI_LEVEL_LOW - Low priority,
        //     mildly stupid, but slightly more CPU usage for AI. Typically used when not in
        //     combat, but a player is in the area. AI_LEVEL_NORMAL - Normal priority, average
        //     AI, but more CPU usage required for AI. Typically used when creature is in combat.
        //     AI_LEVEL_HIGH - High priority, smartest AI, but extremely high CPU usage required
        //     for AI. Avoid using this. It is most likely only ever needed for cutscenes.
        public static void SetAILevel(NWObject target, AILevel aiLevel)
            => Core.NWScript.SetAILevel(target, (int)aiLevel);

        //     Set the transition bitmap of a player; this should only be called in area transition
        //     scripts. This action should be run by the person "clicking" the area transition
        //     via AssignCommand. - nPredefinedAreaTransition: -> To use a predefined area transition
        //     bitmap, use one of AREA_TRANSITION_* -> To use a custom, user-defined area transition
        //     bitmap, use AREA_TRANSITION_USER_DEFINED and specify the filename in the second
        //     parameter - sCustomAreaTransitionBMP: this is the filename of a custom, user-defined
        //     area transition bitmap
        public static void SetAreaTransitionBMP(AreaTransition predefinedAreaTransition, string customAreaTransitionBMP = "")
            => Core.NWScript.SetAreaTransitionBMP((int)predefinedAreaTransition, customAreaTransitionBMP);

        //     Initialise oTarget to listen for the standard Associates commands.
        public static void SetAssociateListenPatterns(NWObject? target = null)
            => Core.NWScript.SetAssociateListenPatterns(target ?? NWObject.OBJECT_SELF);

        //     Sets the attack bonus limit. - The minimum value is 0.
        public static void SetAttackBonusLimit(int newLimit)
            => Core.NWScript.SetAttackBonusLimit(newLimit);
        //
        // Summary:
        //     Sets the number of base attacks for the specified creatures. The range of values
        //     accepted are from 1 to 6 Note: This function does not work on Player Characters
        public static void SetBaseAttackBonus(int baseAttackBonus, NWCreature? creature = null)
            => Core.NWScript.SetBaseAttackBonus(baseAttackBonus, creature ?? NWObject.OBJECT_SELF);

        //     Set the calendar to the specified date. - nYear should be from 0 to 32000 inclusive
        //     - nMonth should be from 1 to 12 inclusive - nDay should be from 1 to 28 inclusive
        //     1) Time can only be advanced forwards; attempting to set the time backwards will
        //     result in no change to the calendar. 2) If values larger than the month or day
        //     are specified, they will be wrapped around and the overflow will be used to advance
        //     the next field. e.g. Specifying a year of 1350, month of 33 and day of 10 will
        //     result in the calender being set to a year of 1352, a month of 9 and a day of
        //     10.
        public static void SetCalendar(int year, int month, int day)
            => Core.NWScript.SetCalendar(year, month, day);

        //     Change the direction in which the camera is facing - fDirection is expressed
        //     as anticlockwise degrees from Due East. (0.0f=East, 90.0f=North, 180.0f=West,
        //     270.0f=South) A value of -1.0f for any parameter will be ignored and instead
        //     it will use the current camera value. This can be used to change the way the
        //     camera is facing after the player emerges from an area transition. - nTransitionType:
        //     CAMERA_TRANSITION_TYPE_* SNAP will immediately move the camera to the new position,
        //     while the other types will result in the camera moving gradually into position
        //     Pitch and distance are limited to valid values for the current camera mode: Top
        //     Down: Distance = 5-20, Pitch = 1-50 Driving camera: Distance = 6 (can't be changed),
        //     Pitch = 1-62 Chase: Distance = 5-20, Pitch = 1-50 *** NOTE *** In NWN:Hordes
        //     of the Underdark the camera limits have been relaxed to the following: Distance
        //     1-25 Pitch 1-89
        public static void SetCameraFacing(float direction, float distance = -1.0f, float pitch = -1.0f, CameraTransitionType transitionType = CameraTransitionType.Snap)
            => Core.NWScript.SetCameraFacing(direction, distance, pitch, (int)transitionType);

        //     Forces this player's camera to be set to this height. Setting this value to zero
        //     will restore the camera to the racial default height.
        public static void SetCameraHeight(NWPlayer player, float height = 0.0f)
            => Core.NWScript.SetCameraHeight(player, height);

        //     Set the camera mode for oPlayer. - oPlayer - nCameraMode: CAMERA_MODE_* * If
        //     oPlayer is not player-controlled or nCameraMode is invalid, nothing happens.
        public static void SetCameraMode(NWPlayer player, CameraMode cameraMode)
            => Core.NWScript.SetCameraMode(player, (int)cameraMode);

        //     This stores a float out to the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static void SetCampaignFloat(string campaignName, string varName, float f, NWPlayer? player = null)
            => Core.NWScript.SetCampaignFloat(campaignName, varName, f, player ?? NWObject.OBJECT_INVALID);

        //     This stores an int out to the specified campaign database The database name IS
        //     case sensitive and it must be the same for both set and get functions. The var
        //     name must be unique across the entire database, regardless of the variable type.
        //     If you want a variable to pertain to a specific player in the game, provide a
        //     player object.
        public static void SetCampaignInt(string campaignName, string varName, int i, NWPlayer? player = null)
            => Core.NWScript.SetCampaignInt(campaignName, varName, i, player ?? NWObject.OBJECT_INVALID);

        //     This stores a location out to the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static void SetCampaignLocation(string campaignName, string varName, Location location, NWPlayer? player = null)
            => Core.NWScript.SetCampaignLocation(campaignName, varName, location, player ?? NWObject.OBJECT_INVALID);

        //     This stores a string out to the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static void SetCampaignString(string campaignName, string varName, string str, NWPlayer? player = null)
            => Core.NWScript.SetCampaignString(campaignName, varName, str, player ?? NWObject.OBJECT_INVALID);

        //     This stores a vector out to the specified campaign database The database name
        //     IS case sensitive and it must be the same for both set and get functions. The
        //     var name must be unique across the entire database, regardless of the variable
        //     type. If you want a variable to pertain to a specific player in the game, provide
        //     a player object.
        public static void SetCampaignVector(string campaignName, string varName, Vector3 vector, NWPlayer? player = null)
            => Core.NWScript.SetCampaignVector(campaignName, varName, vector, player ?? NWObject.OBJECT_INVALID);

        //     Set the color channel of oObject to the color specified. - oObject: the object
        //     for which you are changing the color. Can be a creature that has color information
        //     (i.e. the playable races). - nColorChannel: The color channel that you want to
        //     set the color value of. COLOR_CHANNEL_SKIN COLOR_CHANNEL_HAIR COLOR_CHANNEL_TATTOO_1
        //     COLOR_CHANNEL_TATTOO_2 - nColorValue: The color you want to set (0-175).
        public static void SetColor(NWObject obj, ColorChannel colorChannel, int colorValue)
            => Core.NWScript.SetColor(obj, (int)colorChannel, colorValue);

        //     Set whether oTarget's action stack can be modified
        public static void SetCommandable(bool isCommandable, NWObject? target = null)
            => Core.NWScript.SetCommandable(isCommandable ? 1 : 0, target ?? NWObject.OBJECT_SELF);

        //     Sets the creature's appearance type to the value specified (uses the APPEARANCE_TYPE_XXX
        //     constants)
        public static void SetCreatureAppearanceType(NWCreature creature, AppearanceType appearanceType)
            => Core.NWScript.SetCreatureAppearanceType(creature, (int)appearanceType);
        public static void SetCreatureBodyPart(CreaturePart part, int modelNumber, NWCreature? creature = null)
            => Core.NWScript.SetCreatureBodyPart((int)part, modelNumber, creature ?? NWObject.OBJECT_SELF);

        //     Sets the creature to auto-explore the map as it walks around. Keep in mind that
        //     tile exploration also controls object visibility in areas and the fog of war
        //     for interior and underground areas. This means that if you turn off auto exploration,
        //     it falls to you to manage this through SetTileExplored(); otherwise, the player
        //     will not be able to see anything. Valid arguments: TRUE and FALSE. Does nothing
        //     for non-creatures. Returns the previous state (or -1 if non-creature).
        public static int SetCreatureExploresMinimap(NWCreature creature, bool newState)
            => Core.NWScript.SetCreatureExploresMinimap(creature, newState ? 1 : 0);

        //     Sets the Tail type of the creature specified. - nTailType (CREATURE_TAIL_TYPE_*)
        //     CREATURE_TAIL_TYPE_NONE CREATURE_TAIL_TYPE_LIZARD CREATURE_TAIL_TYPE_BONE CREATURE_TAIL_TYPE_DEVIL
        //     - oCreature: the creature to change the Tail type for. Note: Only two creature
        //     model types will support Tails. The MODELTYPE for the part based (playable) races
        //     'P' and MODELTYPE 'T'in the appearance.2da
        public static void SetCreatureTailType(CreatureTailType tailType, NWCreature? creature = null)
            => Core.NWScript.SetCreatureTailType((int)tailType, creature ?? NWObject.OBJECT_SELF);

        //     Sets the Wing type of the creature specified. - nWingType (CREATURE_WING_TYPE_*)
        //     CREATURE_WING_TYPE_NONE CREATURE_WING_TYPE_DEMON CREATURE_WING_TYPE_ANGEL CREATURE_WING_TYPE_BAT
        //     CREATURE_WING_TYPE_DRAGON CREATURE_WING_TYPE_BUTTERFLY CREATURE_WING_TYPE_BIRD
        //     - oCreature: the creature to change the wing type for. Note: Only two creature
        //     model types will support wings. The MODELTYPE for the part based (playable races)
        //     'P' and MODELTYPE 'W'in the appearance.2da
        public static void SetCreatureWingType(CreatureWingType wingType, NWCreature? creature = null)
            => Core.NWScript.SetCreatureWingType((int)wingType, creature ?? NWObject.OBJECT_SELF);

        //     Set the value for a custom token.
        public static void SetCustomToken(int customTokenNumber, string tokenValue)
            => Core.NWScript.SetCustomToken(customTokenNumber, tokenValue);

        //     Sets the current movement rate factor for the cutscene camera man. NOTE: You
        //     can only set values between 0.1, 2.0 (10%-200%)
        public static void SetCutsceneCameraMoveRate(NWCreature creature, float rate)
            => Core.NWScript.SetCutsceneCameraMoveRate(creature, rate);

        //     Sets the given creature into cutscene mode. This prevents the player from using
        //     the GUI and camera controls. - oCreature: creature in a cutscene - nInCutscene:
        //     TRUE to move them into cutscene, FALSE to remove cutscene mode - nLeftClickingEnabled:
        //     TRUE to allow the user to interact with the game world using the left mouse button
        //     only. FALSE to stop the user from interacting with the game world. Note: SetCutsceneMode(oPlayer,
        //     TRUE) will also make the player 'plot' (unkillable). SetCutsceneMode(oPlayer,
        //     FALSE) will restore the player's plot flag to what it was when SetCutsceneMode(oPlayer,
        //     TRUE) was called.
        public static void SetCutsceneMode(NWCreature creature, bool isInCutscene = true, bool leftClickingEnabled = false)
            => Core.NWScript.SetCutsceneMode(creature, isInCutscene ? 1 : 0, leftClickingEnabled ? 1 : 0);

        //     Sets the damage bonus limit. - The minimum value is 0.
        public static void SetDamageBonusLimit(int newLimit)
            => Core.NWScript.SetDamageBonusLimit(newLimit);

        //     Set the name of oCreature's Deity to sDeity.
        public static void SetDeity(NWCreature creature, string deity)
            => Core.NWScript.SetDeity(creature, deity);

        //     Set the description of oObject. - oObject: the object for which you are changing
        //     the description Can be a creature, placeable, item, door, or trigger. - sNewDescription:
        //     the new description that the object will use. - bIdentified: If oObject is an
        //     item, setting this to TRUE will set the identified description, setting this
        //     to FALSE will set the unidentified description. This flag has no effect on objects
        //     other than items. Note: Setting an object's description to "" will make the object
        //     revert to using the description it originally had before any SetDescription()
        //     calls were made on the object.
        public static void SetDescription(NWObject obj, string newDescription = "", bool identifiedDescription = true)
            => Core.NWScript.SetDescription(obj, newDescription, identifiedDescription ? 1 : 0);

        //     Sets the droppable flag on an item - oItem: the item to change - bDroppable:
        //     TRUE or FALSE, whether the item should be droppable Droppable items will appear
        //     on a creature's remains when the creature is killed.
        public static void SetDroppableFlag(NWItem item, bool isDroppable)
            => Core.NWScript.SetDroppableFlag(item, isDroppable ? 1 : 0);

        //     Set oEncounter's active state to nNewValue. - nNewValue: TRUE/FALSE - oEncounter
        public static void SetEncounterActive(bool newValue, NWObject? encounter = null)
            => Core.NWScript.SetEncounterActive(newValue ? 1 : 0, encounter ?? NWObject.OBJECT_SELF);

        //     Set the difficulty level of oEncounter. - nEncounterDifficulty: ENCOUNTER_DIFFICULTY_*
        //     - oEncounter
        public static void SetEncounterDifficulty(EncounterDifficulty encounterDifficulty, NWObject? encounter = null)
            => Core.NWScript.SetEncounterDifficulty((int)encounterDifficulty, encounter ?? NWObject.OBJECT_SELF);

        //     Set the number of times that oEncounter has spawned so far
        public static void SetEncounterSpawnsCurrent(int newValue, NWObject? encounter = null)
            => Core.NWScript.SetEncounterSpawnsCurrent(newValue, encounter ?? NWObject.OBJECT_SELF);

        //     Set the maximum number of times that oEncounter can spawn
        public static void SetEncounterSpawnsMax(int newValue, NWObject? encounter = null)
            => Core.NWScript.SetEncounterSpawnsMax(newValue, encounter ?? NWObject.OBJECT_SELF);

        //     Sets the given event script for the given object and handler. Returns 1 on success,
        //     0 on failure. Will fail if oObject is invalid or does not have the requested
        //     handler.
        public static int SetEventScript(NWObject obj, EventScript handler, string script)
            => Core.NWScript.SetEventScript(obj, (int)handler, script);

        //     Cause the caller to face fDirection. - fDirection is expressed as anticlockwise
        //     degrees from Due East. DIRECTION_EAST, DIRECTION_NORTH, DIRECTION_WEST and DIRECTION_SOUTH
        //     are predefined. (0.0f=East, 90.0f=North, 180.0f=West, 270.0f=South)
        public static void SetFacing(float direction)
            => Core.NWScript.SetFacing(direction);

        //     Cause the caller to face vTarget
        public static void SetFacingPoint(Vector3 target)
            => Core.NWScript.SetFacingPoint(target);

        //     Sets the fog amount in the area specified. nFogType = FOG_TYPE_* specifies wether
        //     the Sun, Moon, or both fog types are set. nFogAmount = specifies the density
        //     that the fog is being set to. If no valid area (or object) is specified, it uses
        //     the area of caller. If an object other than an area is specified, will use the
        //     area that the object is currently in.
        public static void SetFogAmount(FogType fogType, int fogAmount, NWArea? area = null)
            => Core.NWScript.SetFogAmount((int)fogType, fogAmount, area ?? NWObject.OBJECT_INVALID);

        //     Sets the fog color in the area specified. nFogType = FOG_TYPE_* specifies wether
        //     the Sun, Moon, or both fog types are set. nFogColor = FOG_COLOR_* specifies the
        //     color the fog is being set to. The fog color can also be represented as a hex
        //     RGB number if specific color shades are desired. The format of a hex specified
        //     color would be 0xFFEEDD where FF would represent the amount of red in the color
        //     EE would represent the amount of green in the color DD would represent the amount
        //     of blue in the color. If no valid area (or object) is specified, it uses the
        //     area of caller. If an object other than an area is specified, will use the area
        //     that the object is currently in.
        public static void SetFogColor(FogType fogType, FogColor fogColor, NWArea? area = null)
            => Core.NWScript.SetFogColor((int)fogType, (int)fogColor, area ?? NWObject.OBJECT_INVALID);

        //     Sets the footstep type of the creature specified. Changing a creature's footstep
        //     type will change the sound that its feet make when ever the creature makes takes
        //     a step. By default a creature's footsteps are detemined by the appearance type
        //     of the creature. SetFootstepType() allows you to make a creature use a difference
        //     footstep type than it would use by default for its given appearance. - nFootstepType
        //     (FOOTSTEP_TYPE_*): FOOTSTEP_TYPE_NORMAL FOOTSTEP_TYPE_LARGE FOOTSTEP_TYPE_DRAGON
        //     FOOTSTEP_TYPE_SoFT FOOTSTEP_TYPE_HOOF FOOTSTEP_TYPE_HOOF_LARGE FOOTSTEP_TYPE_BEETLE
        //     FOOTSTEP_TYPE_SPIDER FOOTSTEP_TYPE_SKELETON FOOTSTEP_TYPE_LEATHER_WING FOOTSTEP_TYPE_FEATHER_WING
        //     FOOTSTEP_TYPE_DEFAULT - Makes the creature use its original default footstep
        //     sounds. FOOTSTEP_TYPE_NONE - oCreature: the creature to change the footstep sound
        //     for.
        public static void SetFootstepType(FootstepType footstepType, NWCreature? creature = null)
            => Core.NWScript.SetFootstepType((int)footstepType, creature ?? NWObject.OBJECT_INVALID);

        //     Set the Fortitude saving throw value of the Door or Placeable object oObject.
        //     - oObject: a door or placeable object. - nFortitudeSave: must be between 0 and
        //     250.
        public static void SetFortitudeSavingThrow(NWObject obj, int fortitudeSave)
            => Core.NWScript.SetFortitudeSavingThrow(obj, fortitudeSave);

        //     Sets the Hardness of a Door or Placeable object. - nHardness: must be between
        //     0 and 250. - oObject: a door or placeable object. Does nothing if used on an
        //     object that is neither a door nor a placeable.
        public static void SetHardness(int hardness, NWObject? obj = null)
            => Core.NWScript.SetHardness(hardness, obj ?? NWObject.OBJECT_SELF);

        //     Sets whether the provided item should be hidden when equipped. - The intended
        //     usage of this function is to provide an easy way to hide helmets, but it can
        //     be used equally for any slot which has creature mesh visibility when equipped,
        //     e.g.: armour, helm, cloak, left hand, and right hand. - nValue should be TRUE
        //     or FALSE.
        public static void SetHiddenWhenEquipped(NWItem item, bool value)
            => Core.NWScript.SetHiddenWhenEquipped(item, value ? 1 : 0);

        //     Set whether oItem has been identified.
        public static void SetIdentified(NWItem item, bool isIdentified)
            => Core.NWScript.SetIdentified(item, isIdentified ? 1 : 0);

        //     Set a creature's immortality flag. -oCreature: creature affected -bImmortal:
        //     TRUE = creature is immortal and cannot be killed (but still takes damage) FALSE
        //     = creature is not immortal and is damaged normally. This scripting command only
        //     works on Creature objects.
        public static void SetImmortal(NWCreature creature, bool isImmortal)
            => Core.NWScript.SetImmortal(creature, isImmortal ? 1 : 0);

        //     Sets the Infinite flag on an item - oItem: the item to change - bInfinite: TRUE
        //     or FALSE, whether the item should be Infinite The infinite property affects the
        //     buying/selling behavior of the item in a store. An infinite item will still be
        //     available to purchase from a store after a player buys the item (non-infinite
        //     items will disappear from the store when purchased).
        public static void SetInfiniteFlag(NWItem item, bool isInfinite = true)
            => Core.NWScript.SetInfiniteFlag(item, isInfinite ? 1 : 0);

        //     Set the destroyable status of the caller. - bDestroyable: If this is FALSE, the
        //     caller does not fade out on death, but sticks around as a corpse. - bRaiseable:
        //     If this is TRUE, the caller can be raised via resurrection. - bSelectableWhenDead:
        //     If this is TRUE, the caller is selectable after death.
        public static void SetIsDestroyable(bool isDestroyable, bool isRaiseable = true, bool selectableWhenDead = false)
            => Core.NWScript.SetIsDestroyable(isDestroyable ? 1 : 0, isRaiseable ? 1 : 0, selectableWhenDead ? 1 : 0);
        public static void SetIsTemporaryEnemy(NWObject target, NWObject? source = null, bool decays = false, float durationInSeconds = 180.0f)
            => Core.NWScript.SetIsTemporaryEnemy(target, source ?? NWObject.OBJECT_SELF, decays ? 1 : 0, durationInSeconds);

        //     oSource will temporarily be friends towards oTarget. bDecays determines whether
        //     the personal reputation value decays over time fDurationInSeconds is the length
        //     of time that the temporary friendship lasts Make oSource into a temporary friend
        //     of oTarget using personal reputation. - oTarget - oSource - bDecays: If this
        //     is TRUE, the friendship decays over fDurationInSeconds; otherwise it is indefinite.
        //     - fDurationInSeconds: This is only used if bDecays is TRUE, it is how long the
        //     friendship lasts. Note: If bDecays is TRUE, the personal reputation amount decreases
        //     in size over fDurationInSeconds. Friendship will only be in effect as long as
        //     (faction reputation + total personal reputation) >= REPUTATION_TYPE_FRIEND.
        public static void SetIsTemporaryFriend(NWObject target, NWObject? source = null, bool decays = false, float durationInSeconds = 180.0f)
            => Core.NWScript.SetIsTemporaryFriend(target, source ?? NWObject.OBJECT_SELF, decays ? 1 : 0, durationInSeconds);
        public static void SetIsTemporaryNeutral(NWObject target, NWObject? source = null, bool decays = false, float durationInSeconds = 180.0f)
            => Core.NWScript.SetIsTemporaryNeutral(target, source ?? NWObject.OBJECT_SELF, decays ? 1 : 0, durationInSeconds);

        //     Sets charges left on an item. - oItem: item to change - nCharges: number of charges.
        //     If value below 0 is passed, # charges will be set to 0. If value greater than
        //     maximum is passed, # charges will be set to maximum. If the # charges drops to
        //     0 the item will be destroyed.
        public static void SetItemCharges(NWItem item, int charges)
            => Core.NWScript.SetItemCharges(item, charges);

        //     When cursed, items cannot be dropped
        public static void SetItemCursedFlag(NWItem item, bool cursed)
            => Core.NWScript.SetItemCursedFlag(item, cursed ? 1 : 0);

        //     Sets stack size of an item. - oItem: item to change - nSize: new size of stack.
        //     Will be restricted to be between 1 and the maximum stack size for the item type.
        //     If a value less than 1 is passed it will set the stack to 1. If a value greater
        //     than the max is passed then it will set the stack to the maximum size
        public static void SetItemStackSize(NWItem item, int size)
            => Core.NWScript.SetItemStackSize(item, size);

        //     Set the feedback message that is displayed when trying to unlock the object oObject.
        //     This will only have an effect if the object is set to "Key required to unlock
        //     or lock" either in the toolset or by using the scripting command SetLockKeyRequired().
        //     - oObject: a door or placeable. - sFeedbackMessage: the string to be displayed
        //     in the player's text window. to use the game's default message, set sFeedbackMessage
        //     to ""
        public static void SetKeyRequiredFeedback(NWStationary obj, string feedbackMessage)
            => Core.NWScript.SetKeyRequiredFeedback(obj, feedbackMessage);


        //     Set whether oObject is listening.
        public static void SetListening(NWObject obj, bool isListening)
            => Core.NWScript.SetListening(obj, isListening ? 1 : 0);

        //     Set the string for oObject to listen for. Note: this does not set oObject to
        //     be listening.
        public static void SetListenPattern(NWObject obj, string pattern, int number = 0)
            => Core.NWScript.SetListenPattern(obj, pattern, number);

        //     Set oObject's local float variable sVarName to nValue
        public static void SetLocalFloat(NWObject obj, string varName, float value)
            => Core.NWScript.SetLocalFloat(obj, varName, value);

        //     Set oObject's local integer variable sVarName to nValue
        public static void SetLocalInt(NWObject obj, string varName, int value)
            => Core.NWScript.SetLocalInt(obj, varName, value);

        //     Set oObject's local location variable sVarname to lValue
        public static void SetLocalLocation(NWObject obj, string varName, Location value)
            => Core.NWScript.SetLocalLocation(obj, varName, value);

        //     Set oObject's local object variable sVarName to nValue
        public static void SetLocalObject(NWObjectBase obj, string varName, uint value)
            => Core.NWScript.SetLocalObject(obj, varName, value);

        //     Set oObject's local string variable sVarName to nValue
        public static void SetLocalString(NWObject obj, string varName, string value)
            => Core.NWScript.SetLocalString(obj, varName, value);

        //     Set the locked state of oTarget, which can be a door or a placeable object.
        public static void SetLocked(NWObject target, bool isLocked)
            => Core.NWScript.SetLocked(target, isLocked ? 1 : 0);

        //     When set the object can not be opened unless the opener possesses the required
        //     key. The key tag required can be specified either in the toolset, or by using
        //     the SetLockKeyTag() scripting command. - oObject: a door, or placeable. - nKeyRequired:
        //     TRUE/FALSE
        public static void SetLockKeyRequired(NWObject obj, bool isKeyRequired = true)
            => Core.NWScript.SetLockKeyRequired(obj, isKeyRequired ? 1 : 0);

        //     Set the key tag required to open object oObject. This will only have an effect
        //     if the object is set to "Key required to unlock or lock" either in the toolset
        //     or by using the scripting command SetLockKeyRequired(). - oObject: a door, placeable
        //     or trigger. - sNewKeyTag: the key tag required to open the locked object.
        public static void SetLockKeyTag(NWObject obj, string newKeyTag)
            => Core.NWScript.SetLockKeyTag(obj, newKeyTag);

        //     Sets whether or not the object can be locked. - oObject: a door or placeable.
        //     - nLockable: TRUE/FALSE
        public static void SetLockLockable(NWObject obj, bool isLockable = true)
            => Core.NWScript.SetLockLockable(obj, isLockable ? 1 : 0);

        //     Sets the DC for locking the object. - oObject: a door or placeable object. -
        //     nNewLockDC: must be between 0 and 250.
        public static void SetLockLockDC(NWObject obj, int newLockDC)
            => Core.NWScript.SetLockLockDC(obj, newLockDC);

        //     Sets the DC for unlocking the object. - oObject: a door or placeable object.
        //     - nNewUnlockDC: must be between 0 and 250.
        public static void SetLockUnlockDC(NWObject obj, int newUnlockDC)
            => Core.NWScript.SetLockUnlockDC(obj, newUnlockDC);

        //     Sets the lootable state of a *living* NPC creature. This function will *not*
        //     work on players or dead creatures.
        public static void SetLootable(NWCreature creature, bool isLootable)
            => Core.NWScript.SetLootable(creature, isLootable ? 1 : 0);

        //     Set whether oMapPin is enabled. - oMapPin - nEnabled: 0=Off, 1=On
        public static void SetMapPinEnabled(NWObjectBase mapPin, bool isEnabled)
            => Core.NWScript.SetMapPinEnabled(mapPin, isEnabled ? 1 : 0);
        //
        // Summary:
        //     Sets an integer material shader uniform override. - sMaterial needs to be a material
        //     on that object. - sParam needs to be a valid shader parameter already defined
        //     on the material.
        public static void SetMaterialShaderUniformInt(NWObject obj, string material, string param, int value)
            => Core.NWScript.SetMaterialShaderUniformInt(obj, material, param, value);

        //     Sets a vec4 material shader uniform override. - sMaterial needs to be a material
        //     on that object. - sParam needs to be a valid shader parameter already defined
        //     on the material. - You can specify a single float value to set just a float,
        //     instead of a vec4.
        public static void SetMaterialShaderUniformVec4(NWObject obj, string material, string param, Vector4 vec = default)
            => Core.NWScript.SetMaterialShaderUniformVec4(obj, material, param, vec.W, vec.X, vec.Y, vec.Z);

        //     Sets the maximum number of henchmen
        public static void SetMaxHenchmen(int numHenchmen)
            => Core.NWScript.SetMaxHenchmen(numHenchmen);

        //     Set the XP scale used by the module. - nXPScale: The XP scale to be used. Must
        //     be between 0 and 200.
        public static void SetModuleXPScale(int xpScale)
            => Core.NWScript.SetModuleXPScale(xpScale);

        //     Set the name of oObject. - oObject: the object for which you are changing the
        //     name (a creature, placeable, item, or door). - sNewName: the new name that the
        //     object will use. Note: SetName() does not work on player objects. Setting an
        //     object's name to "" will make the object revert to using the name it had originally
        //     before any SetName() calls were made on the object.
        public static void SetName(NWObject obj, string newName = "")
            => Core.NWScript.SetName(obj, newName);

        //     Sets a visual transform on the given object. - oObject can be any valid Creature,
        //     Placeable, Item or Door. - nTransform is one of OBJECT_VISUAL_TRANSFORM_* - fValue
        //     depends on the transformation to apply. Returns the old/previous value.
        public static float SetObjectVisualTransform(NWObject obj, ObjectVisualTransform transform, float value)
            => Core.NWScript.SetObjectVisualTransform(obj, (int)transform, value);

        //     Make the corresponding panel button on the player's client start or stop flashing.
        //     - oPlayer - nButton: PANEL_BUTTON_* - nEnableFlash: if this is TRUE nButton will
        //     start flashing. It if is FALSE, nButton will stop flashing.
        public static void SetPanelButtonFlash(NWPlayer player, PanelButton button, bool enableFlash)
            => Core.NWScript.SetPanelButtonFlash(player, (int)button, enableFlash ? 1 : 0);

        //     Set the last player chat(text) message before it gets sent to other players.
        //     - sNewChatMessage: The new chat text to be sent onto other players. Setting the
        //     player chat message to an empty string "", will cause the chat message to be
        //     discarded (i.e. it will not be sent to other players). Note: The new chat message
        //     gets sent after the OnPlayerChat script exits.
        public static void SetPCChatMessage(string newChatMessage = "")
            => Core.NWScript.SetPCChatMessage(newChatMessage);

        //     Set the last player chat(text) volume before it gets sent to other players. -
        //     nTalkVolume: The new volume of the chat text to be sent onto other players. TALKVOLUME_TALK
        //     TALKVOLUME_WHISPER TALKVOLUME_SHOUT TALKVOLUME_SILENT_SHOUT (used for DM chat
        //     channel) TALKVOLUME_PARTY TALKVOLUME_TELL (sends the chat message privately back
        //     to the original speaker) Note: The new chat message gets sent after the OnPlayerChat
        //     script exits.
        public static void SetPCChatVolume(TalkVolume talkVolume = TalkVolume.Talk)
            => Core.NWScript.SetPCChatVolume((int)talkVolume);

        //     Sets oPlayer and oTarget to dislike each other.
        public static void SetPCDislike(NWPlayer player, NWObject target)
            => Core.NWScript.SetPCDislike(player, target);

        //     Sets oPlayer and oTarget to like each other.
        public static void SetPCLike(NWPlayer player, NWObject target)
            => Core.NWScript.SetPCLike(player, target);

        //     Sets the creature's PhenoType (body type) to the type specified. nPhenoType =
        //     PHENOTYPE_NORMAL nPhenoType = PHENOTYPE_BIG nPhenoType = PHENOTYPE_CUSTOM* -
        //     The custom PhenoTypes should only ever be used if you have specifically created
        //     your own custom content that requires the use of a new PhenoType and you have
        //     specified the appropriate custom PhenoType in your custom content. SetPhenoType
        //     will only work on part based creature (i.e. the starting default playable races).
        public static void SetPhenoType(Phenotype phenoType, NWCreature? creature = null)
            => Core.NWScript.SetPhenoType((int)phenoType, creature ?? NWObject.OBJECT_SELF);

        //     Sets the Pickpocketable flag on an item - oItem: the item to change - bPickpocketable:
        //     TRUE or FALSE, whether the item can be pickpocketed.
        public static void SetPickpocketableFlag(NWItem item, bool isPickpocketable)
            => Core.NWScript.SetPickpocketableFlag(item, isPickpocketable ? 1 : 0);

        //     Set the status of the illumination for oPlaceable. - oPlaceable - bIlluminate:
        //     if this is TRUE, oPlaceable's illumination will be turned on. If this is FALSE,
        //     oPlaceable's illumination will be turned off. Note: You must call RecomputeStaticLighting()
        //     after calling this function in order for the changes to occur visually for the
        //     players. SetPlaceableIllumination() buffers the illumination changes, which are
        //     then sent out to the players once RecomputeStaticLighting() is called. As such,
        //     it is best to call SetPlaceableIllumination() for all the placeables you wish
        //     to set the illumination on, and then call RecomputeStaticLighting() once after
        //     all the placeable illumination has been set. * If oPlaceable is not a placeable
        //     object, or oPlaceable is a placeable that doesn't have a light, nothing will
        //     happen.
        public static void SetPlaceableIllumination(NWPlaceable? placeable = null, bool illuminate = true)
            => Core.NWScript.SetPlaceableIllumination(placeable ?? NWObject.OBJECT_SELF, illuminate ? 1 : 0);

        //     Set oTarget's plot object status.
        public static void SetPlotFlag(NWObject target, bool plotFlag)
            => Core.NWScript.SetPlotFlag(target, plotFlag ? 1 : 0);

        //     Change the portrait of oTarget to use the Portrait Id specified. - oTarget: the
        //     object for which you are changing the portrait. - nPortraitId: The Id of the
        //     new portrait to use. nPortraitId refers to a row in the Portraits.2da Note: Not
        //     all portrait Ids are suitable for use with all object types. Setting the portrait
        //     Id will also cause the portrait ResRef to be set to the appropriate portrait
        //     ResRef for the Id specified.
        public static void SetPortraitId(NWObject target, int portraitId)
            => Core.NWScript.SetPortraitId(target, portraitId);

        //     Change the portrait of oTarget to use the Portrait ResRef specified. - oTarget:
        //     the object for which you are changing the portrait. - sPortraitResRef: The ResRef
        //     of the new portrait to use. The ResRef should not include any trailing size letter
        //     ( e.g. po_el_f_09_ ). Note: Not all portrait ResRefs are suitable for use with
        //     all object types. Setting the portrait ResRef will also cause the portrait Id
        //     to be set to PORTRAIT_INVALID.
        public static void SetPortraitResRef(NWObject target, string portraitResRef)
            => Core.NWScript.SetPortraitResRef(target, portraitResRef);

        //     Set the Reflex saving throw value of the Door or Placeable object oObject. -
        //     oObject: a door or placeable object. - nReflexSave: must be between 0 and 250.
        public static void SetReflexSavingThrow(NWObject obj, int reflexSave)
            => Core.NWScript.SetReflexSavingThrow(obj, reflexSave);

        //     Sets the saving throw bonus limit. - The minimum value is 0.
        public static void SetSavingThrowBonusLimit(int newLimit)
            => Core.NWScript.SetSavingThrowBonusLimit(newLimit);

        //     Sets the skill bonus limit. - The minimum value is 0.
        public static void SetSkillBonusLimit(int newLimit)
            => Core.NWScript.SetSkillBonusLimit(newLimit);

        //     Changes the sky that is displayed in the specified area. nSkyBox = SKYBOX_* constants
        //     (associated with skyboxes.2da) If no valid area (or object) is specified, it
        //     uses the area of caller. If an object other than an area is specified, will use
        //     the area that the object is currently in.
        public static void SetSkyBox(SkyBox skyBox, NWArea? area = null)
            => Core.NWScript.SetSkyBox((int)skyBox, area ?? NWObject.OBJECT_INVALID);

        //     Set how nStandardFaction feels about oCreature. - nStandardFaction: STANDARD_FACTION_*
        //     - nNewReputation: 0-100 (inclusive) - oCreature
        public static void SetStandardFactionReputation(StandardFaction standardFaction, int newReputation, NWCreature? creature = null)
            => Core.NWScript.SetStandardFactionReputation((int)standardFaction, newReputation, creature ?? NWObject.OBJECT_SELF);

        //     Sets whether this item is 'stolen' or not
        public static void SetStolenFlag(NWItem item, bool isStolen)
            => Core.NWScript.SetStolenFlag(item, isStolen ? 1 : 0);

        //     Sets the amount of gold a store has. -1 means the store does not use gold.
        public static void SetStoreGold(NWObjectBase store, int gold)
            => Core.NWScript.SetStoreGold(store, gold);

        //     Sets the amount a store charges for identifying an item. Default is 100. -1 means
        //     the store will not identify items.
        public static void SetStoreIdentifyCost(NWObjectBase store, int cost)
            => Core.NWScript.SetStoreIdentifyCost(store, cost);

        //     Sets the maximum amount a store will pay for any item. -1 means price unlimited.
        public static void SetStoreMaxBuyPrice(NWObjectBase store, int maxBuy)
            => Core.NWScript.SetStoreMaxBuyPrice(store, maxBuy);

        //     Set the name of oCreature's sub race to sSubRace.
        public static void SetSubRace(NWCreature creature, string subRace)
            => Core.NWScript.SetSubRace(creature, subRace);

        //     Sets a new tag for oObject. Will do nothing for invalid objects or the module
        //     object. Note: Care needs to be taken with this function. Changing the tag for
        //     creature with waypoints will make them stop walking them. Changing waypoint,
        //     door or trigger tags will break their area transitions.
        public static void SetTag(NWObject obj, string newTag)
            => Core.NWScript.SetTag(obj, newTag);

        //     Makes oPC load texture sNewName instead of sOldName. If oPC is OBJECT_INVALID,
        //     it will apply the override to all active players Setting sNewName to "" will
        //     clear the override and revert to original.
        public static void SetTextureOverride(string oldName, string newName = "", NWObject? pc = null)
            => Core.NWScript.SetTextureOverride(oldName, newName, pc ?? NWObject.OBJECT_INVALID);

        //     Sets if the given creature has explored tile at x, y of the given area. Note
        //     that creature needs to be a player- or player-possessed creature. Keep in mind
        //     that tile exploration also controls object visibility in areas and the fog of
        //     war for interior and underground areas. Return values: -1: Area or creature invalid.
        //     0: Tile was not explored before setting newState. 1: Tile was explored before
        //     setting newState.
        public enum SetTileExploredResult { ObjectInvalid = -1, TileNotExploredBeforeNewState = 0, TileExploredBeforeNewState = 1 }
        public static SetTileExploredResult SetTileExplored(NWCreature creature, NWArea area, int x, int y, int newState)
            => (SetTileExploredResult)Core.NWScript.SetTileExplored(creature, area, x, y, newState);

        //     Set the main light color on the tile at lTileLocation. - lTileLocation: the vector
        //     part of this is the tile grid (x,y) coordinate of the tile. - nMainLight1Color:
        //     TILE_MAIN_LIGHT_COLOR_* - nMainLight2Color: TILE_MAIN_LIGHT_COLOR_*
        public static void SetTileMainLightColor(Location tileLocation, TileMainLightColor mainLight1Color, TileMainLightColor mainLight2Color)
            => Core.NWScript.SetTileMainLightColor(tileLocation, (int)mainLight1Color, (int)mainLight2Color);

        //     Set the source light color on the tile at lTileLocation. - lTileLocation: the
        //     vector part of this is the tile grid (x,y) coordinate of the tile. - nSourceLight1Color:
        //     TILE_SOURCE_LIGHT_COLOR_* - nSourceLight2Color: TILE_SOURCE_LIGHT_COLOR_*
        public static void SetTileSourceLightColor(Location tileLocation, TileSourceLightColor sourceLight1Color, TileSourceLightColor sourceLight2Color)
            => Core.NWScript.SetTileSourceLightColor(tileLocation, (int)sourceLight1Color, (int)sourceLight2Color);

        //     Set the time to the time specified. - nHour should be from 0 to 23 inclusive
        //     - nMinute should be from 0 to 59 inclusive - nSecond should be from 0 to 59 inclusive
        //     - nMillisecond should be from 0 to 999 inclusive 1) Time can only be advanced
        //     forwards; attempting to set the time backwards will result in the day advancing
        //     and then the time being set to that specified, e.g. if the current hour is 15
        //     and then the hour is set to 3, the day will be advanced by 1 and the hour will
        //     be set to 3. 2) If values larger than the max hour, minute, second or millisecond
        //     are specified, they will be wrapped around and the overflow will be used to advance
        //     the next field, e.g. specifying 62 hours, 250 minutes, 10 seconds and 10 milliseconds
        //     will result in the calendar day being advanced by 2 and the time being set to
        //     18 hours, 10 minutes, 10 milliseconds.
        public static void SetTime(int hour, int minute, int second, int millisecond)
            => Core.NWScript.SetTime(hour, minute, second, millisecond);

        //     Sets the transition target for oTransition. Notes: - oTransition can be any valid
        //     game object, except areas. - oTarget can be any valid game object with a location,
        //     or OBJECT_INVALID (to unlink). - Rebinding a transition will NOT change the other
        //     end of the transition; for example, with normal doors you will have to do either
        //     end separately. - Any valid game object can hold a transition target, but only
        //     some are used by the game engine (doors and triggers). This might change in the
        //     future. You can still set and query them for other game objects from nwscript.
        //     - Transition target objects are cached: The toolset-configured destination tag
        //     is used for a lookup only once, at first use. Thus, attempting to use SetTag()
        //     to change the destination for a transition will not work in a predictable fashion.
        public static void SetTransitionTarget(NWObject transition, NWObject target)
            => Core.NWScript.SetTransitionTarget(transition, target);

        //     Sets whether or not the trap is an active trap - oTrapObject: a placeable, door
        //     or trigger - nActive: TRUE/FALSE Notes: Setting a trap as inactive will not make
        //     the trap disappear if it has already been detected. Call SetTrapDetectedBy()
        //     to make a detected trap disappear. To make an inactive trap not detectable call
        //     SetTrapDetectable()
        public static void SetTrapActive(NWStationary trapObject, bool isActive = true)
            => Core.NWScript.SetTrapActive(trapObject, isActive ? 1 : 0);

        //     Sets whether or not the trapped object can be detected. - oTrapObject: a placeable,
        //     door or trigger - nDetectable: TRUE/FALSE Note: Setting a trapped object to not
        //     be detectable will not make the trap disappear if it has already been detected.
        public static void SetTrapDetectable(NWStationary trapObject, bool isDetectable = true)
            => Core.NWScript.SetTrapDetectable(trapObject, isDetectable ? 1 : 0);

        //     Set the DC for detecting oTrapObject. - oTrapObject: a placeable, door or trigger
        //     - nDetectDC: must be between 0 and 250.
        public static void SetTrapDetectDC(NWStationary trapObject, int detectDC)
            => Core.NWScript.SetTrapDetectDC(trapObject, detectDC);

        //     Set whether or not the creature oDetector has detected the trapped object oTrap.
        //     - oTrap: A trapped trigger, placeable or door object. - oDetector: This is the
        //     creature that the detected status of the trap is being adjusted for. - bDetected:
        //     A Boolean that sets whether the trapped object has been detected or not.
        public static int SetTrapDetectedBy(NWStationary trappedObject, NWCreature detector, bool detected = true)
            => Core.NWScript.SetTrapDetectedBy(trappedObject, detector, detected ? 1 : 0);

        //     Disable oTrap. - oTrap: a placeable, door or trigger.
        public static void SetTrapDisabled(NWStationary trap)
            => Core.NWScript.SetTrapDisabled(trap);

        //     Sets whether or not the trapped object can be disarmed. - oTrapObject: a placeable,
        //     door or trigger - nDisarmable: TRUE/FALSE
        public static void SetTrapDisarmable(NWStationary trapObject, bool disarmable = true)
            => Core.NWScript.SetTrapDisarmable(trapObject, disarmable ? 1 : 0);

        //     Set the DC for disarming oTrapObject. - oTrapObject: a placeable, door or trigger
        //     - nDisarmDC: must be between 0 and 250.
        public static void SetTrapDisarmDC(NWStationary trapObject, int disarmDC)
            => Core.NWScript.SetTrapDisarmDC(trapObject, disarmDC);

        //     Set the tag of the key that will disarm oTrapObject. - oTrapObject: a placeable,
        //     door or trigger
        public static void SetTrapKeyTag(NWStationary trapObject, string keyTag)
            => Core.NWScript.SetTrapKeyTag(trapObject, keyTag);

        //     Sets whether or not the trap is a one-shot trap (i.e. whether or not the trap
        //     resets itself after firing). - oTrapObject: a placeable, door or trigger - nOneShot:
        //     TRUE/FALSE
        public static void SetTrapOneShot(NWStationary trapObject, bool oneShot = true)
            => Core.NWScript.SetTrapOneShot(trapObject, oneShot ? 1 : 0);

        //     Sets whether or not the trapped object can be recovered. - oTrapObject: a placeable,
        //     door or trigger
        public static void SetTrapRecoverable(NWStationary trapObject, bool isRecoverable = true)
            => Core.NWScript.SetTrapRecoverable(trapObject, isRecoverable ? 1 : 0);
        //
        // Summary:
        //     Set oPlaceable's useable object status. Note: Only works on non-static placeables.
        public static void SetUseableFlag(NWPlaceable placeable, bool useableFlag)
            => Core.NWScript.SetUseableFlag(placeable, useableFlag ? 1 : 0);

        //     Set the weather for oTarget. - oTarget: if this is GetModule(), all outdoor areas
        //     will be modified by the weather constant. If it is an area, oTarget will play
        //     the weather only if it is an outdoor area. - nWeather: WEATHER_* -> WEATHER_USER_AREA_SETTINGS
        //     will set the area back to random weather. -> WEATHER_CLEAR, WEATHER_RAIN, WEATHER_SNOW
        //     will make the weather go to the appropriate precipitation *without stopping*.
        public static void SetWeather(NWObject target, Weather weather)
            => Core.NWScript.SetWeather(target, (int)weather);

        //     Set the Will saving throw value of the Door or Placeable object oObject. - oObject:
        //     a door or placeable object. - nWillSave: must be between 0 and 250.
        public static void SetWillSavingThrow(NWObject obj, int willSave)
            => Core.NWScript.SetWillSavingThrow(obj, willSave);

        //     Sets oCreature's experience to nXpAmount.
        public static void SetXP(NWCreature creature, int xpAmount)
            => Core.NWScript.SetXP(creature, xpAmount);

        //     Causes object oObject to run the event evToRun. The script on the object that
        //     is associated with the event specified will run. Events can be created using
        //     the following event functions: EventActivateItem() - This creates an OnActivateItem
        //     module event. The script for handling this event can be set in Module Properties
        //     on the Event Tab. EventConversation() - This creates on OnConversation creature
        //     event. The script for handling this event can be set by viewing the Creature
        //     Properties on a creature and then clicking on the Scripts Tab. EventSpellCastAt()
        //     - This creates an OnSpellCastAt event. The script for handling this event can
        //     be set in the Scripts Tab of the Properties menu for the object. EventUserDefined()
        //     - This creates on OnUserDefined event. The script for handling this event can
        //     be set in the Scripts Tab of the Properties menu for the object/area/module.
        public static void SignalEvent(NWObject obj, Event eventToRun)
            => Core.NWScript.SignalEvent(obj, eventToRun);

        //     Maths operation: sine of fValue
        public static float sin(float value)
            => Core.NWScript.sin(value);

        //     Play oSound.
        public static void SoundObjectPlay(NWObjectBase sound)
            => Core.NWScript.SoundObjectPlay(sound);

        //     Set the position of oSound.
        public static void SoundObjectSetPosition(NWObjectBase sound, Vector3 position)
            => Core.NWScript.SoundObjectSetPosition(sound, position);

        //     Set the volume of oSound. - oSound - nVolume: 0-127
        public static void SoundObjectSetVolume(NWObjectBase sound, int volume)
            => Core.NWScript.SoundObjectSetVolume(sound, volume);

        //     Stop playing oSound.
        public static void SoundObjectStop(NWObjectBase sound)
            => Core.NWScript.SoundObjectStop(sound);

        //     SpawnScriptDebugger() will cause the script debugger to be executed after this
        //     command is executed! In order to compile the script for debugging go to Tools->Options->Script
        //     Editor and check the box labeled "Generate Debug Information When Compiling Scripts"
        //     After you have checked the above box, recompile the script that you want to debug.
        //     If the script file isn't compiled for debugging, this command will do nothing.
        //     Remove any SpawnScriptDebugger() calls once you have finished debugging the script.
        public static void SpawnScriptDebugger()
            => Core.NWScript.SpawnScriptDebugger();

        //     Immediately speak a conversation one-liner. - sDialogResRef - oTokenTarget: This
        //     must be specified if there are creature-specific tokens in the string.
        public static void SpeakOneLinerConversation(string dialogResRef = "", NWCreature? tokenTarget = null)
            => Core.NWScript.SpeakOneLinerConversation(dialogResRef, tokenTarget ?? NWObject.OBJECT_INVALID);

        //     The caller will immediately speak sStringToSpeak (this is different from ActionSpeakString)
        //     - sStringToSpeak - nTalkVolume: TALKVOLUME_*
        public static void SpeakString(string stringToSpeak, TalkVolume talkVolume = TalkVolume.Talk)
            => Core.NWScript.SpeakString(stringToSpeak, (int)talkVolume);

        //     Causes the object to instantly speak a translated string. (not an action, not
        //     blocked when uncommandable) - nStrRef: Reference of the string in the talk table
        //     - nTalkVolume: TALKVOLUME_*
        public static void SpeakStringByStrRef(int strRef, TalkVolume talkVolume = TalkVolume.Talk)
            => Core.NWScript.SpeakStringByStrRef(strRef, (int)talkVolume);
        public static float sqrt(float value)
            => Core.NWScript.sqrt(value);

        //     Shut down the currently loaded module and start a new one (moving all currently-connected
        //     players to the starting point.
        public static void StartNewModule(string moduleName)
            => Core.NWScript.StartNewModule(moduleName);

        //     Removes any fading or black screen. - oCreature: creature controlled by player
        //     that should be cleared
        public static void StopFade(NWCreature creature)
            => Core.NWScript.StopFade(creature);

        //     Stores the current camera mode and position so that it can be restored (using
        //     RestoreCameraFacing())
        public static void StoreCameraFacing()
            => Core.NWScript.StoreCameraFacing();
        //
        // Summary:
        //     Stores an object with the given id. NOTE: this command can only be used for storing
        //     Creatures and Items. Returns 0 if it failled, 1 if it worked.
        public static int StoreCampaignObject(string campaignName, string varName, NWObject obj, NWPlayer? player = null)
            => Core.NWScript.StoreCampaignObject(campaignName, varName, obj, player ?? NWObject.OBJECT_INVALID);

        //     Convert sNumber into a floating point number.
        public static float StringToFloat(string number)
            => Core.NWScript.StringToFloat(number);

        //     Convert sNumber into an integer.
        public static int StringToInt(string number)
            => Core.NWScript.StringToInt(number);

        //     Summon an Animal Companion
        public static void SummonAnimalCompanion(NWCreature? master = null)
            => Core.NWScript.SummonAnimalCompanion(master ?? NWObject.OBJECT_SELF);

        //     Summon a Familiar
        public static void SummonFamiliar(NWCreature? master = null)
            => Core.NWScript.SummonFamiliar(master ?? NWObject.OBJECT_SELF);

        //     Set the subtype of eEffect to Supernatural and return eEffect. (Effects default
        //     to magical if the subtype is not set) Permanent supernatural effects are not
        //     removed by resting
        public static Effect SupernaturalEffect(Effect effect)
            => Core.NWScript.SupernaturalEffect(effect);

        //     Use this on an NPC to cause all creatures within a 10-metre radius to stop what
        //     they are doing and sets the NPC's enemies within this range to be neutral towards
        //     the NPC for roughly 3 minutes. If this command is run on a PC or an object that
        //     is not a creature, nothing will happen.
        public static void SurrenderToEnemies()
            => Core.NWScript.SurrenderToEnemies();

        //     Tags the effect with the provided string. - Any other tags in the link will be
        //     overwritten.
        public static Effect TagEffect(Effect effect, string newTag)
            => Core.NWScript.TagEffect(effect, newTag);

        //     Tags the item property with the provided string. - Any tags currently set on
        //     the item property will be overwritten.
        public static ItemProperty TagItemProperty(ItemProperty property, string newTag)
            => Core.NWScript.TagItemProperty(property, newTag);

        //     Take nAmount of gold from oCreatureToTakeFrom. - nAmount - oCreatureToTakeFrom:
        //     If this is not a valid creature, nothing will happen. - bDestroy: If this is
        //     TRUE, the caller will not get the gold. Instead, the gold will be destroyed and
        //     will vanish from the game.
        public static void TakeGoldFromCreature(int amount, NWCreature creatureToTakeFrom, bool destroy = false)
            => Core.NWScript.TakeGoldFromCreature(amount, creatureToTakeFrom, destroy ? 1 : 0);

        //     Create a Feat Talent. - nFeat: FEAT_*
        public static Talent TalentFeat(Feat feat)
            => Core.NWScript.TalentFeat((int)feat);

        //     Create a Skill Talent. - nSkill: SKILL_*
        public static Talent TalentSkill(Skill skill)
            => Core.NWScript.TalentSkill((int)skill);

        //     Create a Spell Talent. - nSpell: SPELL_*
        public static Talent TalentSpell(Spell spell)
            => Core.NWScript.TalentSpell((int)spell);

        //     Maths operation: tan of fValue
        public static float tan(float value)
            => Core.NWScript.tan(value);

        //     * Returns TRUE if sStringToTest matches sPattern.
        public static bool TestStringAgainstPattern(string pattern, string stringToTest)
            => Core.NWScript.TestStringAgainstPattern(pattern, stringToTest) == 1;

        //     The caller will perform a Melee Touch Attack on oTarget This is not an action,
        //     and it assumes the caller is already within range of oTarget * Returns 0 on a
        //     miss, 1 on a hit and 2 on a critical hit
        public enum AttackResult { Miss = 0, Hit = 1, CriticalHit = 2 }
        public static AttackResult TouchAttackMelee(NWObject target, bool displayFeedback = true)
            => (AttackResult)Core.NWScript.TouchAttackMelee(target, displayFeedback ? 1 : 0);

        //     The caller will perform a Ranged Touch Attack on oTarget * Returns 0 on a miss,
        //     1 on a hit and 2 on a critical hit
        public static AttackResult TouchAttackRanged(NWObject target, bool displayFeedback = true)
            => (AttackResult)Core.NWScript.TouchAttackRanged(target, displayFeedback ? 1 : 0);

        //     Convert nTurns into a number of seconds A turn is always 60.0 seconds
        public static float TurnsToSeconds(int turns)
            => Core.NWScript.TurnsToSeconds(turns);

        //     Unlock an achievement for the given player who must be logged in. - sId is the
        //     achievement ID on the remote server - nLastValue is the previous value of the
        //     associated achievement stat - nCurValue is the current value of the associated
        //     achievement stat - nMaxValue is the maximum value of the associate achievement
        //     stat
        public static void UnlockAchievement(NWPlayer player, string id, int lastValue = 0, int curValue = 0, int maxValue = 0)
            => Core.NWScript.UnlockAchievement(player, id, lastValue, curValue, maxValue);

        //     This will cause a Player Creature to unpossess his/her familiar. It will work
        //     if run on the player creature or the possessed familiar. It does not work in
        //     conjunction with any DM possession.
        public static void UnpossessFamiliar(NWCreature creature)
            => Core.NWScript.UnpossessFamiliar(creature);

        //     Create a vector with the specified values for x, y and z
        public static Vector3 Vector(float x = 0, float y = 0, float z = 0)
            => Core.NWScript.Vector(x, y, z);

        //     Get the magnitude of vVector; this can be used to determine the distance between
        //     two points. * Return value on error: 0.0f
        public static float VectorMagnitude(Vector3 vector)
            => Core.NWScript.VectorMagnitude(vector);

        //     Normalize vVector
        public static Vector3 VectorNormalize(Vector3 vector)
            => Core.NWScript.VectorNormalize(vector);

        //     Convert vVector to an angle
        public static float VectorToAngle(Vector3 vector)
            => Core.NWScript.VectorToAngle(vector);

        //     Set eEffect to be versus a specific alignment. - eEffect - nLawChaos: ALIGNMENT_LAWFUL/ALIGNMENT_CHAOTIC/ALIGNMENT_ALL
        //     - nGoodEvil: ALIGNMENT_GOOD/ALIGNMENT_EVIL/ALIGNMENT_ALL
        public static Effect VersusAlignmentEffect(Effect effect, Alignment lawChaos = Alignment.All, Alignment goodEvil = Alignment.All)
            => Core.NWScript.VersusAlignmentEffect(effect, (int)lawChaos, (int)goodEvil);

        //     Set eEffect to be versus nRacialType. - eEffect - nRacialType: RACIAL_TYPE_*
        public static Effect VersusRacialTypeEffect(Effect effect, RacialType racialType)
            => Core.NWScript.VersusRacialTypeEffect(effect, (int)racialType);

        //     Set eEffect to be versus traps.
        public static Effect VersusTrapEffect(Effect effect)
            => Core.NWScript.VersusTrapEffect(effect);


        //     Vibrate the player's device or controller. Does nothing if vibration is not supported.
        //     - nMotor is one of VIBRATOR_MOTOR_* - fStrength is between 0.0 and 1.0 - fSeconds
        //     is the number of seconds to vibrate
        public static void Vibrate(NWPlayer player, VibratorMotor motor, float strength, float seconds)
            => Core.NWScript.Vibrate(player, (int)motor, strength, seconds);

        //     Does a Will Save check for the given DC - oCreature - nDC: Difficulty check -
        //     nSaveType: SAVING_THROW_TYPE_* - oSaveVersus Returns: 0 if the saving throw roll
        //     failed Returns: 1 if the saving throw roll succeeded Returns: 2 if the target
        //     was immune to the save type specified Note: If used within an Area of Effect
        //     Object Script (On Enter, OnExit, OnHeartbeat), you MUST pass GetAreaOfEffectCreator()
        //     into oSaveVersus!!
        public static SavingThrowResult WillSave(NWCreature creature, int fc, SavingThrowType saveType = SavingThrowType.All, NWObject? saveVersus = null)
            => (SavingThrowResult)Core.NWScript.WillSave(creature, fc, (int)saveType, saveVersus ?? NWObject.OBJECT_INVALID);

        //     Write sLogEntry as a timestamped entry into the log file
        public static void WriteTimestampedLogEntry(string logEntry)
            => Core.NWScript.WriteTimestampedLogEntry(logEntry);

        //     Convert fYards into a number of meters.
        public static float YardsToMeters(float yards)
            => Core.NWScript.YardsToMeters(yards);
    }
}
