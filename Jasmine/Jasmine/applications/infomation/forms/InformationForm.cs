using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jasmine.applications.infomation.forms
{
    public partial class InformationForm : Form
    {
        private List<Button> btnList;
        public InformationForm()
        {
            InitializeComponent();
            CenterToScreen();
            initUI();
        }

        private void initUI() {

            Panel parent = splitContainer1.Panel1;
            setMainButton("录入信息", parent);
            setMainButton("查看信息", parent);
            setMainButton("备件任务书", parent);
            setMainButton("发交任务书", parent);
            btnList = new List<Button>();
            foreach (Button btn in parent.Controls)
            {
                btnList.Add(btn);
            }
        }

        private void setMainButton(string buttonText,Panel panel) {


            Button button = new Button();
            button.Text = buttonText;
            button.Anchor = ((((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
            button.BackColor = Color.WhiteSmoke;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("宋体", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            button.Size = new Size(128, 40);
            button.ForeColor = Color.FromArgb(138, 134, 134);
            button.Location = new Point(0, 40 * panel.Controls.Count);
            button.Tag = panel.Controls.Count;
            button.UseVisualStyleBackColor = false;
            panel.Controls.Add(button);

            switch (buttonText)
            {
                case "录入信息":
                    button.Click += form1_show;
                    break;
                case "查看信息":
                    button.Click += form2_show;
                    break;
                case "备件任务书":
                    button.Click += form3_show;
                    break;
                case "发交任务书":
                    button.Click += form4_show;
                    break;
                default: break;
            }

        }
        private void form1_show(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            setBtnSelected((int)btn.Tag);
            //MissionDetailsForm missionDetailsForm = new MissionDetailsForm(type);
            //missionDetailsForm.Show();
            //missionDetailsForm.TopLevel = false;
            //missionDetailsForm.Dock = DockStyle.Fill;
            //splitContainer1.Panel2.Controls.Clear();
            //splitContainer1.Panel2.Controls.Add(missionDetailsForm);
        }

        private void form2_show(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            setBtnSelected((int)btn.Tag);
            this.splitContainer1.Panel2.Controls.Clear();
            //MissionDetailsForm missionDetailsForm = new MissionDetailsForm(type);
            //missionDetailsForm.Show();
            //missionDetailsForm.TopLevel = false;
            //missionDetailsForm.Dock = DockStyle.Fill;
            //this.splitContainer1.Panel2.Controls.Add(missionDetailsForm);
        }

        private void form3_show(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            setBtnSelected((int)btn.Tag);
            //MissionDetailsForm form = new MissionDetailsForm(type);
            //form.Show();
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //splitContainer1.Panel2.Controls.Clear();
            //splitContainer1.Panel2.Controls.Add(form);
        }

        private void form4_show(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            setBtnSelected((int)btn.Tag);
            //MissionDetailsForm form = new MissionDetailsForm(type);
            //form.Show();
            //form.TopLevel = false;
            //form.Dock = DockStyle.Fill;
            //splitContainer1.Panel2.Controls.Clear();
            //splitContainer1.Panel2.Controls.Add(form);
        }

        private void setBtnSelected(int index)
        {
            for (int i = 0; i < btnList.Count; i++)
            {
                if (i == index)
                {
                    btnList[i].BackColor = Color.FromArgb(128, 151, 193);
                    btnList[i].ForeColor = Color.White;
                }
                else
                {
                    btnList[i].BackColor = Color.WhiteSmoke;
                    btnList[i].ForeColor = Color.FromArgb(138, 134, 134);
                }
            }
        }

    }
}
