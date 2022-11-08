using Abp.Application.Services.Dto;

namespace CareProviderPortal.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}