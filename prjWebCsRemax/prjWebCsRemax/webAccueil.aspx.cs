﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsRemax
{
    public partial class webAccueil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMaison_Click(object sender, EventArgs e)
        {
            Server.Transfer("webMaison.aspx");
        }

        protected void btnAgent_Click(object sender, EventArgs e)
        {
            Server.Transfer("webAgent.aspx");
        }
    }
}