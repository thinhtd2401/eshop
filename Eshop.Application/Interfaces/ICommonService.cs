using System;
using System.Collections.Generic;
using System.Text;
using Eshop.Application.ViewModels.Common;

namespace Eshop.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
