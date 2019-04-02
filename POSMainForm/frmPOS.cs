using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POSMainForm
{
    public partial class frmPOS : Form
    {
        #region searchBar

        private Rectangle pnlLeft1Original;

        private Rectangle txtBarCodeOriginal;
        private Rectangle txtProductCodeOriginal;
        private Rectangle txtItemDescOriginal;
        private Rectangle txtUnitPriceOriginal;
        private Rectangle txtQuantityOriginal;
        private Rectangle txtTotalOriginal;


        private Rectangle lblBarCodeOriginal;
        private Rectangle lblProductCodeOriginal;
        private Rectangle lblItemDescOriginal;
        private Rectangle lblUnitPriceOriginal;
        private Rectangle lblQuantityOriginal;
        private Rectangle lblTotalOriginal;

        private AutoCompleteStringCollection produtCodeCollection; 
        #endregion

        #region InvoiceNumber
        private Rectangle pnlInvoiceNumberOriginal;
        private Rectangle lblInvoiceNumberOriginal;
        private Rectangle lblInvoiceNumberValueOriginal;
        #endregion

        #region lstViewProduct
        private Rectangle pnlLstViewProductOriginal;
        private Rectangle lstViewProductOriginal;

        #endregion

        #region Staff Info
        private Rectangle pnlStaffInfoOriginal;
        private Rectangle LblStaffInfoOriginal;
        private Rectangle lblPositionOriginal;
        private Rectangle lblPositionValueOriginal;
        private Rectangle lblNameOriginal;
        private Rectangle lblNameValueOriginal;
        #endregion

        #region Basket Info
        private Rectangle pnlBasketInfoOriginal;
        private Rectangle lblBasketInfoOriginal;
        private Rectangle lblTotalItemsOriginal;
        private Rectangle lblValOriginal;
        private Rectangle lblSubTotalOriginal;
        private Rectangle lblTotalAmountOriginal;
        private Rectangle txtTotalItemsOriginal;
        private Rectangle txtValOriginal;
        private Rectangle txtSubTotalOriginal;
        private Rectangle txtTotalAmountOriginal;
        #endregion

        #region Transactions Buttons
        private Rectangle pnlTransactionOriginal;
        private Rectangle btnNewOriginal;
        private Rectangle btnRemoveOriginal;
        private Rectangle btnSettleOriginal;
        private Rectangle btnDiscountOriginal;
        private Rectangle btnEnterOriginal;
        private Rectangle btnCloseOriginal;
        private Rectangle btnRePrintOriginal;
        #endregion

        private Size formOriginalSize;
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            //LoadProducts("");
            loadProductIDs();
            formOriginalSize = this.Size;

            #region SearchBar
            pnlLeft1Original = new Rectangle(pnlLeft1.Location.X, pnlLeft1.Location.Y, pnlLeft1.Width, pnlLeft1.Height);

            txtBarCodeOriginal = new Rectangle(txtBarCode.Location.X, txtBarCode.Location.Y, txtBarCode.Width, txtBarCode.Height);
            txtProductCodeOriginal = new Rectangle(txtProductCode.Location.X, txtProductCode.Location.Y, txtProductCode.Width, txtProductCode.Height);
            txtItemDescOriginal = new Rectangle(txtItemDescription.Location.X, txtItemDescription.Location.Y, txtItemDescription.Width, txtItemDescription.Height);
            txtUnitPriceOriginal = new Rectangle(txtUnitPrice.Location.X, txtUnitPrice.Location.Y, txtUnitPrice.Width, txtUnitPrice.Height);
            txtQuantityOriginal = new Rectangle(txtQuantity.Location.X, txtQuantity.Location.Y, txtQuantity.Width, txtQuantity.Height);
            txtTotalOriginal = new Rectangle(txtTotalPrice.Location.X, txtTotalPrice.Location.Y, txtTotalPrice.Width, txtTotalPrice.Height);

            lblBarCodeOriginal = new Rectangle(lblBarCode.Location.X, lblBarCode.Location.Y, lblBarCode.Width, lblBarCode.Height);
            lblProductCodeOriginal = new Rectangle(lblProductcode.Location.X, lblProductcode.Location.Y, lblProductcode.Width, lblProductcode.Height);
            lblItemDescOriginal = new Rectangle(lblItemDescription.Location.X, lblItemDescription.Location.Y, lblItemDescription.Width, lblItemDescription.Height);
            lblUnitPriceOriginal = new Rectangle(lblUnitPrice.Location.X, lblUnitPrice.Location.Y, lblUnitPrice.Width, lblUnitPrice.Height);
            lblQuantityOriginal = new Rectangle(lblQuantity.Location.X, lblQuantity.Location.Y, lblQuantity.Width, lblQuantity.Height);
            lblTotalOriginal = new Rectangle(lblTotalPrice.Location.X, lblTotalPrice.Location.Y, lblTotalPrice.Width, lblTotalPrice.Height);
            #endregion

            #region InvoiceNumbers
            pnlInvoiceNumberOriginal = new Rectangle(pnlInvoiceNumber.Location.X, pnlInvoiceNumber.Location.Y, pnlInvoiceNumber.Width, pnlInvoiceNumber.Height);
            lblInvoiceNumberOriginal = new Rectangle(lblInvoiceNumber.Location.X, lblInvoiceNumber.Location.Y, lblInvoiceNumber.Width, lblInvoiceNumber.Height);
            lblInvoiceNumberValueOriginal = new Rectangle(lblInvoiceNumberValue.Location.X, lblInvoiceNumberValue.Location.Y, lblInvoiceNumberValue.Width, lblInvoiceNumberValue.Height);
            #endregion

            #region ProductList
            lstViewProductOriginal = new Rectangle(lstviewProduct.Location.X, lstviewProduct.Location.Y, lstviewProduct.Width, lstviewProduct.Height);
            pnlLstViewProductOriginal = new Rectangle(pnlLstViewProduct.Location.X, pnlLstViewProduct.Location.Y, pnlLstViewProduct.Width, pnlLstViewProduct.Height);
            #endregion

            #region Staff Info
            pnlStaffInfoOriginal = new Rectangle(PnlStaffInfo.Location.X, PnlStaffInfo.Location.Y, PnlStaffInfo.Width, PnlStaffInfo.Height);
            LblStaffInfoOriginal = new Rectangle(lblStaffInfo.Location.X, lblStaffInfo.Location.Y, lblStaffInfo.Width, lblStaffInfo.Height);
            lblPositionOriginal = new Rectangle(lblPosition.Location.X, lblPosition.Location.Y, lblPosition.Width, lblPosition.Height);
            lblPositionValueOriginal = new Rectangle(lblPositionValue.Location.X, lblPositionValue.Location.Y, lblPositionValue.Width, lblPositionValue.Height);
            lblNameOriginal = new Rectangle(lblName.Location.X, lblName.Location.Y, lblName.Width, lblName.Height);
            lblNameValueOriginal = new Rectangle(lblNameValue.Location.X, lblNameValue.Location.Y, lblNameValue.Width, lblNameValue.Height);
            #endregion

            #region Basket Info
            pnlBasketInfoOriginal = new Rectangle(pnlBasketInfo.Location.X, pnlBasketInfo.Location.Y, pnlBasketInfo.Width, pnlBasketInfo.Height);
            lblBasketInfoOriginal = new Rectangle(lblBasketInfo.Location.X, lblBasketInfo.Location.Y, lblBasketInfo.Width, lblBasketInfo.Height);
            txtTotalItemsOriginal = new Rectangle(txtTotalItems.Location.X, txtTotalItems.Location.Y, txtTotalItems.Width, txtTotalItems.Height);
            lblTotalItemsOriginal = new Rectangle(lblTotalItems.Location.X, lblTotalItems.Location.Y, lblTotalItems.Width, lblTotalItems.Height);
            txtSubTotalOriginal = new Rectangle(txtSubTotal.Location.X, txtSubTotal.Location.Y, txtSubTotal.Width, txtSubTotal.Height);
            lblSubTotalOriginal = new Rectangle(lblSubTotal.Location.X, lblSubTotal.Location.Y, lblSubTotal.Width, lblSubTotal.Height);
            txtValOriginal = new Rectangle(txtVal.Location.X, txtVal.Location.Y, txtVal.Width, txtVal.Height);
            lblValOriginal = new Rectangle(lblValue.Location.X, lblValue.Location.Y, lblValue.Width, lblValue.Height);
            txtTotalAmountOriginal = new Rectangle(txtTotalAmount.Location.X, txtTotalAmount.Location.Y, txtTotalAmount.Width, txtTotalAmount.Height);
            lblTotalAmountOriginal = new Rectangle(lblTotalAmount.Location.X, lblTotalAmount.Location.Y, lblTotalAmount.Width, lblTotalAmount.Height);
            #endregion

            #region Buttons Transactions
            pnlTransactionOriginal = new Rectangle(pnlTransactions.Location.X, pnlTransactions.Location.Y, pnlTransactions.Width, pnlTransactions.Height);
            btnNewOriginal = new Rectangle(btnNew.Location.X, btnNew.Location.Y, btnNew.Width, btnNew.Height);
            btnRemoveOriginal = new Rectangle(btnRemove.Location.X, btnRemove.Location.Y, btnRemove.Width, btnRemove.Height);
            btnSettleOriginal = new Rectangle(btnSettle.Location.X, btnSettle.Location.Y, btnSettle.Width, btnSettle.Height);
            btnDiscountOriginal = new Rectangle(btnDiscount.Location.X, btnDiscount.Location.Y, btnDiscount.Width, btnDiscount.Height);
            btnEnterOriginal = new Rectangle(btnEnter.Location.X, btnEnter.Location.Y, btnEnter.Width, btnEnter.Height);
            btnCloseOriginal = new Rectangle(btnClose.Location.X, btnClose.Location.Y, btnClose.Width, btnClose.Height);
            btnRePrintOriginal = new Rectangle(btnRePrint.Location.X, btnRePrint.Location.Y, btnRePrint.Width, btnRePrint.Height);

            #endregion

           // FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //TopMost = true;
        }

        private void frmPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                   FormBorderStyle = FormBorderStyle.Sizable;
                   WindowState = FormWindowState.Normal;
                    TopMost = false;

               //  this.Close();

            }
        }

        private void resizeChildrenControl()
        {
            #region SearchBar
            resizeControl(pnlLeft1Original, pnlLeft1);

            resizeControl(txtBarCodeOriginal, txtBarCode);
            resizeControl(txtProductCodeOriginal, txtProductCode);
            resizeControl(txtItemDescOriginal, txtItemDescription);
            resizeControl(txtUnitPriceOriginal, txtUnitPrice);
            resizeControl(txtQuantityOriginal, txtQuantity);
            resizeControl(txtTotalOriginal, txtTotalPrice);


            resizeControl(lblBarCodeOriginal, lblBarCode);
            resizeControl(lblProductCodeOriginal, lblProductcode);
            resizeControl(lblItemDescOriginal, lblItemDescription);
            resizeControl(lblUnitPriceOriginal, lblUnitPrice);
            resizeControl(lblQuantityOriginal, lblQuantity);
            resizeControl(lblTotalOriginal, lblTotalPrice);
            #endregion

            #region InvoiceNumber
            resizeControl(pnlInvoiceNumberOriginal, pnlInvoiceNumber);
            resizeControl(lblInvoiceNumberOriginal, lblInvoiceNumber);
            resizeControl(lblInvoiceNumberValueOriginal, lblInvoiceNumberValue);
            #endregion

            #region ProductList
            resizeControl(pnlLstViewProductOriginal, pnlLstViewProduct);
            resizeControl(lstViewProductOriginal, lstviewProduct);
            #endregion

            #region Staff Info
            resizeControl(pnlStaffInfoOriginal, PnlStaffInfo);
            resizeControl(LblStaffInfoOriginal, lblStaffInfo);
            resizeControl(lblPositionOriginal, lblPosition);
            resizeControl(lblPositionValueOriginal, lblPositionValue);
            resizeControl(lblNameOriginal, lblName);
            resizeControl(lblNameValueOriginal, lblNameValue);
            #endregion

            #region Basket Info
            resizeControl(pnlBasketInfoOriginal, pnlBasketInfo);
            resizeControl(lblBasketInfoOriginal, lblBasketInfo);
            resizeControl(txtTotalItemsOriginal, txtTotalItems);
            resizeControl(lblTotalItemsOriginal, lblTotalItems);
            resizeControl(txtValOriginal, txtVal);
            resizeControl(lblValOriginal, lblValue);
            resizeControl(txtSubTotalOriginal, txtSubTotal);
            resizeControl(lblSubTotalOriginal, lblSubTotal);
            resizeControl(txtTotalAmountOriginal, txtTotalAmount);
            resizeControl(lblTotalAmountOriginal, lblTotalAmount);
            #endregion

            #region Buttons transactions
            resizeControl(pnlTransactionOriginal, pnlTransactions);
            resizeControl(btnNewOriginal, btnNew);
            resizeControl(btnRemoveOriginal, btnRemove);
            resizeControl(btnEnterOriginal, btnEnter);
            resizeControl(btnDiscountOriginal, btnDiscount);
            resizeControl(btnSettleOriginal, btnSettle);
            resizeControl(btnCloseOriginal, btnClose);
            resizeControl(btnRePrintOriginal, btnRePrint);
            #endregion
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }


        private void frmPOS_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }

        public void LoadProducts(string strSearch)
        {
           
            try
            {
                SQLConn.sqL = "SELECT ProductNo, ProductCode, P.Description, Color, UnitPrice, Size, CategoryName FROM Product as P LEFT JOIN Category C ON P.CategoryNo = C.CategoryNo WHERE ProductCode LIKE '" + strSearch + "%' ORDER BY Description";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                ListViewItem x = null;
                lstviewProduct.Items.Clear();


                while (SQLConn.dr.Read() == true)
                {
                    x = new ListViewItem(SQLConn.dr["ProductCode"].ToString());
                    //x.SubItems.Add(SQLConn.dr["ProductCode"].ToString());
                    x.SubItems.Add(SQLConn.dr["Description"].ToString());
                    x.SubItems.Add(SQLConn.dr["Color"].ToString());
                    x.SubItems.Add(SQLConn.dr["Size"].ToString());
                    x.SubItems.Add(Strings.Format(SQLConn.dr["UnitPrice"], "#,##0.00"));
                    x.SubItems.Add("1");
                    x.SubItems.Add(x.SubItems[4].Text);
                    lstviewProduct.Items.Add(x);
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

        private void btnRePrint_Click(object sender, EventArgs e)
        {

        }

        private void pnlTransactions_Paint(object sender, PaintEventArgs e)
        {

         //   ControlPaint.DrawBorder(e.Graphics, this.pnlTransactions.ClientRectangle, Color.Teal , ButtonBorderStyle.Inset);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
        }


        /*Load products Ids for Auto complete custom source*/
        private void loadProductIDs()
        { 
            produtCodeCollection = new AutoCompleteStringCollection();
            try
            {
                SQLConn.sqL = "SELECT ProductCode FROM Product ORDER BY ProductCode";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.dr = SQLConn.cmd.ExecuteReader();

                while (SQLConn.dr.Read() == true)
                {
                    produtCodeCollection.Add(SQLConn.dr["ProductCode"].ToString());
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
            txtProductCode.AutoCompleteCustomSource = produtCodeCollection;
        
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                LoadProducts(txtProductCode.Text);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            deleteListItem();
        }

        private void lstviewProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                deleteListItem();
            }
            else if (e.KeyData == Keys.F5)
            {
                updateItemQty();
            }
        }

        private void deleteListItem()
        {
            if (lstviewProduct.Items.Count == 0)
            {
                Interaction.MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update");
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(lstviewProduct.FocusedItem.Text))
                {

                }
                else
                {
                    lstviewProduct.FocusedItem.Remove();
                }
            }
            catch
            {
                Interaction.MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update");
                return;
            }

        }

        private void lstviewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            updateItemQty();
        }

        private void updateItemQty()
        {
            String qty;
            int qtyVal;
            qty = Interaction.InputBox("ENTER PRODUCT Qty", "Update Product quantity", " ");

            try
            {
                qtyVal = Convert.ToInt32(qty);
            }

            catch
            {
                Interaction.MsgBox("Please Enter a valid quantity", MsgBoxStyle.Exclamation, "Update");
                return;
            }
            ListViewItem selectedItem = lstviewProduct.FocusedItem;
            selectedItem.SubItems[5].Text = qty;
            /*update Total cost*/
            selectedItem.SubItems[6].Text =
                //  (Convert.ToDouble(selectedItem.SubItems[4].Text) * qtyVal).ToString();
            Strings.Format(Convert.ToDouble(selectedItem.SubItems[4].Text) * qtyVal, "#,##0.00");
        
        }


    }
}