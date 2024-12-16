using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetAll();
            dataGridView1.DataSource = values;
        }

        private void btn2List_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var deletedValues = _productService.TGetById(id);
            _productService.TDelete(deletedValues);
            MessageBox.Show("Silme işlemi başarılı!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = int.Parse(cmbProductCategory.Text);
            product.ProductPrice = decimal.Parse(txtPrice.Text);
            product.ProductName = txtProductName.Text;
            product.ProductDescription = txtDescription.Text;
            product.ProductStock = int.Parse(txtStock.Text);
            _productService.TAdd(product);
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            dataGridView1.DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProductId.Text);
            var value = _productService.TGetById(id);
            value.ProductDescription = txtDescription.Text;
            value.ProductPrice = decimal.Parse(txtPrice.Text);
            value.ProductStock = int.Parse(txtStock.Text);
            value.ProductName = txtProductName.Text;
            _productService.TUpdate(value);
            MessageBox.Show("Güncelleme İşlemi Başarıyla gerçekleştirildi");
        }
    }
}

