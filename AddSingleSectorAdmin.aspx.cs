using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace Onder1
{
    public partial class AddSingleSectorAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string SectortId = Request.QueryString["SectorID"];
            if (!IsPostBack)
            {

                PopulateControls();

            }
            else
            if ((SectortId != null) && (CatalogAccess.CheckInSectors(SectortId)))
            {


                Style bodyStyle = new Style();
                Style BackgoundStyle = new Style();

                string hex = "";


                hex = "#ff9102";


                BackgoundStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
                bodyStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(hex);

                Style BorderStyle1 = new Style();
                Color BorderColor = new Color();
                BorderColor = System.Drawing.ColorTranslator.FromHtml(hex);
                BorderStyle1.BorderStyle = BorderStyle.Solid;
                BorderStyle1.BorderWidth = Unit.Parse("2");
                BorderStyle1.BorderColor = BorderColor;

                Page.Header.StyleSheet.CreateStyleRule(BorderStyle1, null, ".BorderSectorColor");
                Page.Header.StyleSheet.CreateStyleRule(bodyStyle, null, ".SectorColor");
                Page.Header.StyleSheet.CreateStyleRule(BackgoundStyle, null, ".SectorBackgoundColor");

            }
        }

        private void PopulateControls()
        {


            string SectortId = Request.QueryString["SectorID"];
            Style bodyStyle = new Style();
            Style BackgoundStyle = new Style();

            string hex = "";


            hex = "#ff9102";


            BackgoundStyle.BackColor = System.Drawing.ColorTranslator.FromHtml(hex);
            bodyStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml(hex);

            Style BorderStyle1 = new Style();
            Color BorderColor = new Color();
            BorderColor = System.Drawing.ColorTranslator.FromHtml(hex);
            BorderStyle1.BorderStyle = BorderStyle.Solid;
            BorderStyle1.BorderWidth = Unit.Parse("2");
            BorderStyle1.BorderColor = BorderColor;

            Page.Header.StyleSheet.CreateStyleRule(BorderStyle1, null, ".BorderSectorColor");
            Page.Header.StyleSheet.CreateStyleRule(bodyStyle, null, ".SectorColor");
            Page.Header.StyleSheet.CreateStyleRule(BackgoundStyle, null, ".SectorBackgoundColor");
            
        }


        protected void CreateButton_Click(object sender, EventArgs e)
        {

            int CreateSectorID = -3;
            //string sectorID = DropDownListProjects.SelectedValue;

            string title = TitleTextBox.Text;
            string description = DetailsTextBox.Text;
            //int benefitNo = int.Parse(BenefitNoTextBox.Text);
            string notes = NotesTextBox.Text;
            byte[] content;
            bool success = false;
            byte[] struct1;
            if ((fileupload.HasFile))
            {
                content = fileupload.FileBytes;
                if ((fileupload1.HasFile))
                {
                    struct1 = fileupload1.FileBytes;
                    success = CatalogAccess.CreateSector(out CreateSectorID, title, description, struct1, content, notes);
                }
            }

            if (success)
            {
                Response.Redirect("SingleSectorAdmin.aspx?SectorID=" + CreateSectorID.ToString() + "&Publish=true");
            }
            else
            {
                statusLabel.Text = "هناك خطأ";
            }



        }
    }
}