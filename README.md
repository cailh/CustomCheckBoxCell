# CustomCheckBoxCell
Custom CheckBoxCell for C#[Windows Form] DataGridView

# Sample Code to add a CheckBoxColumn

            dataGridView1.Columns.Add(new KxCheckBoxColumn(dataGridView1) { Name = "SELECT" });
            var list = new List<AAA>();
            list.Add(new AAA() { X = "1", Y = "1" });
            list.Add(new AAA() { X = "2", Y = "2" });
            list.Add(new AAA() { X = "3", Y = "3" });
            dataGridView1.DataSource = list;