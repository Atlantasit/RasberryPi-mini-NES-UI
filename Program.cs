class director{
    public main(){

        
    }

    private void button1_Click(object sender, EventArgs e)

        {

            DialogResult dr =  MessageBox.Show("Do you want to close this window?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)

                this.Close();

        }
}