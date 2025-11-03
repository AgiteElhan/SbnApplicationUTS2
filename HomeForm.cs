using SbnApplication2.Design;
using SbnApplicationUTS.Design;

namespace SbnApplicationUTS2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        internal void setVisible(bool v)
        {
            this.Visible = v;
        }
        private void btnBuyer_Click(object sender, EventArgs e)
        {
            BuyerForm formBuyer = new BuyerForm();
            formBuyer.setVisible(true);
        }

        private void btnSBN_Click(object sender, EventArgs e)
        {
            SbnForm formSbn = new SbnForm();
            formSbn.setVisible(true);
        }

        private void btnAsset_Click(object sender, EventArgs e)
        {
            AssetForm formAsset = new AssetForm();
            formAsset.setVisible(true);
        }
    }
}
