namespace bai_4
{
    partial class Form1
    {
        private Label lblTitle;
        private Label lblInstruction;
        private GroupBox grpLegend;
        private Label lblEmptyLegend;
        private Label lblSelectedLegend;
        private Label lblBookedLegend;
        private TableLayoutPanel tableSlots;
        private GroupBox grpBookingInfo;
        private Label lblTime;
        private ComboBox cboTime;
        private Label lblSelectedCountCaption;
        private Label lblSelectedCount;
        private Label lblTotalCaption;
        private Label lblTotal;
        private Button btnConfirm;
        private Button btnClear;
        private Label lblMessage;
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblInstruction = new Label();
            grpLegend = new GroupBox();
            lblEmptyLegend = new Label();
            lblSelectedLegend = new Label();
            lblBookedLegend = new Label();
            tableSlots = new TableLayoutPanel();
            grpBookingInfo = new GroupBox();
            lblTime = new Label();
            cboTime = new ComboBox();
            lblSelectedCountCaption = new Label();
            lblSelectedCount = new Label();
            lblTotalCaption = new Label();
            lblTotal = new Label();
            btnConfirm = new Button();
            btnClear = new Button();
            lblMessage = new Label();
            grpLegend.SuspendLayout();
            grpBookingInfo.SuspendLayout();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Text = "SƠ ĐỒ CHỌN VỊ TRÍ / ĐẶT BÀN HẸN GIỜ";

            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(28, 62);
            lblInstruction.Text = "Chọn một hoặc nhiều vị trí trống để đặt bàn.";

            grpLegend.Controls.Add(lblEmptyLegend);
            grpLegend.Controls.Add(lblSelectedLegend);
            grpLegend.Controls.Add(lblBookedLegend);
            grpLegend.Location = new Point(570, 16);
            grpLegend.Size = new Size(204, 112);
            grpLegend.Text = "Chú thích";

            lblEmptyLegend.AutoSize = true;
            lblEmptyLegend.Location = new Point(17, 27);
            lblEmptyLegend.Text = "■  Trống";
            lblEmptyLegend.ForeColor = Color.DimGray;
            lblSelectedLegend.AutoSize = true;
            lblSelectedLegend.Location = new Point(17, 52);
            lblSelectedLegend.Text = "■  Đang chọn";
            lblSelectedLegend.ForeColor = Color.ForestGreen;
            lblBookedLegend.AutoSize = true;
            lblBookedLegend.Location = new Point(17, 77);
            lblBookedLegend.Text = "■  Đã đặt / Đã khóa";
            lblBookedLegend.ForeColor = Color.Firebrick;

            tableSlots.ColumnCount = 5;
            tableSlots.RowCount = 4;
            tableSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableSlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableSlots.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableSlots.Location = new Point(28, 145);
            tableSlots.Size = new Size(746, 260);
            tableSlots.Padding = new Padding(5);
            tableSlots.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            grpBookingInfo.Controls.Add(lblTime);
            grpBookingInfo.Controls.Add(cboTime);
            grpBookingInfo.Controls.Add(lblSelectedCountCaption);
            grpBookingInfo.Controls.Add(lblSelectedCount);
            grpBookingInfo.Controls.Add(lblTotalCaption);
            grpBookingInfo.Controls.Add(lblTotal);
            grpBookingInfo.Location = new Point(28, 420);
            grpBookingInfo.Size = new Size(746, 92);
            grpBookingInfo.Text = "Thông tin đặt bàn";

            lblTime.AutoSize = true;
            lblTime.Location = new Point(18, 31);
            lblTime.Text = "Khung giờ:";
            cboTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTime.Items.AddRange(new object[] { "Sáng (100.000đ)", "Tối (150.000đ)" });
            cboTime.Location = new Point(91, 27);
            cboTime.Size = new Size(160, 28);
            cboTime.SelectedIndex = 0;
            cboTime.SelectedIndexChanged += cboTime_SelectedIndexChanged;

            lblSelectedCountCaption.AutoSize = true;
            lblSelectedCountCaption.Location = new Point(282, 31);
            lblSelectedCountCaption.Text = "Số vị trí đang chọn:";
            lblSelectedCount.AutoSize = true;
            lblSelectedCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectedCount.Location = new Point(416, 29);
            lblSelectedCount.Text = "0";
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Location = new Point(482, 31);
            lblTotalCaption.Text = "Tạm tính tiền:";
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.ForeColor = Color.DarkBlue;
            lblTotal.Location = new Point(583, 29);
            lblTotal.Text = "0đ";

            btnConfirm.Location = new Point(28, 529);
            btnConfirm.Size = new Size(180, 39);
            btnConfirm.Text = "Xác nhận đặt";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            btnClear.Location = new Point(220, 529);
            btnClear.Size = new Size(180, 39);
            btnClear.Text = "Hủy chọn tất cả";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.DarkGreen;
            lblMessage.Location = new Point(420, 541);
            lblMessage.Text = "";

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 590);
            Controls.Add(lblTitle);
            Controls.Add(lblInstruction);
            Controls.Add(grpLegend);
            Controls.Add(tableSlots);
            Controls.Add(grpBookingInfo);
            Controls.Add(btnConfirm);
            Controls.Add(btnClear);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interactive Slot Booking";
            Load += Form1_Load;
            grpLegend.ResumeLayout(false);
            grpLegend.PerformLayout();
            grpBookingInfo.ResumeLayout(false);
            grpBookingInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
