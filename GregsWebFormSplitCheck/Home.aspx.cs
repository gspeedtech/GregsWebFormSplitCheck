using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace GregsWebFormSplitCheck
{
    public partial class _Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvCheck_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                GridView innerGridView = (GridView)e.Row.FindControl("gvCheckItems");
                innerGridView.DataSource = ((GregsCommon.CheckItem)e.Row.DataItem);
                innerGridView.DataBind();
            }
        }
    }
}