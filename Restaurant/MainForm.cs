using Restaurant.Data;
using Restaurant.Model;

namespace Restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // ������� ��������� ������.
            applicationData = new ApplicationData();

            //��������� ������ ���������
            UpdateViewProductBreakfast();
            UpdateViewProductPizzas();
            UpdateViewProductShacks();



        }

        private ApplicationData applicationData;

        /// <summary>
        /// ���������� ������� ��������� ���������� ���� ����� ����� ����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void UpdateViewProductBreakfast()
        {
            dataGridViewBreakfast.DataSource = null;
            dataGridViewBreakfast.DataSource = applicationData.ProductBreakfast;
        }

        private void UpdateViewProductPizzas()
        {
            dataGridViewPizzas.DataSource = null;
            dataGridViewPizzas.DataSource = applicationData.ProductPizzas;
        }

        private void UpdateViewProductShacks()
        {
            dataGridSnacks.DataSource = null;
            dataGridSnacks.DataSource = applicationData.ProductSnacks;
        }

     
    }

}