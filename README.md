[![](https://img.shields.io/nuget/v/soenneker.enums.invoicestatus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.invoicestatus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.invoicestatus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.invoicestatus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.invoicestatus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.invoicestatus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.invoicestatus/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.invoicestatus/actions/workflows/codeql.yml)

# Soenneker.Enums.InvoiceStatus

Identifies the current lifecycle and payment state of an invoice.

## Install

```bash
dotnet add package Soenneker.Enums.InvoiceStatus
```

## What you get

- `InvoiceStatus` — Identifies the current lifecycle and payment state of an invoice.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `InvoiceStatus.Draft` | Invoice is in draft state and is being prepared or edited. | Invoice is in draft state and is being prepared or edited. |
| `InvoiceStatus.Pending` | Invoice is finalized and ready to be sent to the customer. | Invoice is finalized and ready to be sent to the customer. |
| `InvoiceStatus.Sent` | Invoice has been sent to the customer and is awaiting payment. | Invoice has been sent to the customer and is awaiting payment. |
| `InvoiceStatus.Paid` | Invoice has been fully paid by the customer. | Invoice has been fully paid by the customer. |
| `InvoiceStatus.Overdue` | Invoice is past its due date and payment is overdue. | Invoice is past its due date and payment is overdue. |
| `InvoiceStatus.Cancelled` | Invoice has been cancelled and is no longer valid. | Invoice has been cancelled and is no longer valid. |
| `InvoiceStatus.Void` | Invoice has been voided and is no longer valid for payment. | Invoice has been voided and is no longer valid for payment. |
