using System.Collections.Generic;
using Abp;
using CareProviderPortal.Chat.Dto;
using CareProviderPortal.Dto;

namespace CareProviderPortal.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
