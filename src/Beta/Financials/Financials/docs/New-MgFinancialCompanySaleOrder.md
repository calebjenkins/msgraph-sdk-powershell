---
external help file:
Module Name: Microsoft.Graph.Financials
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.financials/new-mgfinancialcompanysaleorder
schema: 2.0.0
---

# New-MgFinancialCompanySaleOrder

## SYNOPSIS
Create new navigation property to salesOrders for financials

## SYNTAX

### CreateExpanded (Default)
```
New-MgFinancialCompanySaleOrder -CompanyId <String> [-BillingPostalAddressCity <String>]
 [-BillingPostalAddressCountryLetterCode <String>] [-BillingPostalAddressPostalCode <String>]
 [-BillingPostalAddressState <String>] [-BillingPostalAddressStreet <String>] [-BillToCustomerId <String>]
 [-BillToCustomerNumber <String>] [-BillToName <String>] [-Code <String>]
 [-CurrencyAmountDecimalPlaces <String>] [-CurrencyAmountRoundingPrecision <Decimal>] [-CurrencyCode <String>]
 [-CurrencyDisplayName <String>] [-CurrencyId <String>] [-CurrencyLastModifiedDateTime <DateTime>]
 [-CurrencySymbol <String>] [-Customer <IMicrosoftGraphCustomer>] [-CustomerId <String>]
 [-CustomerName <String>] [-CustomerNumber <String>] [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax]
 [-Email <String>] [-ExternalDocumentNumber <String>] [-FullyShipped] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-MicrosoftGraphEntityId <String>] [-Number <String>]
 [-OrderDate <DateTime>] [-PartialShipping] [-PaymentTermCalculateDiscountOnCreditMemos]
 [-PaymentTermCode <String>] [-PaymentTermDiscountDateCalculation <String>]
 [-PaymentTermDiscountPercent <Decimal>] [-PaymentTermDisplayName <String>]
 [-PaymentTermDueDateCalculation <String>] [-PaymentTermId <String>]
 [-PaymentTermLastModifiedDateTime <DateTime>] [-PaymentTermsId <String>] [-PhoneNumber <String>]
 [-PricesIncludeTax] [-RequestedDeliveryDate <DateTime>] [-SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]
 [-Salesperson <String>] [-SellingPostalAddressCity <String>]
 [-SellingPostalAddressCountryLetterCode <String>] [-SellingPostalAddressPostalCode <String>]
 [-SellingPostalAddressState <String>] [-SellingPostalAddressStreet <String>]
 [-ShippingPostalAddressCity <String>] [-ShippingPostalAddressCountryLetterCode <String>]
 [-ShippingPostalAddressPostalCode <String>] [-ShippingPostalAddressState <String>]
 [-ShippingPostalAddressStreet <String>] [-ShipToContact <String>] [-ShipToName <String>] [-Status <String>]
 [-TotalAmountExcludingTax <Decimal>] [-TotalAmountIncludingTax <Decimal>] [-TotalTaxAmount <Decimal>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgFinancialCompanySaleOrder -CompanyId <String> -BodyParameter <IMicrosoftGraphSalesOrder> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgFinancialCompanySaleOrder -InputObject <IFinancialsIdentity> -BodyParameter <IMicrosoftGraphSalesOrder>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgFinancialCompanySaleOrder -InputObject <IFinancialsIdentity> [-BillingPostalAddressCity <String>]
 [-BillingPostalAddressCountryLetterCode <String>] [-BillingPostalAddressPostalCode <String>]
 [-BillingPostalAddressState <String>] [-BillingPostalAddressStreet <String>] [-BillToCustomerId <String>]
 [-BillToCustomerNumber <String>] [-BillToName <String>] [-Code <String>]
 [-CurrencyAmountDecimalPlaces <String>] [-CurrencyAmountRoundingPrecision <Decimal>] [-CurrencyCode <String>]
 [-CurrencyDisplayName <String>] [-CurrencyId <String>] [-CurrencyLastModifiedDateTime <DateTime>]
 [-CurrencySymbol <String>] [-Customer <IMicrosoftGraphCustomer>] [-CustomerId <String>]
 [-CustomerName <String>] [-CustomerNumber <String>] [-DiscountAmount <Decimal>] [-DiscountAppliedBeforeTax]
 [-Email <String>] [-ExternalDocumentNumber <String>] [-FullyShipped] [-Id <String>]
 [-LastModifiedDateTime <DateTime>] [-MicrosoftGraphEntityId <String>] [-Number <String>]
 [-OrderDate <DateTime>] [-PartialShipping] [-PaymentTermCalculateDiscountOnCreditMemos]
 [-PaymentTermCode <String>] [-PaymentTermDiscountDateCalculation <String>]
 [-PaymentTermDiscountPercent <Decimal>] [-PaymentTermDisplayName <String>]
 [-PaymentTermDueDateCalculation <String>] [-PaymentTermId <String>]
 [-PaymentTermLastModifiedDateTime <DateTime>] [-PaymentTermsId <String>] [-PhoneNumber <String>]
 [-PricesIncludeTax] [-RequestedDeliveryDate <DateTime>] [-SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]
 [-Salesperson <String>] [-SellingPostalAddressCity <String>]
 [-SellingPostalAddressCountryLetterCode <String>] [-SellingPostalAddressPostalCode <String>]
 [-SellingPostalAddressState <String>] [-SellingPostalAddressStreet <String>]
 [-ShippingPostalAddressCity <String>] [-ShippingPostalAddressCountryLetterCode <String>]
 [-ShippingPostalAddressPostalCode <String>] [-ShippingPostalAddressState <String>]
 [-ShippingPostalAddressStreet <String>] [-ShipToContact <String>] [-ShipToName <String>] [-Status <String>]
 [-TotalAmountExcludingTax <Decimal>] [-TotalAmountIncludingTax <Decimal>] [-TotalTaxAmount <Decimal>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to salesOrders for financials

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

### -BillingPostalAddressCity
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillingPostalAddressCountryLetterCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillingPostalAddressPostalCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillingPostalAddressState
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillingPostalAddressStreet
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillToCustomerId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillToCustomerNumber
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BillToName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
salesOrder
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Code
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CompanyId
key: company-id of company

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyAmountDecimalPlaces
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyAmountRoundingPrecision
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencyLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CurrencySymbol
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Customer
customer
To construct, see NOTES section for CUSTOMER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCustomer
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CustomerId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CustomerName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CustomerNumber
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DiscountAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DiscountAppliedBeforeTax
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Email
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ExternalDocumentNumber
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -FullyShipped
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IFinancialsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MicrosoftGraphEntityId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Number
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OrderDate
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PartialShipping
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermCalculateDiscountOnCreditMemos
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermDiscountDateCalculation
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermDiscountPercent
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermDueDateCalculation
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermId
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PaymentTermsId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PhoneNumber
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PricesIncludeTax
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RequestedDeliveryDate
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SalesOrderLines
.
To construct, see NOTES section for SALESORDERLINES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrderLine[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Salesperson
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SellingPostalAddressCity
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SellingPostalAddressCountryLetterCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SellingPostalAddressPostalCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SellingPostalAddressState
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SellingPostalAddressStreet
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShippingPostalAddressCity
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShippingPostalAddressCountryLetterCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShippingPostalAddressPostalCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShippingPostalAddressState
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShippingPostalAddressStreet
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShipToContact
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ShipToName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Status
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TotalAmountExcludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TotalAmountIncludingTax
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TotalTaxAmount
.

```yaml
Type: System.Decimal
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IFinancialsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSalesOrder

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphSalesOrder>: salesOrder
  - `[Id <String>]`: Read-only.
  - `[BillToCustomerId <String>]`: 
  - `[BillToCustomerNumber <String>]`: 
  - `[BillToName <String>]`: 
  - `[BillingPostalAddressCity <String>]`: 
  - `[BillingPostalAddressCountryLetterCode <String>]`: 
  - `[BillingPostalAddressPostalCode <String>]`: 
  - `[BillingPostalAddressState <String>]`: 
  - `[BillingPostalAddressStreet <String>]`: 
  - `[Code <String>]`: 
  - `[CurrencyAmountDecimalPlaces <String>]`: 
  - `[CurrencyAmountRoundingPrecision <Decimal?>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyDisplayName <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[CurrencyLastModifiedDateTime <DateTime?>]`: 
  - `[CurrencySymbol <String>]`: 
  - `[Customer <IMicrosoftGraphCustomer>]`: customer
    - `[Id <String>]`: Read-only.
    - `[AddressCity <String>]`: 
    - `[AddressCountryLetterCode <String>]`: 
    - `[AddressPostalCode <String>]`: 
    - `[AddressState <String>]`: 
    - `[AddressStreet <String>]`: 
    - `[Blocked <String>]`: 
    - `[Code <String>]`: 
    - `[CurrencyAmountDecimalPlaces <String>]`: 
    - `[CurrencyAmountRoundingPrecision <Decimal?>]`: 
    - `[CurrencyCode <String>]`: 
    - `[CurrencyDisplayName <String>]`: 
    - `[CurrencyId <String>]`: 
    - `[CurrencyLastModifiedDateTime <DateTime?>]`: 
    - `[CurrencySymbol <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Email <String>]`: 
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[Number <String>]`: 
    - `[PaymentMethodCode <String>]`: 
    - `[PaymentMethodDisplayName <String>]`: 
    - `[PaymentMethodId <String>]`: 
    - `[PaymentMethodId1 <String>]`: Read-only.
    - `[PaymentMethodLastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermCalculateDiscountOnCreditMemos <Boolean?>]`: 
    - `[PaymentTermCode <String>]`: 
    - `[PaymentTermDiscountDateCalculation <String>]`: 
    - `[PaymentTermDiscountPercent <Decimal?>]`: 
    - `[PaymentTermDisplayName <String>]`: 
    - `[PaymentTermDueDateCalculation <String>]`: 
    - `[PaymentTermId <String>]`: Read-only.
    - `[PaymentTermLastModifiedDateTime <DateTime?>]`: 
    - `[PaymentTermsId <String>]`: 
    - `[PhoneNumber <String>]`: 
    - `[Picture <IMicrosoftGraphPicture[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Content <Byte[]>]`: 
      - `[ContentType <String>]`: 
      - `[Height <Int32?>]`: 
      - `[Width <Int32?>]`: 
    - `[ShipmentMethodCode <String>]`: 
    - `[ShipmentMethodDisplayName <String>]`: 
    - `[ShipmentMethodId <String>]`: 
    - `[ShipmentMethodId1 <String>]`: Read-only.
    - `[ShipmentMethodLastModifiedDateTime <DateTime?>]`: 
    - `[TaxAreaDisplayName <String>]`: 
    - `[TaxAreaId <String>]`: 
    - `[TaxLiable <Boolean?>]`: 
    - `[TaxRegistrationNumber <String>]`: 
    - `[Type <String>]`: 
    - `[Website <String>]`: 
  - `[CustomerId <String>]`: 
  - `[CustomerName <String>]`: 
  - `[CustomerNumber <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[Email <String>]`: 
  - `[ExternalDocumentNumber <String>]`: 
  - `[FullyShipped <Boolean?>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[Number <String>]`: 
  - `[OrderDate <DateTime?>]`: 
  - `[PartialShipping <Boolean?>]`: 
  - `[PaymentTermCalculateDiscountOnCreditMemos <Boolean?>]`: 
  - `[PaymentTermCode <String>]`: 
  - `[PaymentTermDiscountDateCalculation <String>]`: 
  - `[PaymentTermDiscountPercent <Decimal?>]`: 
  - `[PaymentTermDisplayName <String>]`: 
  - `[PaymentTermDueDateCalculation <String>]`: 
  - `[PaymentTermId <String>]`: Read-only.
  - `[PaymentTermLastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[PricesIncludeTax <Boolean?>]`: 
  - `[RequestedDeliveryDate <DateTime?>]`: 
  - `[SalesOrderLines <IMicrosoftGraphSalesOrderLine[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccountBlocked <Boolean?>]`: 
    - `[AccountCategory <String>]`: 
    - `[AccountDisplayName <String>]`: 
    - `[AccountId <String>]`: 
    - `[AccountId1 <String>]`: Read-only.
    - `[AccountLastModifiedDateTime <DateTime?>]`: 
    - `[AccountNumber <String>]`: 
    - `[AccountSubCategory <String>]`: 
    - `[AmountExcludingTax <Decimal?>]`: 
    - `[AmountIncludingTax <Decimal?>]`: 
    - `[Code <String>]`: 
    - `[Description <String>]`: 
    - `[DiscountAmount <Decimal?>]`: 
    - `[DiscountAppliedBeforeTax <Boolean?>]`: 
    - `[DiscountPercent <Decimal?>]`: 
    - `[DocumentId <String>]`: 
    - `[InvoiceDiscountAllocation <Decimal?>]`: 
    - `[InvoiceQuantity <Decimal?>]`: 
    - `[InvoicedQuantity <Decimal?>]`: 
    - `[ItemBaseUnitOfMeasureId <String>]`: 
    - `[ItemBlocked <Boolean?>]`: 
    - `[ItemCategoryCode <String>]`: 
    - `[ItemCategoryDisplayName <String>]`: 
    - `[ItemCategoryId <String>]`: 
    - `[ItemCategoryLastModifiedDateTime <DateTime?>]`: 
    - `[ItemDisplayName <String>]`: 
    - `[ItemGtin <String>]`: 
    - `[ItemId <String>]`: 
    - `[ItemId1 <String>]`: Read-only.
    - `[ItemInventory <Decimal?>]`: 
    - `[ItemLastModifiedDateTime <DateTime?>]`: 
    - `[ItemNumber <String>]`: 
    - `[ItemPicture <IMicrosoftGraphPicture[]>]`: 
    - `[ItemPriceIncludesTax <Boolean?>]`: 
    - `[ItemTaxGroupCode <String>]`: 
    - `[ItemTaxGroupId <String>]`: 
    - `[ItemType <String>]`: 
    - `[ItemUnitCost <Decimal?>]`: 
    - `[ItemUnitPrice <Decimal?>]`: 
    - `[LineType <String>]`: 
    - `[MicrosoftGraphEntityId <String>]`: Read-only.
    - `[NetAmount <Decimal?>]`: 
    - `[NetAmountIncludingTax <Decimal?>]`: 
    - `[NetTaxAmount <Decimal?>]`: 
    - `[Quantity <Decimal?>]`: 
    - `[Sequence <Int32?>]`: 
    - `[ShipQuantity <Decimal?>]`: 
    - `[ShipmentDate <DateTime?>]`: 
    - `[ShippedQuantity <Decimal?>]`: 
    - `[TaxCode <String>]`: 
    - `[TaxPercent <Decimal?>]`: 
    - `[TotalTaxAmount <Decimal?>]`: 
    - `[UnitOfMeasureId <String>]`: 
    - `[UnitPrice <Decimal?>]`: 
  - `[Salesperson <String>]`: 
  - `[SellingPostalAddressCity <String>]`: 
  - `[SellingPostalAddressCountryLetterCode <String>]`: 
  - `[SellingPostalAddressPostalCode <String>]`: 
  - `[SellingPostalAddressState <String>]`: 
  - `[SellingPostalAddressStreet <String>]`: 
  - `[ShipToContact <String>]`: 
  - `[ShipToName <String>]`: 
  - `[ShippingPostalAddressCity <String>]`: 
  - `[ShippingPostalAddressCountryLetterCode <String>]`: 
  - `[ShippingPostalAddressPostalCode <String>]`: 
  - `[ShippingPostalAddressState <String>]`: 
  - `[ShippingPostalAddressStreet <String>]`: 
  - `[Status <String>]`: 
  - `[TotalAmountExcludingTax <Decimal?>]`: 
  - `[TotalAmountIncludingTax <Decimal?>]`: 
  - `[TotalTaxAmount <Decimal?>]`: 

#### CUSTOMER <IMicrosoftGraphCustomer>: customer
  - `[Id <String>]`: Read-only.
  - `[AddressCity <String>]`: 
  - `[AddressCountryLetterCode <String>]`: 
  - `[AddressPostalCode <String>]`: 
  - `[AddressState <String>]`: 
  - `[AddressStreet <String>]`: 
  - `[Blocked <String>]`: 
  - `[Code <String>]`: 
  - `[CurrencyAmountDecimalPlaces <String>]`: 
  - `[CurrencyAmountRoundingPrecision <Decimal?>]`: 
  - `[CurrencyCode <String>]`: 
  - `[CurrencyDisplayName <String>]`: 
  - `[CurrencyId <String>]`: 
  - `[CurrencyLastModifiedDateTime <DateTime?>]`: 
  - `[CurrencySymbol <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Email <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[Number <String>]`: 
  - `[PaymentMethodCode <String>]`: 
  - `[PaymentMethodDisplayName <String>]`: 
  - `[PaymentMethodId <String>]`: 
  - `[PaymentMethodId1 <String>]`: Read-only.
  - `[PaymentMethodLastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermCalculateDiscountOnCreditMemos <Boolean?>]`: 
  - `[PaymentTermCode <String>]`: 
  - `[PaymentTermDiscountDateCalculation <String>]`: 
  - `[PaymentTermDiscountPercent <Decimal?>]`: 
  - `[PaymentTermDisplayName <String>]`: 
  - `[PaymentTermDueDateCalculation <String>]`: 
  - `[PaymentTermId <String>]`: Read-only.
  - `[PaymentTermLastModifiedDateTime <DateTime?>]`: 
  - `[PaymentTermsId <String>]`: 
  - `[PhoneNumber <String>]`: 
  - `[Picture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[ShipmentMethodCode <String>]`: 
  - `[ShipmentMethodDisplayName <String>]`: 
  - `[ShipmentMethodId <String>]`: 
  - `[ShipmentMethodId1 <String>]`: Read-only.
  - `[ShipmentMethodLastModifiedDateTime <DateTime?>]`: 
  - `[TaxAreaDisplayName <String>]`: 
  - `[TaxAreaId <String>]`: 
  - `[TaxLiable <Boolean?>]`: 
  - `[TaxRegistrationNumber <String>]`: 
  - `[Type <String>]`: 
  - `[Website <String>]`: 

#### INPUTOBJECT <IFinancialsIdentity>: Identity Parameter
  - `[AccountId <String>]`: key: account-id of account
  - `[AgedAccountsPayableId <String>]`: key: agedAccountsPayable-id of agedAccountsPayable
  - `[AgedAccountsReceivableId <String>]`: key: agedAccountsReceivable-id of agedAccountsReceivable
  - `[CompanyId <String>]`: key: company-id of company
  - `[CompanyInformationId <String>]`: key: companyInformation-id of companyInformation
  - `[CountryRegionId <String>]`: key: countryRegion-id of countryRegion
  - `[CurrencyId <String>]`: key: currency-id of currency
  - `[CustomerId <String>]`: key: customer-id of customer
  - `[CustomerPaymentId <String>]`: key: customerPayment-id of customerPayment
  - `[CustomerPaymentJournalId <String>]`: key: customerPaymentJournal-id of customerPaymentJournal
  - `[DimensionId <String>]`: key: dimension-id of dimension
  - `[DimensionValueId <String>]`: key: dimensionValue-id of dimensionValue
  - `[EmployeeId <String>]`: key: employee-id of employee
  - `[GeneralLedgerEntryId <String>]`: key: generalLedgerEntry-id of generalLedgerEntry
  - `[ItemCategoryId <String>]`: key: itemCategory-id of itemCategory
  - `[ItemId <String>]`: key: item-id of item
  - `[JournalId <String>]`: key: journal-id of journal
  - `[JournalLineId <String>]`: key: journalLine-id of journalLine
  - `[PaymentMethodId <String>]`: key: paymentMethod-id of paymentMethod
  - `[PaymentTermId <String>]`: key: paymentTerm-id of paymentTerm
  - `[PictureId <String>]`: key: picture-id of picture
  - `[PurchaseInvoiceId <String>]`: key: purchaseInvoice-id of purchaseInvoice
  - `[PurchaseInvoiceLineId <String>]`: key: purchaseInvoiceLine-id of purchaseInvoiceLine
  - `[SalesCreditMemoId <String>]`: key: salesCreditMemo-id of salesCreditMemo
  - `[SalesCreditMemoLineId <String>]`: key: salesCreditMemoLine-id of salesCreditMemoLine
  - `[SalesInvoiceId <String>]`: key: salesInvoice-id of salesInvoice
  - `[SalesInvoiceLineId <String>]`: key: salesInvoiceLine-id of salesInvoiceLine
  - `[SalesOrderId <String>]`: key: salesOrder-id of salesOrder
  - `[SalesOrderLineId <String>]`: key: salesOrderLine-id of salesOrderLine
  - `[SalesQuoteId <String>]`: key: salesQuote-id of salesQuote
  - `[SalesQuoteLineId <String>]`: key: salesQuoteLine-id of salesQuoteLine
  - `[ShipmentMethodId <String>]`: key: shipmentMethod-id of shipmentMethod
  - `[TaxAreaId <String>]`: key: taxArea-id of taxArea
  - `[TaxGroupId <String>]`: key: taxGroup-id of taxGroup
  - `[UnitOfMeasureId <String>]`: key: unitOfMeasure-id of unitOfMeasure
  - `[VendorId <String>]`: key: vendor-id of vendor

#### SALESORDERLINES <IMicrosoftGraphSalesOrderLine[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccountBlocked <Boolean?>]`: 
  - `[AccountCategory <String>]`: 
  - `[AccountDisplayName <String>]`: 
  - `[AccountId <String>]`: 
  - `[AccountId1 <String>]`: Read-only.
  - `[AccountLastModifiedDateTime <DateTime?>]`: 
  - `[AccountNumber <String>]`: 
  - `[AccountSubCategory <String>]`: 
  - `[AmountExcludingTax <Decimal?>]`: 
  - `[AmountIncludingTax <Decimal?>]`: 
  - `[Code <String>]`: 
  - `[Description <String>]`: 
  - `[DiscountAmount <Decimal?>]`: 
  - `[DiscountAppliedBeforeTax <Boolean?>]`: 
  - `[DiscountPercent <Decimal?>]`: 
  - `[DocumentId <String>]`: 
  - `[InvoiceDiscountAllocation <Decimal?>]`: 
  - `[InvoiceQuantity <Decimal?>]`: 
  - `[InvoicedQuantity <Decimal?>]`: 
  - `[ItemBaseUnitOfMeasureId <String>]`: 
  - `[ItemBlocked <Boolean?>]`: 
  - `[ItemCategoryCode <String>]`: 
  - `[ItemCategoryDisplayName <String>]`: 
  - `[ItemCategoryId <String>]`: 
  - `[ItemCategoryLastModifiedDateTime <DateTime?>]`: 
  - `[ItemDisplayName <String>]`: 
  - `[ItemGtin <String>]`: 
  - `[ItemId <String>]`: 
  - `[ItemId1 <String>]`: Read-only.
  - `[ItemInventory <Decimal?>]`: 
  - `[ItemLastModifiedDateTime <DateTime?>]`: 
  - `[ItemNumber <String>]`: 
  - `[ItemPicture <IMicrosoftGraphPicture[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Content <Byte[]>]`: 
    - `[ContentType <String>]`: 
    - `[Height <Int32?>]`: 
    - `[Width <Int32?>]`: 
  - `[ItemPriceIncludesTax <Boolean?>]`: 
  - `[ItemTaxGroupCode <String>]`: 
  - `[ItemTaxGroupId <String>]`: 
  - `[ItemType <String>]`: 
  - `[ItemUnitCost <Decimal?>]`: 
  - `[ItemUnitPrice <Decimal?>]`: 
  - `[LineType <String>]`: 
  - `[MicrosoftGraphEntityId <String>]`: Read-only.
  - `[NetAmount <Decimal?>]`: 
  - `[NetAmountIncludingTax <Decimal?>]`: 
  - `[NetTaxAmount <Decimal?>]`: 
  - `[Quantity <Decimal?>]`: 
  - `[Sequence <Int32?>]`: 
  - `[ShipQuantity <Decimal?>]`: 
  - `[ShipmentDate <DateTime?>]`: 
  - `[ShippedQuantity <Decimal?>]`: 
  - `[TaxCode <String>]`: 
  - `[TaxPercent <Decimal?>]`: 
  - `[TotalTaxAmount <Decimal?>]`: 
  - `[UnitOfMeasureId <String>]`: 
  - `[UnitPrice <Decimal?>]`: 

## RELATED LINKS

