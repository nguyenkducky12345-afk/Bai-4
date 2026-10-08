namespace bai_4
{
    public partial class Form1 : Form
    {
        private readonly List<Button> slotButtons = new();
        private readonly HashSet<int> bookedSlots = new();
        private const decimal MorningPrice = 100000m;
        private const decimal EveningPrice = 150000m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            CreateSlotButtons();
            UpdateSummary();
        }

        private void CreateSlotButtons()
        {
            for (int index = 0; index < 20; index++)
            {
                Button slotButton = new()
                {
                    Name = $"btnSlot{index + 1}",
                    Text = $"Bàn {index + 1}",
                    Dock = DockStyle.Fill,
                    Margin = new Padding(8),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    Tag = index,
                    BackColor = Color.WhiteSmoke,
                    ForeColor = Color.DimGray,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false
                };

                slotButton.FlatAppearance.BorderColor = Color.Silver;
                slotButton.Click += SlotButton_Click;
                slotButtons.Add(slotButton);
                tableSlots.Controls.Add(slotButton, index % 5, index / 5);
            }
        }

        private void SlotButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button slotButton || slotButton.Tag is not int slotIndex)
            {
                return;
            }

            if (bookedSlots.Contains(slotIndex))
            {
                return;
            }

            slotButton.BackColor = slotButton.BackColor == Color.LightGreen
                ? Color.WhiteSmoke
                : Color.LightGreen;
            slotButton.ForeColor = slotButton.BackColor == Color.LightGreen
                ? Color.DarkGreen
                : Color.DimGray;
            UpdateSummary();
        }

        private void cboTime_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            int selectedCount = slotButtons.Count(button => button.BackColor == Color.LightGreen);
            decimal total = selectedCount * GetCurrentPrice();
            lblSelectedCount.Text = selectedCount.ToString();
            lblTotal.Text = $"{total:N0}đ";
        }

        private decimal GetCurrentPrice()
        {
            return cboTime.SelectedIndex == 1 ? EveningPrice : MorningPrice;
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            foreach (Button slotButton in slotButtons)
            {
                if (slotButton.Tag is int slotIndex && !bookedSlots.Contains(slotIndex))
                {
                    slotButton.BackColor = Color.WhiteSmoke;
                    slotButton.ForeColor = Color.DimGray;
                }
            }

            lblMessage.Text = "Đã hủy các lựa chọn hiện tại.";
            lblMessage.ForeColor = Color.DarkOrange;
            UpdateSummary();
        }

        private void btnConfirm_Click(object? sender, EventArgs e)
        {
            List<Button> selectedButtons = slotButtons
                .Where(button => button.BackColor == Color.LightGreen)
                .ToList();

            if (selectedButtons.Count == 0)
            {
                lblMessage.Text = "Vui lòng chọn ít nhất một vị trí.";
                lblMessage.ForeColor = Color.Firebrick;
                return;
            }

            foreach (Button slotButton in selectedButtons)
            {
                if (slotButton.Tag is int slotIndex)
                {
                    bookedSlots.Add(slotIndex);
                }

                slotButton.BackColor = Color.LightCoral;
                slotButton.ForeColor = Color.Maroon;
                slotButton.Text += " (Đã đặt)";
                slotButton.Cursor = Cursors.Default;
            }

            lblMessage.Text = $"Đã xác nhận {selectedButtons.Count} vị trí.";
            lblMessage.ForeColor = Color.DarkGreen;
            UpdateSummary();
        }
    }
}
