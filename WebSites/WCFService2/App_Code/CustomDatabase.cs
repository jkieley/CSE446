using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;


[Database] 
public class CustomDatabase : DataContext
{
	public CustomDatabase() : base("~/App_Data/Database.mdf"){}
    public Table<Course> Courses;

}