using System.Windows.Forms;

namespace WFA_HamburgerOtomasyonOOP
{
    public class Fonksiyon
    {
        
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if(item is TextBox)
                {
                    TextBox txt=(TextBox)item;
                    txt.Clear();
                }
                else if(item is CheckBox)
                {
                    CheckBox chk = (CheckBox)item;
                    chk.Checked = false;
                }
                else if(item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Text== "Orta")
                    {
                        rb.Checked = true;
                    }
                    else
                    {
                        rb.Checked = false;
                    }
                }
                else if(item is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)item;
                    nud.Value = 1;
                }
                else if(item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = -1;
                }
                else if(item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayout = (FlowLayoutPanel)item;
                    Temizle(flowLayout.Controls);
                }
            }
        }
    }
}
