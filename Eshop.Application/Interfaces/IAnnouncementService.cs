using System;
using System.Collections.Generic;
using System.Text;
using Eshop.Application.ViewModels.System;
using Eshop.Data.Entities;
using Eshop.Infrastructure.Interfaces;
using Eshop.Utilities.Dtos;

namespace Eshop.Application.Interfaces
{
    public interface IAnnouncementService
    {
        PagedResult<AnnouncementViewModel> GetAllUnReadPaging(Guid userId, int pageIndex, int pageSize);

        bool MarkAsRead(Guid userId, string id);
    }
}
