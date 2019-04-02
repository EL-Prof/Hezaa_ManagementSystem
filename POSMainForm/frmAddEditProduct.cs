using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using MySql.Data.MySqlClient;

namespace POSMainForm
{
    public partial class frmAddEditProduct : Form
    {
        int productID;
        int categoryID;
        public frmAddEditProduct(int prodID)
        {
            InitializeComponent();
            productID = prodID;
        }

        private void GetProductNo()
        {
            try
            {
                SQLConn.sqL = "SELECT ProductNo FROM Product ORDER BY ProductNo DESC";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    lblProductNo.Text = (Convert.ToInt32(SQLConn.dr["ProductNo"]) + 1).ToString();
                }
                else
                {
                    lblProductNo.Text = "1";
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }


        private void LoadUpdateCategory()
        {
            try
            {
                SQLConn.sqL = "SELECT ProductNo, ProductCode, P.Description, Color, P.CategoryNo, CategoryName, UnitPrice, StocksOnHand, Size FROM Product as P LEFT JOIN Category as C ON P.CategoryNo = C.CategoryNo WHERE ProductNo = '" + productID + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                if (SQLConn.dr.Read() == true)
                {
                    lblProductNo.Text = SQLConn.dr["ProductNo"].ToString();
                    txtProductCode.Text = SQLConn.dr["ProductCode"].ToString();
                    txtDescription.Text = SQLConn.dr["Description"].ToString();
                    txtColor.Text = SQLConn.dr["Color"].ToString();
                    txtCategory.Text = SQLConn.dr["CategoryName"].ToString();
                    txtCategory.Tag = SQLConn.dr["CategoryNo"];
                    txtUnitPrice.Text = Strings.Format(SQLConn.dr["UnitPrice"], "#,##0.00");
                    txtStocksOnHand.Text = SQLConn.dr["StocksOnHand"].ToString();
                    txtSize.Text = SQLConn.dr["Size"].ToString();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }


        private void AddProducts()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO Product(ProductCode, Description, Color, UnitPrice, StocksOnHand, Size, CategoryNo) VALUES('" + txtProductCode.Text + "', '" + txtDescription.Text + "', '" + txtColor.Text.Trim() + "', '" + txtUnitPrice.Text.Replace(",", "") + "', '" + txtStocksOnHand.Text.Replace(",", "") + "', '" + txtSize.Text + "', '" + categoryID + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
                Interaction.MsgBox("Product successfully added.", MsgBoxStyle.Information, "Add Product");
                AddStockIn();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void AddStockIn()
        {
            try
            {
                SQLConn.sqL = "INSERT INTO StockIn(ProductNo, Quantity, DateIn) Values('" + lblProductNo.Text + "', '" + txtStocksOnHand.Text + "', '" + System.DateTime.Now.ToString("MM/dd/yyyy") + "')";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void UpdateProduct()
        {
            try
            {
                SQLConn.sqL = "UPDATE Product SET ProductCode = '" + txtProductCode.Text + "', Description = '" + txtDescription.Text + "', Color = '" + txtColor.Text.Trim() + "', UnitPrice = '" + txtUnitPrice.Text.Replace(",", "") + "', StocksOnHand = '" + txtStocksOnHand.Text.Replace(",", "") + "', Size = '" + txtSize.Text + "', CategoryNo ='" + categoryID + "' WHERE ProductNo = '" + productID + "'";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.cmd.ExecuteNonQuery();

                Interaction.MsgBox("Product successfully Updated.", MsgBoxStyle.Information, "Update Product");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            finally
            {
                SQLConn.cmd.Dispose();
                SQLConn.conn.Close();
            }
        }

        private void ClearFields()
        {
            lblProductNo.Text = "";
            txtProductCode.Text = "";
            txtDescription.Text = "";
            txtColor.Text = "";
            txtCategory.Text = "";
            txtUnitPrice.Text = "";
            txtStocksOnHand.Text = "";
            txtSize.Text = "";
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            if (SQLConn.adding == true)
            {
                lblTitle.Text = "Adding New Product";
                ClearFields();
                GetProductNo();
            }
            else
            {
                lblTitle.Text = "Updating Product";
                LoadUpdateCategory();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                Interaction.MsgBox("Please select category.", MsgBoxStyle.Information, "Category");
                return;
            }
            
            if (SQLConn.adding == true)
            {
                AddProducts();
            }
            else
            {
                UpdateProduct();
               
            }

            if (System.Windows.Forms.Application.OpenForms["frmListProduct"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmListProduct"] as frmListProduct).LoadProducts("");
            }

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmSelectCategory flc = new frmSelectCategory(this);
            flc.ShowDialog();
        }

        public string Category
        {
            get { return txtCategory.Text; }
            set { txtCategory.Text = value; }
        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

    }
}
