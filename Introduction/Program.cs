using Introduction.Models;

Ripository ripo = new Ripository();
ripo.UpdatePerson(2 , "mahan" , "jafarzadeh");

ripo.AddPerson("mahan","jafarzadeh");
ripo.PrintPeople();
Console.WriteLine("Select the Id you want to delete");
int id = Convert.ToInt32(Console.ReadLine());
ripo.DeleteMembers(id);
Console.ReadLine();
