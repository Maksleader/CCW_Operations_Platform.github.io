using System.Collections.Generic;
using CareProviderPortal.Auditing.Dto;
using CareProviderPortal.Dto;

namespace CareProviderPortal.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
