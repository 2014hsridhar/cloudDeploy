//Appleseed Dependencies 
using Appleseed.Framework;
using Appleseed.Framework.Security;
using Appleseed.Framework.Settings;
using Appleseed.Framework.Site.Configuration;
using Appleseed.Framework.Web.UI.WebControls;
using History = Appleseed.Framework.History;
using Page = Appleseed.Framework.Web.UI.Page;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.Text;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace moduleAppleSeed.DesktopModules.CustomModules.cloudMod
{
    public partial class cloudMod : PortalModuleControl
    //public partial class cloudMod : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hello WOrld. I am finally on the cloud!");
        }
    }
}