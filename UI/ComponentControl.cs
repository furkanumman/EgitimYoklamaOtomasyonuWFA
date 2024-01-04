using BLL.Services;

namespace UI
{
    public static class ComponentControl
    {
        public static bool BlankControl(GroupBox grpBox)
        {
            bool kontrol = true;
            foreach (Control item in grpBox.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        MessageBox.Show($"{item.Tag} boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kontrol = false;
                    }
                }
                else if (item is MaskedTextBox)
                {
                    if (((MaskedTextBox)item).MaskFull == false)
                    {
                        MessageBox.Show($"{item.Tag} boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kontrol = false;
                    }
                }
                else if (item is ComboBox && item.Tag != "Şubesi")
                {
                    if (((ComboBox)item).SelectedIndex == -1)
                    {
                        MessageBox.Show($"{item.Tag} boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kontrol = false;
                    }
                }
                else if (item is CheckedListBox)
                {
                    if (((CheckedListBox)item).CheckedItems.Count == 0)
                    {
                        MessageBox.Show($"{item.Tag} boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kontrol = false;
                    }
                }
            }
            return kontrol;
        }

        public static void ControlClean(GroupBox grpBox)
        {
            foreach (Control item in grpBox.Controls)
            {
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;

                }
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = string.Empty;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                else if (item is CheckedListBox)
                {
                    for (int i = 0; i < ((CheckedListBox)item).Items.Count; i++)
                    {
                        ((CheckedListBox)item).SetItemChecked(i, false);
                    }
                }
                else if (item is Label && item.Tag == "CleaningIsRequired")
                    item.Text = "?????";
            }
        }

        public static bool AnyTableLayoutPanel(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TableLayoutPanel)
                {
                    return true;
                }
            }
            return false;
        }


        public static void FillWithBranch(ComboBox cmbBox)
        {
            BranchService branchService = new BranchService();

            var list = branchService.GetAll();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    cmbBox.Items.Add(item.Name);
                }

            }

        }

    }
}