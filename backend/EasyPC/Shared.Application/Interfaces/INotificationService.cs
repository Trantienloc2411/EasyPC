using Shared.Domain.Enums;

namespace Shared.Application.Interfaces;

public interface INotificationService
{
    Task NotifyAsync(
        string title,
        string message,
        NotificationType type,
        NotificationRole role,
        Guid? referenceId = null,
        string? referenceType = null,
        CancellationToken cancellationToken = default);
}