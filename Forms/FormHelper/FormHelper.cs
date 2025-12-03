using System;
using System.Windows.Forms;

public static class FormHelpers
{
    public static void ClearFormControls(Control parent)
    {
        foreach (Control ctrl in parent.Controls)
        {
            if (ctrl is TextBox textBox)
            {
                textBox.Clear();
            }
            else if (ctrl is ComboBox comboBox)
            {
                comboBox.SelectedIndex = -1;
            }
            else if (ctrl is CheckBox checkBox)
            {
                checkBox.Checked = false;   // uncheck checkboxes
            }
            else if (ctrl is DateTimePicker dateTimePicker)
            {
                dateTimePicker.Value = DateTime.Now;
            }
            else if (ctrl.HasChildren)
            {
                ClearFormControls(ctrl);    // recursive cleanup
            }
        }
    }
}
