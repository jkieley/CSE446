using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;


[Database] 
public class CustomDatabase : DataContext
{
    public CustomDatabase() : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True") { }
    public Table<Course> Courses;

}