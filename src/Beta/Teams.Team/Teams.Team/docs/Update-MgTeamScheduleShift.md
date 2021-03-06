---
external help file:
Module Name: Microsoft.Graph.Teams.Team
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.team/update-mgteamscheduleshift
schema: 2.0.0
---

# Update-MgTeamScheduleShift

## SYNOPSIS
Update the navigation property shifts in teams

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgTeamScheduleShift -ShiftId <String> -TeamId <String> [-CreatedDateTime <DateTime>]
 [-DraftShiftActivities <IMicrosoftGraphShiftActivity[]>] [-DraftShiftDisplayName <String>]
 [-DraftShiftEndDateTime <DateTime>] [-DraftShiftNotes <String>] [-DraftShiftStartDateTime <DateTime>]
 [-DraftShiftTheme <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-SchedulingGroupId <String>]
 [-SharedShiftActivities <IMicrosoftGraphShiftActivity[]>] [-SharedShiftDisplayName <String>]
 [-SharedShiftEndDateTime <DateTime>] [-SharedShiftNotes <String>] [-SharedShiftStartDateTime <DateTime>]
 [-SharedShiftTheme <String>] [-UserId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgTeamScheduleShift -ShiftId <String> -TeamId <String> -BodyParameter <IMicrosoftGraphShift>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgTeamScheduleShift -InputObject <ITeamsTeamIdentity> -BodyParameter <IMicrosoftGraphShift> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgTeamScheduleShift -InputObject <ITeamsTeamIdentity> [-CreatedDateTime <DateTime>]
 [-DraftShiftActivities <IMicrosoftGraphShiftActivity[]>] [-DraftShiftDisplayName <String>]
 [-DraftShiftEndDateTime <DateTime>] [-DraftShiftNotes <String>] [-DraftShiftStartDateTime <DateTime>]
 [-DraftShiftTheme <String>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-SchedulingGroupId <String>]
 [-SharedShiftActivities <IMicrosoftGraphShiftActivity[]>] [-SharedShiftDisplayName <String>]
 [-SharedShiftEndDateTime <DateTime>] [-SharedShiftNotes <String>] [-SharedShiftStartDateTime <DateTime>]
 [-SharedShiftTheme <String>] [-UserId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property shifts in teams

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
shift
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShift
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DraftShiftActivities
.
To construct, see NOTES section for DRAFTSHIFTACTIVITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftActivity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DraftShiftDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DraftShiftEndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DraftShiftNotes
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DraftShiftStartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DraftShiftTheme
scheduleEntityTheme

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SchedulingGroupId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharedShiftActivities
.
To construct, see NOTES section for SHAREDSHIFTACTIVITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShiftActivity[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharedShiftDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharedShiftEndDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharedShiftNotes
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharedShiftStartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SharedShiftTheme
scheduleEntityTheme

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShiftId
key: shift-id of shift

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TeamId
key: team-id of team

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphShift

### Microsoft.Graph.PowerShell.Models.ITeamsTeamIdentity

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphShift>: shift
  - `[CreatedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[DraftShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
    - `[Code <String>]`: 
    - `[DisplayName <String>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[IsPaid <Boolean?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Theme <String>]`: scheduleEntityTheme
  - `[DraftShiftDisplayName <String>]`: 
  - `[DraftShiftEndDateTime <DateTime?>]`: 
  - `[DraftShiftNotes <String>]`: 
  - `[DraftShiftStartDateTime <DateTime?>]`: 
  - `[DraftShiftTheme <String>]`: scheduleEntityTheme
  - `[SchedulingGroupId <String>]`: 
  - `[SharedShiftActivities <IMicrosoftGraphShiftActivity[]>]`: 
  - `[SharedShiftDisplayName <String>]`: 
  - `[SharedShiftEndDateTime <DateTime?>]`: 
  - `[SharedShiftNotes <String>]`: 
  - `[SharedShiftStartDateTime <DateTime?>]`: 
  - `[SharedShiftTheme <String>]`: scheduleEntityTheme
  - `[UserId <String>]`: 

#### DRAFTSHIFTACTIVITIES <IMicrosoftGraphShiftActivity[]>: .
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[IsPaid <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Theme <String>]`: scheduleEntityTheme

#### INPUTOBJECT <ITeamsTeamIdentity>: Identity Parameter
  - `[ChannelId <String>]`: key: channel-id of channel
  - `[ChatMessageHostedContentId <String>]`: key: chatMessageHostedContent-id of chatMessageHostedContent
  - `[ChatMessageId <String>]`: key: chatMessage-id of chatMessage
  - `[ChatMessageId1 <String>]`: key: chatMessage-id of chatMessage
  - `[ConversationMemberId <String>]`: key: conversationMember-id of conversationMember
  - `[GroupId <String>]`: key: group-id of group
  - `[OfferShiftRequestId <String>]`: key: offerShiftRequest-id of offerShiftRequest
  - `[OpenShiftChangeRequestId <String>]`: key: openShiftChangeRequest-id of openShiftChangeRequest
  - `[OpenShiftId <String>]`: key: openShift-id of openShift
  - `[SchedulingGroupId <String>]`: key: schedulingGroup-id of schedulingGroup
  - `[ShiftId <String>]`: key: shift-id of shift
  - `[SwapShiftsChangeRequestId <String>]`: key: swapShiftsChangeRequest-id of swapShiftsChangeRequest
  - `[TeamId <String>]`: key: team-id of team
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[TeamsAsyncOperationId <String>]`: key: teamsAsyncOperation-id of teamsAsyncOperation
  - `[TeamsCatalogAppId <String>]`: key: teamsCatalogApp-id of teamsCatalogApp
  - `[TeamsTabId <String>]`: key: teamsTab-id of teamsTab
  - `[TeamsTemplateId <String>]`: key: teamsTemplate-id of teamsTemplate
  - `[TimeOffId <String>]`: key: timeOff-id of timeOff
  - `[TimeOffReasonId <String>]`: key: timeOffReason-id of timeOffReason
  - `[TimeOffRequestId <String>]`: key: timeOffRequest-id of timeOffRequest
  - `[UserId <String>]`: key: user-id of user
  - `[WorkforceIntegrationId <String>]`: key: workforceIntegration-id of workforceIntegration

#### LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### SHAREDSHIFTACTIVITIES <IMicrosoftGraphShiftActivity[]>: .
  - `[Code <String>]`: 
  - `[DisplayName <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[IsPaid <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[Theme <String>]`: scheduleEntityTheme

## RELATED LINKS

