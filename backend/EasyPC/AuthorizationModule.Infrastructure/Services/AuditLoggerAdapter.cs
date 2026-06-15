using AuthorizationModule.Application.Interfaces;
using AuthorizationModule.Domain.Entities;
using Shared.Application.Interfaces;

namespace AuthorizationModule.Infrastructure.Services;

public class AuditLoggerAdapter(IAuditLogService auditLogService) : IAuditLogger
{
    public Task LogAsync(
        string action,
        bool isSuccess,
        Guid? userId = null,
        string? username = null,
        string? description = null,
        CancellationToken cancellationToken = default)
        => auditLogService.LogAsync(new AuditLog
        {
            Action = action,
            IsSuccess = isSuccess,
            UserId = userId,
            UserName =  username,
            Description = description,
            Timestamp = DateTime.UtcNow
        }, cancellationToken);
}