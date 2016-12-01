/*
 * Created by SharpDevelop.
 * User: Harriet
 * Date: 16/01/2017
 * Time: 01:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DataMiner
{
	partial class UcInvoice
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
			this.lblDateTime = new System.Windows.Forms.Label();
			this.lblInvoiceNumber = new System.Windows.Forms.Label();
			this.btnView = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDateTime
			// 
			this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateTime.Location = new System.Drawing.Point(3, 23);
			this.lblDateTime.Name = "lblDateTime";
			this.lblDateTime.Size = new System.Drawing.Size(139, 23);
			this.lblDateTime.TabIndex = 4;
			this.lblDateTime.Text = "Date and Time";
			// 
			// lblInvoiceNumber
			// 
			this.lblInvoiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInvoiceNumber.Location = new System.Drawing.Point(3, 0);
			this.lblInvoiceNumber.Name = "lblInvoiceNumber";
			this.lblInvoiceNumber.Size = new System.Drawing.Size(139, 23);
			this.lblInvoiceNumber.TabIndex = 3;
			this.lblInvoiceNumber.Text = "Invoice Number";
			// 
			// btnView
			// 
			this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnView.Location = new System.Drawing.Point(148, 3);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(75, 43);
			this.btnView.TabIndex = 5;
			this.btnView.Text = "View";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.BtnViewClick);
			// 
			// UcInvoice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.lblDateTime);
			this.Controls.Add(this.lblInvoiceNumber);
			this.Name = "UcInvoice";
			this.Size = new System.Drawing.Size(303, 57);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Label lblInvoiceNumber;
		private System.Windows.Forms.Label lblDateTime;
	}
}
