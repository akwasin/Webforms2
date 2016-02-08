using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryDropDown.Visible = false;
        }

        protected void runSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorksLT2012;User ID=Akwasi; Password=Root;Integrated Security = True");

            string sqlQueryCategory = "SELECT * FROM SalesLT.ProductCategory ORDER BY Name ASC";
            SqlCommand cmd = new SqlCommand(sqlQueryCategory, con);
            SqlDataReader oreader;
            try
            {
                con.Open();
                oreader = cmd.ExecuteReader();
                foreach (var name in oreader)
                {
                    Label namelabel = new Label { Text = oreader["Name"].ToString() };
                    TableCell tableCell = new TableCell();
                    tableCell.CssClass = "tdclass";
                    tableCell.Controls.Add(namelabel);
                    TableRow row = new TableRow();
                    row.Controls.Add(tableCell);

                    CategoryTable.Controls.Add(row);
                    CategoryDropDown.Items.Add(new ListItem($"{oreader["Name"].ToString()}"));
                }
                oreader.Close();
                oreader.Dispose();
            }
            catch (Exception ex)
            {
                // do error
            }
            finally
            {
                con.Close();
                con.Dispose();
                cmd.Dispose();
            }
            CategoryDropDown.DataBind();
            CategoryDropDown.Visible = true;
        }

        protected void InsertCategory_Click(object sender, EventArgs e)
        {
            CategoryLabelBox.Visible = true;

            SqlConnection sqlConnection = new SqlConnection("Server=localhost; Database=AdventureWorksLT2012; Integrated Security=true");

            string sqlInsert = $"INSERT INTO SalesLT.ProductCategory (Name) VALUES ('{InsertCategoryTextBox.Text}')";
            SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection);
            try
            {
                sqlConnection.Open();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    CategoryLabelBox.Text = $"{InsertCategoryTextBox.Text} was added to categories. Run query to see all categories.";
                    addButton.Text = "Add another category";
                }
            }
            catch (Exception ex)
            {
                CategoryLabelBox.Text = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlCommand.Dispose();
            }
        }
    }
}