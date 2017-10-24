using Project.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Web.DAL
{
    public interface ITemplateDAL
    {
        List<Templates> GetAllTemplates();
        Templates GetATemplate(int id);
        Card GetARandomMeme(int id);

    }
}
