namespace QRCodeGenerator
{
    partial class FrmMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnWifiType = new System.Windows.Forms.Button();
            this.btnEmailType = new System.Windows.Forms.Button();
            this.btnEventType = new System.Windows.Forms.Button();
            this.btnGeolocationType = new System.Windows.Forms.Button();
            this.btnCallType = new System.Windows.Forms.Button();
            this.btnSmsType = new System.Windows.Forms.Button();
            this.btnVCardType = new System.Windows.Forms.Button();
            this.btnTextType = new System.Windows.Forms.Button();
            this.btnUrlType = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Controls.Add(this.tableLayoutPanel1);
            this.pnlMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 609);
            this.pnlMenu.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnWifiType, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnEmailType, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEventType, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGeolocationType, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCallType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSmsType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVCardType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTextType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUrlType, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 609);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnWifiType
            // 
            this.btnWifiType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWifiType.Image = global::QRCodeGenerator.Properties.Resources.wifi;
            this.btnWifiType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWifiType.Location = new System.Drawing.Point(3, 539);
            this.btnWifiType.Name = "btnWifiType";
            this.btnWifiType.Size = new System.Drawing.Size(194, 67);
            this.btnWifiType.TabIndex = 8;
            this.btnWifiType.Text = "Wifi";
            this.btnWifiType.UseVisualStyleBackColor = true;
            // 
            // btnEmailType
            // 
            this.btnEmailType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmailType.Image = global::QRCodeGenerator.Properties.Resources.email;
            this.btnEmailType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmailType.Location = new System.Drawing.Point(3, 472);
            this.btnEmailType.Name = "btnEmailType";
            this.btnEmailType.Size = new System.Drawing.Size(194, 61);
            this.btnEmailType.TabIndex = 7;
            this.btnEmailType.Text = "Email";
            this.btnEmailType.UseVisualStyleBackColor = true;
            // 
            // btnEventType
            // 
            this.btnEventType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventType.Image = global::QRCodeGenerator.Properties.Resources._event;
            this.btnEventType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventType.Location = new System.Drawing.Point(3, 405);
            this.btnEventType.Name = "btnEventType";
            this.btnEventType.Size = new System.Drawing.Size(194, 61);
            this.btnEventType.TabIndex = 6;
            this.btnEventType.Text = "Event";
            this.btnEventType.UseVisualStyleBackColor = true;
            // 
            // btnGeolocationType
            // 
            this.btnGeolocationType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGeolocationType.Image = global::QRCodeGenerator.Properties.Resources.geolocalization;
            this.btnGeolocationType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeolocationType.Location = new System.Drawing.Point(3, 338);
            this.btnGeolocationType.Name = "btnGeolocationType";
            this.btnGeolocationType.Size = new System.Drawing.Size(194, 61);
            this.btnGeolocationType.TabIndex = 5;
            this.btnGeolocationType.Text = "Geolocation";
            this.btnGeolocationType.UseVisualStyleBackColor = true;
            // 
            // btnCallType
            // 
            this.btnCallType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCallType.Image = global::QRCodeGenerator.Properties.Resources.call;
            this.btnCallType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCallType.Location = new System.Drawing.Point(3, 271);
            this.btnCallType.Name = "btnCallType";
            this.btnCallType.Size = new System.Drawing.Size(194, 61);
            this.btnCallType.TabIndex = 4;
            this.btnCallType.Text = "Call";
            this.btnCallType.UseVisualStyleBackColor = true;
            // 
            // btnSmsType
            // 
            this.btnSmsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmsType.Image = global::QRCodeGenerator.Properties.Resources.sms;
            this.btnSmsType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmsType.Location = new System.Drawing.Point(3, 204);
            this.btnSmsType.Name = "btnSmsType";
            this.btnSmsType.Size = new System.Drawing.Size(194, 61);
            this.btnSmsType.TabIndex = 3;
            this.btnSmsType.Text = "SMS";
            this.btnSmsType.UseVisualStyleBackColor = true;
            // 
            // btnVCardType
            // 
            this.btnVCardType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVCardType.Image = global::QRCodeGenerator.Properties.Resources.vcard;
            this.btnVCardType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVCardType.Location = new System.Drawing.Point(3, 137);
            this.btnVCardType.Name = "btnVCardType";
            this.btnVCardType.Size = new System.Drawing.Size(194, 61);
            this.btnVCardType.TabIndex = 2;
            this.btnVCardType.Text = "VCard";
            this.btnVCardType.UseVisualStyleBackColor = true;
            // 
            // btnTextType
            // 
            this.btnTextType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTextType.Image = global::QRCodeGenerator.Properties.Resources.text;
            this.btnTextType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTextType.Location = new System.Drawing.Point(3, 70);
            this.btnTextType.Name = "btnTextType";
            this.btnTextType.Size = new System.Drawing.Size(194, 61);
            this.btnTextType.TabIndex = 1;
            this.btnTextType.Text = "Text";
            this.btnTextType.UseVisualStyleBackColor = true;
            // 
            // btnUrlType
            // 
            this.btnUrlType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUrlType.Image = global::QRCodeGenerator.Properties.Resources.url;
            this.btnUrlType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrlType.Location = new System.Drawing.Point(3, 3);
            this.btnUrlType.Name = "btnUrlType";
            this.btnUrlType.Size = new System.Drawing.Size(194, 61);
            this.btnUrlType.TabIndex = 0;
            this.btnUrlType.Text = "URL";
            this.btnUrlType.UseVisualStyleBackColor = true;
            this.btnUrlType.Click += new System.EventHandler(this.btnUrlType_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 624);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnWifiType;
        private System.Windows.Forms.Button btnEmailType;
        private System.Windows.Forms.Button btnEventType;
        private System.Windows.Forms.Button btnGeolocationType;
        private System.Windows.Forms.Button btnCallType;
        private System.Windows.Forms.Button btnSmsType;
        private System.Windows.Forms.Button btnVCardType;
        private System.Windows.Forms.Button btnTextType;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUrlType;
        private System.Windows.Forms.Panel pnlMenu;
    }
}
