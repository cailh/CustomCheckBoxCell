# CustomCheckBoxCell
Custom CheckBoxCell for C#[Windows Form] DataGridView

# Sample Code to add a CheckBoxColumn

            dataGridView1.Columns.Add(new KxCheckBoxColumn(dataGridView1) { Name = "SELECT" });
            var list = new List<AAA>();
            list.Add(new AAA() { X = "1", Y = "1" });
            list.Add(new AAA() { X = "2", Y = "2" });
            list.Add(new AAA() { X = "3", Y = "3" });
            dataGridView1.DataSource = list;
# Sample output

<p align="center">
  <img src="https://raw.githubusercontent.com/mataprasad/CustomCheckBoxCell/master/Kx.KxCheckBoxCell.Demo/demo.png" />
</p>      

# Benefits of CheckBoxColumn

<ul>
    <li> You can access <b>Checked</b>[boolean] property of cell to find if the cell is checked or not, which is not available in standard <b>DataGridViewCheckBoxCell</b> . 
    var isChecked = ((KxCheckBoxCell)item.Cells[0]).Checked;
</ul> 