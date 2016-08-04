namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Rtb_TX = new System.Windows.Forms.RichTextBox();
            this.Rtb_RX = new System.Windows.Forms.RichTextBox();
            this.Cb_IM = new System.Windows.Forms.CheckBox();
            this.Srl_MySerial = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(696, 12);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(120, 31);
            this.Btn_Send.TabIndex = 0;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(696, 238);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(120, 30);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Rtb_TX
            // 
            this.Rtb_TX.Location = new System.Drawing.Point(12, 12);
            this.Rtb_TX.Name = "Rtb_TX";
            this.Rtb_TX.Size = new System.Drawing.Size(664, 31);
            this.Rtb_TX.TabIndex = 2;
            this.Rtb_TX.Text = "";
            this.Rtb_TX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtb_TX_KeyPress);
            // 
            // Rtb_RX
            // 
            this.Rtb_RX.Location = new System.Drawing.Point(12, 59);
            this.Rtb_RX.Name = "Rtb_RX";
            this.Rtb_RX.Size = new System.Drawing.Size(664, 209);
            this.Rtb_RX.TabIndex = 3;
            this.Rtb_RX.Text = "";
            // 
            // Cb_IM
            // 
            this.Cb_IM.AutoSize = true;
            this.Cb_IM.Location = new System.Drawing.Point(707, 75);
            this.Cb_IM.Name = "Cb_IM";
            this.Cb_IM.Size = new System.Drawing.Size(38, 17);
            this.Cb_IM.TabIndex = 4;
            this.Cb_IM.Text = "IM";
            this.Cb_IM.UseVisualStyleBackColor = true;
            // 
            // Srl_MySerial
            // 
            this.Srl_MySerial.PortName = "COM18";
            this.Srl_MySerial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Srl_MySerial_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 280);
            this.Controls.Add(this.Cb_IM);
            this.Controls.Add(this.Rtb_RX);
            this.Controls.Add(this.Rtb_TX);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Send);
            this.Name = "Form1";
            this.Text = "My UART";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.RichTextBox Rtb_TX;
        private System.Windows.Forms.RichTextBox Rtb_RX;
        private System.Windows.Forms.CheckBox Cb_IM;
        private System.IO.Ports.SerialPort Srl_MySerial;
    }
}

