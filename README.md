[![](https://img.shields.io/nuget/v/soenneker.enums.invoicestatus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.invoicestatus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.invoicestatus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.invoicestatus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.invoicestatus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.invoicestatus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.invoicestatus/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.invoicestatus/actions/workflows/codeql.yml)

# Soenneker.Enums.InvoiceStatus

A string-backed enum-value type for carrying an invoice lifecycle or payment-status label through application and API contracts.

## Install

```bash
dotnet add package Soenneker.Enums.InvoiceStatus
```

## Usage

```csharp
using Soenneker.Enums.InvoiceStatus;

InvoiceStatus status = InvoiceStatus.Sent;
string wireValue = status.Value; // "Sent"

if (InvoiceStatus.TryFromValue(input, out InvoiceStatus? parsed))
{
    // Validate the requested transition in your domain layer
}
```

Available values:

- `Draft` — being prepared or edited
- `Pending` — finalized and ready to send
- `Sent` — delivered to the customer and awaiting payment
- `Paid` — fully paid
- `Overdue` — past its due date
- `Cancelled` — cancelled and no longer valid
- `Void` — voided and no longer payable

`System.Text.Json` serializes the type as the shown string value. `FromValue` throws for unknown input; use `TryFromValue` when parsing requests or provider data. `FromName` and `TryFromName` are also generated.

This package supplies status labels only. It does not enforce allowed transitions, calculate whether an invoice is overdue, record payments, or distinguish the accounting and audit treatment of `Cancelled` versus `Void`. A `Paid` value is not proof of settlement; derive and persist status changes from trusted payment and invoice records in the domain layer.
