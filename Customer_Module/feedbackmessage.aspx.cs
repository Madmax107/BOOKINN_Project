﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookInn.Customer_Module
{
    public partial class feedbackmessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void success_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}