---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/get-mgdrivespecial
schema: 2.0.0
---

# Get-MgDriveSpecial

## SYNOPSIS
Get special from drive

## SYNTAX

### List (Default)
```
Get-MgDriveSpecial [-Count] [-Expand <String[]>] [-Filter <String>] [-Orderby <String[]>] [-Search <String>]
 [-Select <String[]>] [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgDriveSpecial -DriveItemId <String> [-Expand <String[]>] [-Select <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgDriveSpecial -DriveId <String> -DriveItemId <String> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgDriveSpecial -InputObject <IFilesDrivesIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgDriveSpecial -InputObject <IFilesDrivesIdentity> [-Expand <String[]>] [-Select <String[]>]
 [<CommonParameters>]
```

### List1
```
Get-MgDriveSpecial -DriveId <String> [-Count] [-Expand <String[]>] [-Filter <String>] [-Orderby <String[]>]
 [-Search <String>] [-Select <String[]>] [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Get special from drive

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

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DriveId
key: drive-id of drive

```yaml
Type: System.String
Parameter Sets: Get1, List1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DriveItemId
key: driveItem-id of driveItem

```yaml
Type: System.String
Parameter Sets: Get, Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Expand
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List, List1
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
Type: Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity
Parameter Sets: GetViaIdentity, GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Orderby
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Select
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List1
Aliases:

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

### Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDriveItem

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IFilesDrivesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[DriveId <String>]`: key: drive-id of drive
  - `[DriveItemId <String>]`: key: driveItem-id of driveItem
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ItemActivityOldId1 <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[Q <String>]`: 
  - `[SubscriptionId <String>]`: key: subscription-id of subscription

## RELATED LINKS

