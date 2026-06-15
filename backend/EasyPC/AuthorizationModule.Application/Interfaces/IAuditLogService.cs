using AuthorizationModule.Application.DTOs;
using AuthorizationModule.Application.Queries.GetAuditLogs;
using AuthorizationModule.Domain.Entities;
using Shared.Application.Common;

namespace AuthorizationModule.Application.Interfaces;

public interface IAuditLogService
{
    Task LogAsync(AuditLog auditLog, CancellationToken cancellationToken);
    Task<PageResult<AuditLogDto>> GetPagedAsync(GetAuditLogsQuery query, CancellationToken cancellationToken = default);
}