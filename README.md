# Cooldatagridview - Improve the designer of your datagridview.
##### DatagridView BEFORE use the cooldatagridview

[![1.png](https://s15.postimg.org/irxdzqtln/image.png)](https://postimg.org/image/amfc1l5cn/)

##### DatagridView AFTER use the cooldatagridview

[![2.png](https://s15.postimg.org/5z99zthzv/image.png)](https://postimg.org/image/ufrfuaiqf/)

### How to use
 In your Package Manager Console type 
```
  Install-Package cooldatagridview
```
#### Then import project namespace
```C#
 using cooldatagridview;
```
### Exemple
```C#
dataGridView1.DataSource = yourObjetist.ToList();
dataGridView1.CoolGrid();
```

### Another functionality
cooldatagridview also allows the user to navigate the arrow keys on the lines of datagridview.

Overwrite the ProcessCmdKey method of the form and place the following code
```C#
protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
    switch (keyData)
    {
	case Keys.Up:
	    dataGridView1.MoveToUp();
	    break;
	case Keys.Down:
	    dataGridView1.MoveToDown();
	    break;
	default:
	    break;
    }
    return base.ProcessCmdKey(ref msg, keyData);
}
```

### One more
If you want to hide a column of datagridview you can use
```C#
dataGridView1.HideColumn("ID");
```
<hr>

### License

It is available under the MIT license.
[License](https://opensource.org/licenses/mit-license.php)


