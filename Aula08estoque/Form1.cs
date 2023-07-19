namespace Aula08estoque
{
    public partial class Form1 : Form
    {
        List<string> produto_nome = new List<string>(); 
        List<int> produto_quantidade = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        void adicionaproduto()
        {
            string nome = txtnome.Text;
            int quantidade = int.Parse( txtquantidade.Text);
            produto_nome.Add(nome);
            produto_quantidade.Add(quantidade);
        }
        void atualizainterface()
        {
            int qntcadastrados = produto_nome.Count();
            
            lblcadastrados.Text =  qntcadastrados.ToString();
            
        }
        void limpaCampo()
        {
            txtnome.Clear();
            txtquantidade.Clear();
            txtnome.Focus();
        }
        void ver_produto(bool primeiro)
        {
            if(listaVazia() == true)
            {
                MessageBox.Show("....");
                return;
            }

           string nome;
            int qnt;
            if (primeiro ==  true)
            {
                nome = produto_nome[0];
                qnt = produto_quantidade[0];
            }
            else
            {
                nome = produto_nome[produto_nome.Count - 1];
                qnt = produto_quantidade[produto_quantidade.Count() - 1];
            }
            MessageBox.Show($"nome : {nome}, Quantidade: {qnt}");
        }
        void remover()
        {
            if (listaVazia() == true)
            {
                MessageBox.Show("Você não pode remover!");
            }
            else
            {
                produto_nome.RemoveAt(0);
                produto_quantidade.RemoveAt(0);
                atualizainterface();

            }
           
        }
        bool listaVazia()
        {
            if(produto_nome.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //-------------------------------------------------------------------

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            adicionaproduto(); 
            atualizainterface();
            limpaCampo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpaCampo();
        }

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1produto_Click(object sender, EventArgs e)
        {
            ver_produto(true);
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            ver_produto(false);
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            remover();


        }

        private void lblcadastrados_Click(object sender, EventArgs e)
        {

        }

        private void lblquantidade_Click(object sender, EventArgs e)
        {

        }
    }
}