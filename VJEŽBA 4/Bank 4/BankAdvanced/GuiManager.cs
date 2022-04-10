using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    class GuiManager
    {
        private Form _parentForm;
        private RacuniForm _defaultForm;

        public GuiManager(Form form)
        {
            _parentForm = form;
            _defaultForm = new RacuniForm();
        }

        public void ShowChildForm(Form childForm)
        {
            childForm.MdiParent = _parentForm;
            childForm.Show();
        }

        public void ShowDefaultForm()
        {
            ShowChildForm(_defaultForm);
        }
    }
}
