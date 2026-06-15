using AuthorizationModule.Application.DTOs;
using AuthorizationModule.Application.Interfaces;
using MediatR;
using Shared.Application.Common;

namespace AuthorizationModule.Application.Queries.GetAuditLogs;

public class GetAuditLogsQueryHandler(IAuditLogService auditLogService)
    : IRequestHandler<GetAuditLogsQuery, PageResult<AuditLogDto>>
{
    public Task<PageResult<AuditLogDto>> Handle(GetAuditLogsQuery request, CancellationToken cancellationToken)
        => auditLogService.GetPagedAsync(request, cancellationToken);
}
