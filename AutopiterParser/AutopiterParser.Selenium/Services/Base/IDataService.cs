using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutopiterParser.Selenium.Services.Base
{
    public interface IDataService
    {
        void SetPage(string url);
        void SingUp();
        void FindArticle(string article);
    }
}
