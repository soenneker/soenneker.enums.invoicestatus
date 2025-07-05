using Intellenum;

namespace Soenneker.Enums.InvoiceStatus;

/// <summary>
/// Common invoice statuses
/// </summary>
[Intellenum<string>]
public sealed partial class InvoiceStatus
{
    /// <summary>
    /// Invoice is in draft state and is being prepared or edited.
    /// </summary>
    public static readonly InvoiceStatus Draft = new(nameof(Draft));

    /// <summary>
    /// Invoice is finalized and ready to be sent to the customer.
    /// </summary>
    public static readonly InvoiceStatus Pending = new(nameof(Pending));

    /// <summary>
    /// Invoice has been sent to the customer and is awaiting payment.
    /// </summary>
    public static readonly InvoiceStatus Sent = new(nameof(Sent));

    /// <summary>
    /// Invoice has been fully paid by the customer.
    /// </summary>
    public static readonly InvoiceStatus Paid = new(nameof(Paid));

    /// <summary>
    /// Invoice is past its due date and payment is overdue.
    /// </summary>
    public static readonly InvoiceStatus Overdue = new(nameof(Overdue));

    /// <summary>
    /// Invoice has been cancelled and is no longer valid.
    /// </summary>
    public static readonly InvoiceStatus Cancelled = new(nameof(Cancelled));

    /// <summary>
    /// Invoice has been voided and is no longer valid for payment.
    /// </summary>
    public static readonly InvoiceStatus Void = new(nameof(Void));
}
