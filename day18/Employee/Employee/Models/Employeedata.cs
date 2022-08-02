namespace Employee.Models
{
    public class Employeedata
    {
        public List<Employees> employeesList { get; set; }

        public Employeedata()
        {
            employeesList = new List<Employees>()
            {
                 new Employees()
        {
            Id =1,
            Name="manisha" ,
            phonenumber=855500,
            Email ="leela09@gmail.com",
            city ="vishakapatnam",
            age=20 ,

    },
  new Employees()
        {
             Id =2,
            Name="vinodini" ,
            phonenumber=63024,
            Email ="vino24@gmail.com",
            city ="chenni",
            age=20 ,
                },
                new Employees()
        {
             Id =3,
            Name="sowji" ,
            phonenumber=92264,
            Email ="sowji29@gmail.com",
            city ="vishakapatnam",
            age=20 ,
                }
    };
        }
    }
}
