using Introduction.Models;

Ripository ripo = new Ripository();
//ripo.UpdatePerson(2 , "mahan" , "jafarzadeh");
//ripo.UpdatePerson(5, "AmirhosseinUpdate", "Azarakhsh"); when null
//ripo.AddPerson("mahan","jafarzadeh");
//ripo.AddPerson("mehrshad" , "torkamanzade");
ripo.PrintPeople();
Console.WriteLine("Select the Id you want to delete");
int id = Convert.ToInt32(Console.ReadLine());
ripo.DeleteMembers(id);