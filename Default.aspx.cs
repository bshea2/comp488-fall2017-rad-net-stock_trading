﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { }
    }

    protected void GetQuotes(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
       
        
        //Response.Write(Request.Form("Ticker"));
    }
        
}