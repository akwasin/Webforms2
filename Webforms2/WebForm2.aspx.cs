﻿using System;
using System.Collections.Generic;
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
            // LoadPerson();
        }

        public void LoadPerson()
        {
            // Glöm inte att byta uppgifterna på följande rad.
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2012;User ID=Akwasi; Password=Root;Integrated Security = True");

            string sqlQueryPerson = "SELECT FirstName, LastName FROM Person.Person";
            SqlCommand cmd = new SqlCommand(sqlQueryPerson, con);
            SqlDataReader oreader;
            try
            {
                con.Open();
                oreader = cmd.ExecuteReader();
                foreach (var name in oreader)
                {
                    Label firstNamelabel = new Label { Text = oreader["FirstName"].ToString()};
                    TableCell firstTableCell = new TableCell();
                    firstTableCell.CssClass = "tdclass";
                    firstTableCell.Controls.Add(firstNamelabel);

                    Label lastNamelabel = new Label { Text = oreader["LastName"].ToString() };
                    TableCell lastTableCell = new TableCell();
                    lastTableCell.CssClass = "tdclass";
                    lastTableCell.Controls.Add(lastNamelabel);

                    TableRow row = new TableRow();
                    row.Controls.Add(firstTableCell);
                    row.Controls.Add(lastTableCell);

                    nameTable.Controls.Add(row);
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

        }

        protected void runSearch_Click(object sender, EventArgs e)
        {
            string searchList = this.searchList.SelectedItem.Text;
            // Glöm inte att byta uppgifterna på följande rad.
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2012;User ID=Akwasi; Password=Root;Integrated Security = True");

            string sqlQueryPerson = $"SELECT {searchList} FROM Person.Person";
            SqlCommand cmd = new SqlCommand(sqlQueryPerson, con);
            SqlDataReader oreader;
            try
            {
                con.Open();
                oreader = cmd.ExecuteReader();
                foreach (var name in oreader)
                {
                    Label firstNamelabel = new Label { Text = oreader[$"{searchList}"].ToString() };
                    TableCell firstTableCell = new TableCell();
                    firstTableCell.CssClass = "tdclass";
                    firstTableCell.Controls.Add(firstNamelabel);

                    TableRow row = new TableRow();
                    row.Controls.Add(firstTableCell);

                    nameTable.Controls.Add(row);
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

            //Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void addPerson_Click(object sender, EventArgs e)
        {
            string addFirstName = addBoxFirstName.Text;
            string addLastname = addBoxLastName.Text;
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2012;User ID=Akwasi; Password=Root;Integrated Security = True");

            // HÄR NERE ÄR JAG
            string sqlQueryPerson = $"SELECT {addFirstName} FROM Person.Person";
            SqlCommand cmd = new SqlCommand(sqlQueryPerson, con);
            SqlDataReader oreader;
            try
            {
                con.Open();
                oreader = cmd.ExecuteReader();
                foreach (var name in oreader)
                {
                    Label firstNamelabel = new Label { Text = oreader[$"{searchString}"].ToString() };
                    TableCell firstTableCell = new TableCell();
                    firstTableCell.CssClass = "tdclass";
                    firstTableCell.Controls.Add(firstNamelabel);

                    TableRow row = new TableRow();
                    row.Controls.Add(firstTableCell);

                    nameTable.Controls.Add(row);
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

            //Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

    }
}