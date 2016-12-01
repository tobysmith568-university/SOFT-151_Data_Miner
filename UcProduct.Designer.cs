/*
 * Created by SharpDevelop.
 * User: Harriet
 * Date: 16/01/2017
 * Time: 00:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DataMiner
{
	partial class UcProduct
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblCodeName = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblCodeName
			// 
			this.lblCodeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodeName.Location = new System.Drawing.Point(3, 5);
			this.lblCodeName.Name = "lblCodeName";
			this.lblCodeName.Size = new System.Drawing.Size(297, 23);
			this.lblCodeName.TabIndex = 0;
			this.lblCodeName.Text = "Stockcode: Name";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUnitPrice.Location = new System.Drawing.Point(3, 28);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(89, 23);
			this.lblUnitPrice.TabIndex = 1;
			this.lblUnitPrice.Text = "Unit Price";
			// 
			// lblQuantity
			// 
			this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(98, 28);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(79, 23);
			this.lblQuantity.TabIndex = 2;
			this.lblQuantity.Text = "Quant";
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(183, 28);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(74, 23);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "Total Price";
			// 
			// UcProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.lblUnitPrice);
			this.Controls.Add(this.lblCodeName);
			this.Name = "UcProduct";
			this.Size = new System.Drawing.Size(303, 57);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblCodeName;
	}
}
