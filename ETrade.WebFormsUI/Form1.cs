using ETrade.Business.Abstract;
using ETrade.Business.Concrete;
using ETrade.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETrade.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productservice = new ProductManager(new EfProductDal());
        }
        private IProductService _productservice;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgwProduct.DataSource = _productservice.GetAll();
        }
    }
}
